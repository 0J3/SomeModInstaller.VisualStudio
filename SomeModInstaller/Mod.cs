using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeModInstaller
{
  public class Mod
  {
    public string Filename = "";
    public string Displayname = "";
    public string Download = "";
    public bool DownloadMod = false;

    public Mod(dynamic Name, dynamic Display, dynamic Download)
    {
      this.Filename = Name;
      this.Displayname = Display;
      this.Download = Download;
    }
  }
}
