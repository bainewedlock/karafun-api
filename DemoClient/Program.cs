using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoClient
{
  static class Program
  {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
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
