
namespace SomeModInstaller
{
  partial class StartupPrompt
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
      this.Title = new System.Windows.Forms.Label();
      this.CloseButton = new Bunifu.Framework.UI.BunifuFlatButton();
      this.LoadingText = new System.Windows.Forms.Label();
      this.WindowDrag = new Bunifu.Framework.UI.BunifuDragControl(this.components);
      this.loadingTextDrag = new Bunifu.Framework.UI.BunifuDragControl(this.components);
      this.TitleTextDrag = new Bunifu.Framework.UI.BunifuDragControl(this.components);
      this.HTTPUtils = new Bunifu.Framework.UI.BunifuHTTP_Utils(this.components);
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
      this.Title.TabIndex = 7;
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
      this.CloseButton.TabIndex = 6;
      this.CloseButton.Text = "X";
      this.CloseButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.CloseButton.Textcolor = System.Drawing.Color.White;
      this.CloseButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
      // 
      // LoadingText
      // 
      this.LoadingText.BackColor = System.Drawing.Color.Transparent;
      this.LoadingText.Font = new System.Drawing.Font("Product Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.LoadingText.ForeColor = System.Drawing.Color.White;
      this.LoadingText.Location = new System.Drawing.Point(351, 216);
      this.LoadingText.Name = "LoadingText";
      this.LoadingText.Size = new System.Drawing.Size(105, 26);
      this.LoadingText.TabIndex = 8;
      this.LoadingText.Text = "Loading...";
      // 
      // WindowDrag
      // 
      this.WindowDrag.Fixed = true;
      this.WindowDrag.Horizontal = true;
      this.WindowDrag.TargetControl = this;
      this.WindowDrag.Vertical = true;
      // 
      // loadingTextDrag
      // 
      this.loadingTextDrag.Fixed = true;
      this.loadingTextDrag.Horizontal = true;
      this.loadingTextDrag.TargetControl = this.LoadingText;
      this.loadingTextDrag.Vertical = true;
      // 
      // TitleTextDrag
      // 
      this.TitleTextDrag.Fixed = true;
      this.TitleTextDrag.Horizontal = true;
      this.TitleTextDrag.TargetControl = this.Title;
      this.TitleTextDrag.Vertical = true;
      // 
      // HTTPUtils
      // 
      this.HTTPUtils.JobName = "";
      this.HTTPUtils.Url = "";
      // 
      // StartupPrompt
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackgroundImage = global::SomeModInstaller.Properties.Resources.AuroraBlur;
      this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.LoadingText);
      this.Controls.Add(this.Title);
      this.Controls.Add(this.CloseButton);
      this.Cursor = System.Windows.Forms.Cursors.AppStarting;
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "StartupPrompt";
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Starting ModInstaller...";
      this.Load += new System.EventHandler(this.StartupPrompt_Load);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Label Title;
    private Bunifu.Framework.UI.BunifuFlatButton CloseButton;
    private System.Windows.Forms.Label LoadingText;
    private Bunifu.Framework.UI.BunifuDragControl WindowDrag;
    private Bunifu.Framework.UI.BunifuDragControl loadingTextDrag;
    private Bunifu.Framework.UI.BunifuDragControl TitleTextDrag;
    private Bunifu.Framework.UI.BunifuHTTP_Utils HTTPUtils;
  }
}