
namespace SomeModInstaller
{
  partial class LocationSelect
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.Title = new System.Windows.Forms.Label();
      this.CloseButton = new Bunifu.Framework.UI.BunifuFlatButton();
      this.SelectMods = new System.Windows.Forms.FolderBrowserDialog();
      this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
      this.CustomLocation = new Bunifu.Framework.UI.BunifuFlatButton();
      this.SuspendLayout();
      // 
      // Title
      // 
      this.Title.BackColor = System.Drawing.Color.Transparent;
      this.Title.Font = new System.Drawing.Font("Product Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Title.ForeColor = System.Drawing.Color.White;
      this.Title.Location = new System.Drawing.Point(12, 23);
      this.Title.Name = "Title";
      this.Title.Size = new System.Drawing.Size(278, 26);
      this.Title.TabIndex = 9;
      this.Title.Text = "0J3\'s Mod Installer";
      // 
      // CloseButton
      // 
      this.CloseButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      this.CloseButton.BackColor = System.Drawing.Color.Red;
      this.CloseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.CloseButton.BorderRadius = 0;
      this.CloseButton.ButtonText = "X";
      this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
      this.CloseButton.DisabledColor = System.Drawing.Color.Gray;
      this.CloseButton.Iconcolor = System.Drawing.Color.Transparent;
      this.CloseButton.Iconimage = null;
      this.CloseButton.Iconimage_right = null;
      this.CloseButton.Iconimage_right_Selected = null;
      this.CloseButton.Iconimage_Selected = null;
      this.CloseButton.IconMarginLeft = 0;
      this.CloseButton.IconMarginRight = 0;
      this.CloseButton.IconRightVisible = true;
      this.CloseButton.IconRightZoom = 0D;
      this.CloseButton.IconVisible = true;
      this.CloseButton.IconZoom = 90D;
      this.CloseButton.IsTab = false;
      this.CloseButton.Location = new System.Drawing.Point(736, 12);
      this.CloseButton.Name = "CloseButton";
      this.CloseButton.Normalcolor = System.Drawing.Color.Red;
      this.CloseButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      this.CloseButton.OnHoverTextColor = System.Drawing.Color.White;
      this.CloseButton.selected = false;
      this.CloseButton.Size = new System.Drawing.Size(52, 48);
      this.CloseButton.TabIndex = 8;
      this.CloseButton.Text = "X";
      this.CloseButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.CloseButton.Textcolor = System.Drawing.Color.White;
      this.CloseButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
      // 
      // SelectMods
      // 
      this.SelectMods.Description = "Select your mods folder";
      this.SelectMods.SelectedPath = "C:\\Users\\Lannan\\AppData\\Roaming\\.minecraft\\mods";
      // 
      // bunifuFlatButton2
      // 
      this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
      this.bunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
      this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.bunifuFlatButton2.BorderRadius = 0;
      this.bunifuFlatButton2.ButtonText = "Use Default Mods Folder";
      this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
      this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
      this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
      this.bunifuFlatButton2.Iconimage = null;
      this.bunifuFlatButton2.Iconimage_right = null;
      this.bunifuFlatButton2.Iconimage_right_Selected = null;
      this.bunifuFlatButton2.Iconimage_Selected = null;
      this.bunifuFlatButton2.IconMarginLeft = 0;
      this.bunifuFlatButton2.IconMarginRight = 0;
      this.bunifuFlatButton2.IconRightVisible = true;
      this.bunifuFlatButton2.IconRightZoom = 0D;
      this.bunifuFlatButton2.IconVisible = true;
      this.bunifuFlatButton2.IconZoom = 90D;
      this.bunifuFlatButton2.IsTab = false;
      this.bunifuFlatButton2.Location = new System.Drawing.Point(280, 326);
      this.bunifuFlatButton2.Name = "bunifuFlatButton2";
      this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
      this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
      this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
      this.bunifuFlatButton2.selected = false;
      this.bunifuFlatButton2.Size = new System.Drawing.Size(241, 48);
      this.bunifuFlatButton2.TabIndex = 13;
      this.bunifuFlatButton2.Text = "Use Default Mods Folder";
      this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
      this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.bunifuFlatButton2.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
      // 
      // CustomLocation
      // 
      this.CustomLocation.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
      this.CustomLocation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
      this.CustomLocation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.CustomLocation.BorderRadius = 0;
      this.CustomLocation.ButtonText = "Select Custom Mods Folder Location (Advanced)";
      this.CustomLocation.Cursor = System.Windows.Forms.Cursors.Hand;
      this.CustomLocation.DisabledColor = System.Drawing.Color.Gray;
      this.CustomLocation.Iconcolor = System.Drawing.Color.Transparent;
      this.CustomLocation.Iconimage = null;
      this.CustomLocation.Iconimage_right = null;
      this.CustomLocation.Iconimage_right_Selected = null;
      this.CustomLocation.Iconimage_Selected = null;
      this.CustomLocation.IconMarginLeft = 0;
      this.CustomLocation.IconMarginRight = 0;
      this.CustomLocation.IconRightVisible = true;
      this.CustomLocation.IconRightZoom = 0D;
      this.CustomLocation.IconVisible = true;
      this.CustomLocation.IconZoom = 90D;
      this.CustomLocation.IsTab = false;
      this.CustomLocation.Location = new System.Drawing.Point(280, 380);
      this.CustomLocation.Name = "CustomLocation";
      this.CustomLocation.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
      this.CustomLocation.OnHovercolor = System.Drawing.Color.Navy;
      this.CustomLocation.OnHoverTextColor = System.Drawing.Color.White;
      this.CustomLocation.selected = false;
      this.CustomLocation.Size = new System.Drawing.Size(241, 48);
      this.CustomLocation.TabIndex = 12;
      this.CustomLocation.Text = "Select Custom Mods Folder Location (Advanced)";
      this.CustomLocation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.CustomLocation.Textcolor = System.Drawing.Color.White;
      this.CustomLocation.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.CustomLocation.Click += new System.EventHandler(this.CustomLocation_Click);
      // 
      // LocationSelect
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Black;
      this.BackgroundImage = global::SomeModInstaller.Properties.Resources.AuroraBlur;
      this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.bunifuFlatButton2);
      this.Controls.Add(this.CustomLocation);
      this.Controls.Add(this.Title);
      this.Controls.Add(this.CloseButton);
      this.ForeColor = System.Drawing.Color.White;
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "LocationSelect";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Form1";
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Label Title;
    private Bunifu.Framework.UI.BunifuFlatButton CloseButton;
    private System.Windows.Forms.FolderBrowserDialog SelectMods;
    private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
    private Bunifu.Framework.UI.BunifuFlatButton CustomLocation;
  }
}