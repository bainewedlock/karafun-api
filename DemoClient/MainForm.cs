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
    ConcurrentQueue<XElement> Incoming_Messages = new ConcurrentQueue<XElement>();
    AsyncAutoResetEvent Queue_Changed = new AsyncAutoResetEvent();
    WebSocket ws;

    public MainForm()
    {
      InitializeComponent();
      ControlsPanel.Enabled = false;
    }

    async void ConnectButton_Click(object sender, EventArgs e)
    {
      ConnectButton.Enabled = false;
      ControlsPanel.Enabled = true;

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

    void Route_Message(XElement message)
    {
      ResponseTextBox.Text = message.ToString();

      switch (message.Name.LocalName)
      {
        case "status": Process_Status(message); break;
      }
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

    async void GetStatusButton_Click(object sender, EventArgs e)
    {
      var request = new XElement("action");
      request.SetAttributeValue("type", "getStatus");

      await Send(request);
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

    async Task Send(XElement request)
    {
      PlayButton.Enabled = false;
      PauseButton.Enabled = false;

      ResponseTextBox.Text = "";

      string request_string = request.ToString();
      RequestTextBox.Text = request_string;

      var finish_flag = new AsyncAutoResetEvent();
      ws.SendAsync(request_string, result => finish_flag.Set());
      await finish_flag.WaitAsync();
    }
  }
}
