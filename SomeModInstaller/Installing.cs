using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading.Tasks;


namespace SomeModInstaller
{
  public partial class Installing : Form
  {
    private string Path;

    private Mod[] modList;

    private WebClient client = new WebClient();

    public Installing(string Path, Mod[] modList)
    {
      this.Path = Path;
      this.modList = modList;
      InitializeComponent();
    }

    private void Download(Mod mod)
    {
      client.DownloadFile(mod.Download, $"{Path}\\{mod.Filename}");
    }

    private void Installing_Load(object sender, EventArgs e)
    {
      timer1.Stop();
      foreach (Mod mod in modList)
      {
        if (mod.DownloadMod)
        {
          Download(mod);
        }
      }
      timer1.Start();
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
      Application.Exit();
    }
  }
}
