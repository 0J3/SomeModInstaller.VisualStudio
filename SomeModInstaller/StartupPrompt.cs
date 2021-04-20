using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


namespace SomeModInstaller
{
  public partial class StartupPrompt : Form
  {
    public StartupPrompt()
    {
      InitializeComponent();
    }

    private void CloseButton_Click(object sender, EventArgs e)
    {
      Application.ExitThread();
    }


    private async void StartupPrompt_Load(object sender, EventArgs e)
    {
      HttpClient client = new HttpClient();
      string url = "https://0j3.github.io/SomeModInstaller/mods.json";
      HttpResponseMessage response = await client.GetAsync(url);
      string download = await response.Content.ReadAsStringAsync();
      dynamic content = JsonConvert.DeserializeObject(download);

      int ii = 0;

      foreach (dynamic val in content)
      {
        ii++;
      }

      Mod[] mods = new Mod[ii];

      int i = 0;

      foreach (dynamic val in content)
      {
        Mod mod = new Mod(val.name, val.displayName, val.url);
        System.Console.WriteLine($"{val.name}, {val.displayName}, {val.url}");
        mods[i] = mod;
        i++;
      }

      ModPrompt mpr = new ModPrompt(mods, 0);
      this.Hide();
      mpr.Show();
    }
  }
}
