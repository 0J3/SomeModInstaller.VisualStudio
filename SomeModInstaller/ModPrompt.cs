using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SomeModInstaller
{
  public partial class ModPrompt : Form
  {
    private Mod thisMod;
    private Mod[] modList;
    private int modPos;

    public ModPrompt(Mod[] modList, int modPos)
    {
      Mod mod = modList[modPos];
      this.modList = modList;
      this.modPos = modPos;
      this.thisMod = mod;
      InitializeComponent();
      ModInstallQuestionText.Text = $"Do you wish to install {this.thisMod.Displayname}?";
    }

    private void Next()
    {
      int ii = 0;

      foreach (dynamic val in modList)
      {
        ii++;
      }

      if (modPos != ii-1)
      {
        ModPrompt nextPrompt = new ModPrompt(this.modList, this.modPos + 1);

        this.Hide();
        nextPrompt.Show();
      } else
      {
        LocationSelect nextPrompt = new LocationSelect(this.modList);

        this.Hide();
        nextPrompt.Show();
      }
    }

    private void DownloadManually_Click(object sender, EventArgs e)
    {
      Process.Start(this.thisMod.Download);
    }

    private void CloseButton_Click(object sender, EventArgs e)
    {
      Application.ExitThread();
    }

    private void ModPrompt_Load(object sender, EventArgs e)
    {

    }
    
    private void DownloadMod_Click(object sender, EventArgs e)
    {
      this.thisMod.DownloadMod = true;
      this.modList[this.modPos].DownloadMod = true; // just incase
      this.Next();
    }

    private void SkipMod_Click(object sender, EventArgs e)
    {
      this.thisMod.DownloadMod = false;
      this.modList[this.modPos].DownloadMod = false; // just incase
      this.Next();
    }
  }
}
