
namespace SomeModInstaller
{
  partial class ModPrompt
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
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModPrompt));
      this.ModInstallQuestionText = new System.Windows.Forms.Label();
      this.DownloadMod = new Bunifu.Framework.UI.BunifuFlatButton();
      this.DownloadManually = new Bunifu.Framework.UI.BunifuFlatButton();
      this.SkipMod = new Bunifu.Framework.UI.BunifuFlatButton();
      this.Drag = new Bunifu.Framework.UI.BunifuDragControl(this.components);
      this.TextDrag = new Bunifu.Framework.UI.BunifuDragControl(this.components);
      this.CloseButton = new Bunifu.Framework.UI.BunifuFlatButton();
      this.Title = new System.Windows.Forms.Label();
      this.TitleDrag = new Bunifu.Framework.UI.BunifuDragControl(this.components);
      this.SuspendLayout();
      // 
      // ModInstallQuestionText
      // 
      this.ModInstallQuestionText.BackColor = System.Drawing.Color.Transparent;
      this.ModInstallQuestionText.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.ModInstallQuestionText.ForeColor = System.Drawing.Color.White;
      this.ModInstallQuestionText.Location = new System.Drawing.Point(-2, 176);
      this.ModInstallQuestionText.Name = "ModInstallQuestionText";
      this.ModInstallQuestionText.Size = new System.Drawing.Size(803, 26);
      this.ModInstallQuestionText.TabIndex = 0;
      this.ModInstallQuestionText.Text = "Do you wish to install OriginsMod?";
      this.ModInstallQuestionText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // DownloadMod
      // 
      this.DownloadMod.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
      this.DownloadMod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
      this.DownloadMod.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.DownloadMod.BorderRadius = 0;
      this.DownloadMod.ButtonText = "Yes";
      this.DownloadMod.Cursor = System.Windows.Forms.Cursors.Hand;
      this.DownloadMod.DisabledColor = System.Drawing.Color.Gray;
      this.DownloadMod.Iconcolor = System.Drawing.Color.Transparent;
      this.DownloadMod.Iconimage = null;
      this.DownloadMod.Iconimage_right = null;
      this.DownloadMod.Iconimage_right_Selected = null;
      this.DownloadMod.Iconimage_Selected = null;
      this.DownloadMod.IconMarginLeft = 0;
      this.DownloadMod.IconMarginRight = 0;
      this.DownloadMod.IconRightVisible = true;
      this.DownloadMod.IconRightZoom = 0D;
      this.DownloadMod.IconVisible = true;
      this.DownloadMod.IconZoom = 90D;
      this.DownloadMod.IsTab = false;
      this.DownloadMod.Location = new System.Drawing.Point(72, 328);
      this.DownloadMod.Name = "DownloadMod";
      this.DownloadMod.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
      this.DownloadMod.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
      this.DownloadMod.OnHoverTextColor = System.Drawing.Color.White;
      this.DownloadMod.selected = false;
      this.DownloadMod.Size = new System.Drawing.Size(185, 48);
      this.DownloadMod.TabIndex = 1;
      this.DownloadMod.Text = "Yes";
      this.DownloadMod.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.DownloadMod.Textcolor = System.Drawing.Color.White;
      this.DownloadMod.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.DownloadMod.Click += new System.EventHandler(this.DownloadMod_Click);
      // 
      // DownloadManually
      // 
      this.DownloadManually.Activecolor = System.Drawing.Color.Blue;
      this.DownloadManually.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
      this.DownloadManually.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.DownloadManually.BorderRadius = 0;
      this.DownloadManually.ButtonText = "Download Manually";
      this.DownloadManually.Cursor = System.Windows.Forms.Cursors.Hand;
      this.DownloadManually.DisabledColor = System.Drawing.Color.Gray;
      this.DownloadManually.ForeColor = System.Drawing.SystemColors.Control;
      this.DownloadManually.Iconcolor = System.Drawing.Color.Transparent;
      this.DownloadManually.Iconimage = null;
      this.DownloadManually.Iconimage_right = null;
      this.DownloadManually.Iconimage_right_Selected = null;
      this.DownloadManually.Iconimage_Selected = null;
      this.DownloadManually.IconMarginLeft = 0;
      this.DownloadManually.IconMarginRight = 0;
      this.DownloadManually.IconRightVisible = true;
      this.DownloadManually.IconRightZoom = 0D;
      this.DownloadManually.IconVisible = true;
      this.DownloadManually.IconZoom = 90D;
      this.DownloadManually.ImeMode = System.Windows.Forms.ImeMode.On;
      this.DownloadManually.IsTab = false;
      this.DownloadManually.Location = new System.Drawing.Point(281, 328);
      this.DownloadManually.Name = "DownloadManually";
      this.DownloadManually.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
      this.DownloadManually.OnHovercolor = System.Drawing.Color.Navy;
      this.DownloadManually.OnHoverTextColor = System.Drawing.Color.White;
      this.DownloadManually.selected = false;
      this.DownloadManually.Size = new System.Drawing.Size(241, 48);
      this.DownloadManually.TabIndex = 2;
      this.DownloadManually.Text = "Download Manually";
      this.DownloadManually.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.DownloadManually.Textcolor = System.Drawing.Color.White;
      this.DownloadManually.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.DownloadManually.Click += new System.EventHandler(this.DownloadManually_Click);
      // 
      // SkipMod
      // 
      this.SkipMod.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      this.SkipMod.BackColor = System.Drawing.Color.Red;
      this.SkipMod.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.SkipMod.BorderRadius = 0;
      this.SkipMod.ButtonText = "No";
      this.SkipMod.Cursor = System.Windows.Forms.Cursors.Hand;
      this.SkipMod.DisabledColor = System.Drawing.Color.Gray;
      this.SkipMod.Iconcolor = System.Drawing.Color.Transparent;
      this.SkipMod.Iconimage = null;
      this.SkipMod.Iconimage_right = null;
      this.SkipMod.Iconimage_right_Selected = null;
      this.SkipMod.Iconimage_Selected = null;
      this.SkipMod.IconMarginLeft = 0;
      this.SkipMod.IconMarginRight = 0;
      this.SkipMod.IconRightVisible = true;
      this.SkipMod.IconRightZoom = 0D;
      this.SkipMod.IconVisible = true;
      this.SkipMod.IconZoom = 90D;
      this.SkipMod.IsTab = false;
      this.SkipMod.Location = new System.Drawing.Point(545, 328);
      this.SkipMod.Name = "SkipMod";
      this.SkipMod.Normalcolor = System.Drawing.Color.Red;
      this.SkipMod.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.SkipMod.OnHoverTextColor = System.Drawing.Color.White;
      this.SkipMod.selected = false;
      this.SkipMod.Size = new System.Drawing.Size(185, 48);
      this.SkipMod.TabIndex = 3;
      this.SkipMod.Text = "No";
      this.SkipMod.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.SkipMod.Textcolor = System.Drawing.Color.White;
      this.SkipMod.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.SkipMod.Click += new System.EventHandler(this.SkipMod_Click);
      // 
      // Drag
      // 
      this.Drag.Fixed = true;
      this.Drag.Horizontal = true;
      this.Drag.TargetControl = this;
      this.Drag.Vertical = true;
      // 
      // TextDrag
      // 
      this.TextDrag.Fixed = true;
      this.TextDrag.Horizontal = true;
      this.TextDrag.TargetControl = this.ModInstallQuestionText;
      this.TextDrag.Vertical = true;
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
      this.CloseButton.TabIndex = 4;
      this.CloseButton.Text = "X";
      this.CloseButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.CloseButton.Textcolor = System.Drawing.Color.White;
      this.CloseButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
      // 
      // Title
      // 
      this.Title.BackColor = System.Drawing.Color.Transparent;
      this.Title.Font = new System.Drawing.Font("Product Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Title.ForeColor = System.Drawing.Color.White;
      this.Title.Location = new System.Drawing.Point(12, 22);
      this.Title.Name = "Title";
      this.Title.Size = new System.Drawing.Size(278, 26);
      this.Title.TabIndex = 5;
      this.Title.Text = "0J3\'s Mod Installer";
      // 
      // TitleDrag
      // 
      this.TitleDrag.Fixed = true;
      this.TitleDrag.Horizontal = true;
      this.TitleDrag.TargetControl = this.Title;
      this.TitleDrag.Vertical = true;
      // 
      // ModPrompt
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(43)))), ((int)(((byte)(44)))));
      this.BackgroundImage = global::SomeModInstaller.Properties.Resources.AuroraBlur;
      this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.Title);
      this.Controls.Add(this.CloseButton);
      this.Controls.Add(this.SkipMod);
      this.Controls.Add(this.DownloadManually);
      this.Controls.Add(this.DownloadMod);
      this.Controls.Add(this.ModInstallQuestionText);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "ModPrompt";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "0J3\'s Mod Installer";
      this.Load += new System.EventHandler(this.ModPrompt_Load);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Label ModInstallQuestionText;
    private Bunifu.Framework.UI.BunifuFlatButton DownloadMod;
    private Bunifu.Framework.UI.BunifuFlatButton DownloadManually;
    private Bunifu.Framework.UI.BunifuFlatButton SkipMod;
    private Bunifu.Framework.UI.BunifuDragControl Drag;
    private Bunifu.Framework.UI.BunifuDragControl TextDrag;
    private Bunifu.Framework.UI.BunifuFlatButton CloseButton;
    private System.Windows.Forms.Label Title;
    private Bunifu.Framework.UI.BunifuDragControl TitleDrag;
  }
}

