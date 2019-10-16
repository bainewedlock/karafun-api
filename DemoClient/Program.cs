using System;
using System.Windows.Forms;

namespace DemoClient
{
  static class Program
  {
    [STAThread]
    static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);

      try
      {
        Application.Run(new MainForm());

      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.ToString(), "Unbehandelte Ausnahme");
        Environment.Exit(2);
      }
    }
  }
}
