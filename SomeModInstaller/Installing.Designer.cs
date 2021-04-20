
namespace SomeModInstaller
{
  partial class Installing
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
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
      this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
      this.bunifuDragControl3 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
      this.bunifuDragControl4 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
      this.timer1 = new System.Windows.Forms.Timer(this.components);
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
      this.Title.TabIndex = 11;
      this.Title.Text = "0J3\'s Mod Installer";
      // 
      // label1
      // 
      this.label1.BackColor = System.Drawing.Color.Transparent;
      this.label1.Font = new System.Drawing.Font("Product Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.ForeColor = System.Drawing.Color.White;
      this.label1.Location = new System.Drawing.Point(213, 212);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(375, 26);
      this.label1.TabIndex = 13;
      this.label1.Text = "Installing Mods...";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // label2
      // 
      this.label2.BackColor = System.Drawing.Color.Transparent;
      this.label2.Font = new System.Drawing.Font("Product Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.ForeColor = System.Drawing.Color.White;
      this.label2.Location = new System.Drawing.Point(130, 415);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(527, 26);
      this.label2.TabIndex = 14;
      this.label2.Text = "The Installer will automatically close after it\'s finished.";
      this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // bunifuDragControl1
      // 
      this.bunifuDragControl1.Fixed = true;
      this.bunifuDragControl1.Horizontal = true;
      this.bunifuDragControl1.TargetControl = this;
      this.bunifuDragControl1.Vertical = true;
      // 
      // bunifuDragControl2
      // 
      this.bunifuDragControl2.Fixed = true;
      this.bunifuDragControl2.Horizontal = true;
      this.bunifuDragControl2.TargetControl = this.label1;
      this.bunifuDragControl2.Vertical = true;
      // 
      // bunifuDragControl3
      // 
      this.bunifuDragControl3.Fixed = true;
      this.bunifuDragControl3.Horizontal = true;
      this.bunifuDragControl3.TargetControl = this.label2;
      this.bunifuDragControl3.Vertical = true;
      // 
      // bunifuDragControl4
      // 
      this.bunifuDragControl4.Fixed = true;
      this.bunifuDragControl4.Horizontal = true;
      this.bunifuDragControl4.TargetControl = this.Title;
      this.bunifuDragControl4.Vertical = true;
      // 
      // timer1
      // 
      this.timer1.Interval = 1250;
      this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
      // 
      // Installing
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Black;
      this.BackgroundImage = global::SomeModInstaller.Properties.Resources.aurora;
      this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.Title);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "Installing";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Installing";
      this.Load += new System.EventHandler(this.Installing_Load);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Label Title;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
    private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl3;
    private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl4;
    private System.Windows.Forms.Timer timer1;
  }
}