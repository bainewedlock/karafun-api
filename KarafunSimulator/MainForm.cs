using System;
using System.Configuration;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace KarafunSimulator
{
  public partial class MainForm : Form
  {
    static readonly int TcpServerPort = Convert.ToInt32(ConfigurationManager.AppSettings["TcpServerPort"]);

    public MainForm()
    {
      InitializeComponent();
    }

    async void StartServerButton_Click(object sender, System.EventArgs e)
    {
      StartServerButton.Enabled = false;

      var localhost = IPAddress.Parse("127.0.0.1");
      var tcp_listener = new TcpListener(localhost, TcpServerPort);
      tcp_listener.Start();

      Log($"Listening at port {TcpServerPort}");

      while (true)
      {
        var socket = await tcp_listener.AcceptSocketAsync();

        var buffer = new byte[1000];
        var received_bytes = socket.Receive(buffer);
        var received_string = Encoding.ASCII.GetString(buffer, 0, received_bytes);

        Log($"received: {received_string}");
        string response_string = Receive_String_Message(received_string);

        if (SimulateDelayCheckbox.Checked)
        {
          await Task.Delay(TimeSpan.FromSeconds(1));
        }

        var response_bytes = Encoding.ASCII.GetBytes(response_string);
        socket.Send(response_bytes);

        Log($"sent: {response_string}");
      }
    }

    string Receive_String_Message(string received_string)
    {
      var xml = XElement.Parse(received_string);
      return Receive_Xml_Message(xml).ToString();
    }

    private static XElement Receive_Xml_Message(XElement xml)
    {
      var action_type = xml.Attribute("type").Value;

      switch (action_type)
      {
        case "getStatus":
          return Example_Status_Response();
        case "play":
        case "pause":
          return Example_Okay_Response();
      }
      return new XElement("Error", $"Unknown action type: {action_type}");
    }

    static XElement Example_Okay_Response()
    {
      return new XElement("okay");
    }

    static XElement Example_Status_Response()
    {
      return new XElement("status",
        new XElement("volumeList",
          new XElement("general")),
        new XElement("pitch", 10),
        new XElement("tempo", 110),
        new XElement("queue",
          new XElement("item")));
    }

    void Log(string message)
    {
      var message_with_timestamp = $@"{DateTime.Now:HH\:mm\:ss} {message}";
      ProtokollListBox.Items.Insert(0, message_with_timestamp);
    }
  }
}
