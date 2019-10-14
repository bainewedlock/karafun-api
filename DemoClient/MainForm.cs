using KarafunApi;
using System;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DemoClient
{
  public partial class MainForm : Form
  {

    public MainForm()
    {
      InitializeComponent();
    }

    async void GetStatusButton_Click(object sender, EventArgs e)
    {
      var request = new XElement("action");
      request.SetAttributeValue("type", "getStatus");
      RequestTextBox.Text = request.ToString();
      ResponseTextBox.Text = "waiting for response...";

      var response = await Karafun.SendAsync(request);
      ResponseTextBox.Text = response.ToString();
    }

    async void PlayButton_Click(object sender, EventArgs e)
    {
      var request = new XElement("action");
      request.SetAttributeValue("type", "play");
      RequestTextBox.Text = request.ToString();
      ResponseTextBox.Text = "waiting for response...";

      var response = await Karafun.SendAsync(request);
      ResponseTextBox.Text = response.ToString();
    }

    async void PauseButton_Click(object sender, EventArgs e)
    {
      var request = new XElement("action");
      request.SetAttributeValue("type", "pause");
      RequestTextBox.Text = request.ToString();
      ResponseTextBox.Text = "waiting for response...";

      var response = await Karafun.SendAsync(request);
      ResponseTextBox.Text = response.ToString();
    }
  }
}
