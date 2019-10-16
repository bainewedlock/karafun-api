namespace DemoClient
{
  partial class MainForm
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
      this.GetStatusButton = new System.Windows.Forms.Button();
      this.PlayButton = new System.Windows.Forms.Button();
      this.PauseButton = new System.Windows.Forms.Button();
      this.ConnectButton = new System.Windows.Forms.Button();
      this.ControlsPanel = new System.Windows.Forms.Panel();
      this.tabControl1 = new System.Windows.Forms.TabControl();
      this.tabPage1 = new System.Windows.Forms.TabPage();
      this.label5 = new System.Windows.Forms.Label();
      this.SongSuchenTextbox = new System.Windows.Forms.TextBox();
      this.SongSuchenButton = new System.Windows.Forms.Button();
      this.panel1 = new System.Windows.Forms.Panel();
      this.ArtistTextBox = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.TitleTextBox = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.tabPage2 = new System.Windows.Forms.TabPage();
      this.RequestTextBox = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.ResponseTextBox = new System.Windows.Forms.TextBox();
      this.SongListbox = new System.Windows.Forms.ListBox();
      this.SuchergebnisAbspielenButton = new System.Windows.Forms.Button();
      this.ControlsPanel.SuspendLayout();
      this.tabControl1.SuspendLayout();
      this.tabPage1.SuspendLayout();
      this.panel1.SuspendLayout();
      this.tabPage2.SuspendLayout();
      this.SuspendLayout();
      // 
      // GetStatusButton
      // 
      this.GetStatusButton.Location = new System.Drawing.Point(3, 3);
      this.GetStatusButton.Name = "GetStatusButton";
      this.GetStatusButton.Size = new System.Drawing.Size(75, 23);
      this.GetStatusButton.TabIndex = 0;
      this.GetStatusButton.Text = "getStatus";
      this.GetStatusButton.UseVisualStyleBackColor = true;
      this.GetStatusButton.Click += new System.EventHandler(this.GetStatusButton_Click);
      // 
      // PlayButton
      // 
      this.PlayButton.Location = new System.Drawing.Point(84, 3);
      this.PlayButton.Name = "PlayButton";
      this.PlayButton.Size = new System.Drawing.Size(75, 23);
      this.PlayButton.TabIndex = 5;
      this.PlayButton.Text = "play";
      this.PlayButton.UseVisualStyleBackColor = true;
      this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
      // 
      // PauseButton
      // 
      this.PauseButton.Location = new System.Drawing.Point(165, 3);
      this.PauseButton.Name = "PauseButton";
      this.PauseButton.Size = new System.Drawing.Size(75, 23);
      this.PauseButton.TabIndex = 6;
      this.PauseButton.Text = "pause";
      this.PauseButton.UseVisualStyleBackColor = true;
      this.PauseButton.Click += new System.EventHandler(this.PauseButton_Click);
      // 
      // ConnectButton
      // 
      this.ConnectButton.Location = new System.Drawing.Point(15, 15);
      this.ConnectButton.Name = "ConnectButton";
      this.ConnectButton.Size = new System.Drawing.Size(75, 23);
      this.ConnectButton.TabIndex = 7;
      this.ConnectButton.Text = "connect";
      this.ConnectButton.UseVisualStyleBackColor = true;
      this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
      // 
      // ControlsPanel
      // 
      this.ControlsPanel.Controls.Add(this.GetStatusButton);
      this.ControlsPanel.Controls.Add(this.PlayButton);
      this.ControlsPanel.Controls.Add(this.PauseButton);
      this.ControlsPanel.Location = new System.Drawing.Point(96, 12);
      this.ControlsPanel.Name = "ControlsPanel";
      this.ControlsPanel.Size = new System.Drawing.Size(392, 40);
      this.ControlsPanel.TabIndex = 8;
      // 
      // tabControl1
      // 
      this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tabControl1.Controls.Add(this.tabPage1);
      this.tabControl1.Controls.Add(this.tabPage2);
      this.tabControl1.Location = new System.Drawing.Point(12, 58);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new System.Drawing.Size(851, 551);
      this.tabControl1.TabIndex = 11;
      // 
      // tabPage1
      // 
      this.tabPage1.Controls.Add(this.SuchergebnisAbspielenButton);
      this.tabPage1.Controls.Add(this.SongListbox);
      this.tabPage1.Controls.Add(this.label5);
      this.tabPage1.Controls.Add(this.SongSuchenTextbox);
      this.tabPage1.Controls.Add(this.SongSuchenButton);
      this.tabPage1.Controls.Add(this.panel1);
      this.tabPage1.Location = new System.Drawing.Point(4, 22);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage1.Size = new System.Drawing.Size(843, 525);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "Playback";
      this.tabPage1.UseVisualStyleBackColor = true;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(9, 139);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(69, 13);
      this.label5.TabIndex = 4;
      this.label5.Text = "Song Suche:";
      // 
      // SongSuchenTextbox
      // 
      this.SongSuchenTextbox.Location = new System.Drawing.Point(90, 136);
      this.SongSuchenTextbox.Name = "SongSuchenTextbox";
      this.SongSuchenTextbox.Size = new System.Drawing.Size(351, 20);
      this.SongSuchenTextbox.TabIndex = 4;
      this.SongSuchenTextbox.TabStop = false;
      this.SongSuchenTextbox.Text = "Volbeat";
      // 
      // SongSuchenButton
      // 
      this.SongSuchenButton.Location = new System.Drawing.Point(447, 134);
      this.SongSuchenButton.Name = "SongSuchenButton";
      this.SongSuchenButton.Size = new System.Drawing.Size(75, 23);
      this.SongSuchenButton.TabIndex = 7;
      this.SongSuchenButton.Text = "suchen";
      this.SongSuchenButton.UseVisualStyleBackColor = true;
      this.SongSuchenButton.Click += new System.EventHandler(this.SongSuchenButton_Click);
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.ArtistTextBox);
      this.panel1.Controls.Add(this.label4);
      this.panel1.Controls.Add(this.TitleTextBox);
      this.panel1.Controls.Add(this.label3);
      this.panel1.Location = new System.Drawing.Point(6, 6);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(460, 84);
      this.panel1.TabIndex = 15;
      // 
      // ArtistTextBox
      // 
      this.ArtistTextBox.Location = new System.Drawing.Point(84, 38);
      this.ArtistTextBox.Name = "ArtistTextBox";
      this.ArtistTextBox.ReadOnly = true;
      this.ArtistTextBox.Size = new System.Drawing.Size(351, 20);
      this.ArtistTextBox.TabIndex = 3;
      this.ArtistTextBox.TabStop = false;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(3, 41);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(33, 13);
      this.label4.TabIndex = 2;
      this.label4.Text = "Artist:";
      // 
      // TitleTextBox
      // 
      this.TitleTextBox.Location = new System.Drawing.Point(84, 12);
      this.TitleTextBox.Name = "TitleTextBox";
      this.TitleTextBox.ReadOnly = true;
      this.TitleTextBox.Size = new System.Drawing.Size(351, 20);
      this.TitleTextBox.TabIndex = 1;
      this.TitleTextBox.TabStop = false;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(3, 15);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(30, 13);
      this.label3.TabIndex = 0;
      this.label3.Text = "Title:";
      // 
      // tabPage2
      // 
      this.tabPage2.Controls.Add(this.RequestTextBox);
      this.tabPage2.Controls.Add(this.label2);
      this.tabPage2.Controls.Add(this.label1);
      this.tabPage2.Controls.Add(this.ResponseTextBox);
      this.tabPage2.Location = new System.Drawing.Point(4, 22);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage2.Size = new System.Drawing.Size(843, 525);
      this.tabPage2.TabIndex = 1;
      this.tabPage2.Text = "Debug";
      this.tabPage2.UseVisualStyleBackColor = true;
      // 
      // RequestTextBox
      // 
      this.RequestTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
      this.RequestTextBox.Location = new System.Drawing.Point(9, 19);
      this.RequestTextBox.Multiline = true;
      this.RequestTextBox.Name = "RequestTextBox";
      this.RequestTextBox.Size = new System.Drawing.Size(239, 500);
      this.RequestTextBox.TabIndex = 10;
      this.RequestTextBox.TabStop = false;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(255, 3);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(119, 13);
      this.label2.TabIndex = 13;
      this.label2.Text = "Last Incoming Message";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(6, 3);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(70, 13);
      this.label1.TabIndex = 11;
      this.label1.Text = "Last Request";
      // 
      // ResponseTextBox
      // 
      this.ResponseTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.ResponseTextBox.Location = new System.Drawing.Point(254, 19);
      this.ResponseTextBox.Multiline = true;
      this.ResponseTextBox.Name = "ResponseTextBox";
      this.ResponseTextBox.Size = new System.Drawing.Size(583, 500);
      this.ResponseTextBox.TabIndex = 12;
      this.ResponseTextBox.TabStop = false;
      // 
      // SongListbox
      // 
      this.SongListbox.FormattingEnabled = true;
      this.SongListbox.Location = new System.Drawing.Point(90, 174);
      this.SongListbox.Name = "SongListbox";
      this.SongListbox.ScrollAlwaysVisible = true;
      this.SongListbox.Size = new System.Drawing.Size(351, 95);
      this.SongListbox.TabIndex = 16;
      this.SongListbox.SelectedValueChanged += new System.EventHandler(this.SongListbox_SelectedValueChanged);
      // 
      // SuchergebnisAbspielenButton
      // 
      this.SuchergebnisAbspielenButton.Location = new System.Drawing.Point(447, 174);
      this.SuchergebnisAbspielenButton.Name = "SuchergebnisAbspielenButton";
      this.SuchergebnisAbspielenButton.Size = new System.Drawing.Size(75, 23);
      this.SuchergebnisAbspielenButton.TabIndex = 17;
      this.SuchergebnisAbspielenButton.Text = "abspielen";
      this.SuchergebnisAbspielenButton.UseVisualStyleBackColor = true;
      this.SuchergebnisAbspielenButton.Click += new System.EventHandler(this.SuchergebnisAbspielenButton_Click);
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(877, 621);
      this.Controls.Add(this.tabControl1);
      this.Controls.Add(this.ControlsPanel);
      this.Controls.Add(this.ConnectButton);
      this.Name = "MainForm";
      this.Text = "Demo Client";
      this.ControlsPanel.ResumeLayout(false);
      this.tabControl1.ResumeLayout(false);
      this.tabPage1.ResumeLayout(false);
      this.tabPage1.PerformLayout();
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.tabPage2.ResumeLayout(false);
      this.tabPage2.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button GetStatusButton;
    private System.Windows.Forms.Button PlayButton;
    private System.Windows.Forms.Button PauseButton;
    private System.Windows.Forms.Button ConnectButton;
    private System.Windows.Forms.Panel ControlsPanel;
    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tabPage1;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.TextBox ArtistTextBox;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox TitleTextBox;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TabPage tabPage2;
    private System.Windows.Forms.TextBox RequestTextBox;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox ResponseTextBox;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox SongSuchenTextbox;
    private System.Windows.Forms.Button SongSuchenButton;
    private System.Windows.Forms.ListBox SongListbox;
    private System.Windows.Forms.Button SuchergebnisAbspielenButton;
  }
}

