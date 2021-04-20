using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SomeModInstaller
{
  public partial class LocationSelect : Form
  {
    Mod[] modList;

    public LocationSelect(Mod[] modList)
    {
      this.modList = modList;
      InitializeComponent();
    }

    private void CloseButton_Click(object sender, EventArgs e)
    {
      Application.ExitThread();
    }

    private void Next()
    {
      string Path = SelectMods.SelectedPath;

      Installing installer = new Installing(Path,modList);

      this.Hide();
      installer.Show();
    }

    private void CustomLocation_Click(object sender, EventArgs e)
    {
      SelectMods.ShowDialog();
      Next();
    }

    private void bunifuFlatButton2_Click(object sender, EventArgs e)
    {
      Next();
    }
  }
}
