using System;
using System.Collections.Concurrent;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using WebSocketSharp;

namespace DemoClient
{
  public partial class MainForm : Form
  {
    static readonly string PlayerAddress = ConfigurationManager.AppSettings["PlayerAddress"];
    static readonly TimeSpan Minimal_Volume_Change_Delay = TimeSpan.FromMilliseconds(200);
    ConcurrentQueue<XElement> Incoming_Messages = new ConcurrentQueue<XElement>();
    AsyncAutoResetEvent Queue_Changed = new AsyncAutoResetEvent();
    AsyncAutoResetEvent Volume_Changed = new AsyncAutoResetEvent();
    WebSocket ws;

    public MainForm()
    {
      InitializeComponent();
      Enable_Controls(false);
    }

    async void MainForm_Load(object sender, EventArgs e)
    {
      await Keep_Updating_Volume();
    }

    async void ConnectButton_Click(object sender, EventArgs e)
    {
      Enable_Controls(true);

      using (ws = new WebSocket(PlayerAddress))
      {
        ws.OnMessage += Ws_OnMessage;
        ws.Connect();

        while (true)
        {
          await Queue_Changed.WaitAsync();
          if (Incoming_Messages.TryDequeue(out var message))
          {
            try
            {
              Route_Message(message);
            }
            catch (Exception ex)
            {
              ResponseTextBox.Text = $"Error Processing Message:||{message}||{ex}".Replace("|", "\r\n");
            }
          }
        }
      }
    }

    void Enable_Controls(bool connected)
    {
      ConnectButton.Enabled = !connected;
      ControlsPanel.Enabled = connected;
      SongSuchenButton.Enabled = connected;
      SuchergebnisAbspielenButton.Enabled = connected;
    }

    void Route_Message(XElement message)
    {
      ResponseTextBox.Text = $@"{DateTime.Now:HH\:mm\:ss}||{message}".Replace("|", "\r\n");

      switch (message.Name.LocalName)
      {
        case "status": Process_Status(message); break;
        case "list": Process_List(message); break;
      }
    }

    void Process_List(XElement message)
    {
      SongListbox.Items.Clear();

      foreach (var item in message.Elements("item"))
      {
        SongListbox.Items.Add(Song.Parse(item));
      }

      SongListbox.DisplayMember = "display_text";
    }

    void Process_Status(XElement message)
    {
      // Buttons je nach Status aktivieren
      string status = message.Attribute("state")?.Value;
      switch (status)
      {
        case "infoscreen":
        case "idle":
          PlayButton.Enabled = true;
          PauseButton.Enabled = false;
          break;
        case "playing":
          PlayButton.Enabled = false;
          PauseButton.Enabled = true;
          break;
        default: MessageBox.Show($"new status: {status}"); break;
      }

      // Informationen über den nächsten Song anzeigen, falls vorhanden
      var queued_items = message.Element("queue").Elements("item").ToArray();
      if (queued_items.Length == 0)
      {
        TitleTextBox.Text = "N/A";
        ArtistTextBox.Text = "N/A";
      }
      else
      {
        var next_item = queued_items[0];
        TitleTextBox.Text = next_item.Element("title").Value;
        ArtistTextBox.Text = next_item.Element("artist").Value;
      }
    }

    void Ws_OnMessage(object sender, MessageEventArgs e)
    {
      Incoming_Messages.Enqueue(XElement.Parse(e.Data));
      Queue_Changed.Set();
    }

    async Task Send(XElement request)
    {
      PlayButton.Enabled = false;
      PauseButton.Enabled = false;
      ResponseTextBox.Text = "";

      string request_string = request.ToString();
      RequestTextBox.Text = $@"{DateTime.Now:HH\:mm\:ss}||{request_string}".Replace("|", "\r\n");

      var finish_flag = new AsyncAutoResetEvent();
      ws.SendAsync(request_string, result => finish_flag.Set());
      await finish_flag.WaitAsync();
    }

    async void PlayButton_Click(object sender, EventArgs e)
    {
      var request = new XElement("action");
      request.SetAttributeValue("type", "play");
      await Send(request);
    }

    async void PauseButton_Click(object sender, EventArgs e)
    {
      var request = new XElement("action");
      request.SetAttributeValue("type", "pause");
      await Send(request);
    }

    async void SongSuchenButton_Click(object sender, EventArgs e)
    {
      await SongSuchen();
    }

    async Task SongSuchen()
    {
      var search_string = SongSuchenTextbox.Text;
      var request = new XElement("action");
      request.SetAttributeValue("type", "search");
      request.SetAttributeValue("offset", "0");
      request.SetAttributeValue("limit", "100");
      request.SetValue(search_string);
      await Send(request);
    }

    async void SuchergebnisAbspielenButton_Click(object sender, EventArgs e)
    {
      var selected_song = SongListbox.SelectedItem as Song;

      // clear queue
      var clearQueue = new XElement("action");
      clearQueue.SetAttributeValue("type", "clearQueue");
      await Send(clearQueue);

      // add selected song to queue
      var add_position = 0;
      var addToQueue = new XElement("action");
      addToQueue.SetAttributeValue("type", "addToQueue");
      addToQueue.SetAttributeValue("song", $"{selected_song.id}");
      addToQueue.SetValue(add_position);
      await Send(addToQueue);
    }

    void SongListbox_SelectedValueChanged(object sender, EventArgs e)
    {
      SuchergebnisAbspielenButton.Enabled = SongListbox.SelectedItem != null;
    }

    void VolumeTrackbar_Scroll(object sender, EventArgs e)
    {
      Volume_Changed.Set();
    }

    async Task Keep_Updating_Volume()
    {
      while (true)
      {
        await Volume_Changed.WaitAsync();

        var setVolume = new XElement("action");
        setVolume.SetAttributeValue("type", "setVolume");
        setVolume.SetAttributeValue("volume_type", "general");
        setVolume.SetValue(VolumeTrackbar.Value);
        await Send(setVolume);

        await Task.Delay(Minimal_Volume_Change_Delay);
      }
    }

    async void SongSuchenTextbox_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyData == Keys.Enter && SongSuchenButton.Enabled)
      {
        await SongSuchen();
      }
    }
  }
}
