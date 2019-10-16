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
      this.RequestTextBox = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.ResponseTextBox = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.PlayButton = new System.Windows.Forms.Button();
      this.PauseButton = new System.Windows.Forms.Button();
      this.ConnectButton = new System.Windows.Forms.Button();
      this.ControlsPanel = new System.Windows.Forms.Panel();
      this.panel1 = new System.Windows.Forms.Panel();
      this.label3 = new System.Windows.Forms.Label();
      this.TitleTextBox = new System.Windows.Forms.TextBox();
      this.ArtistTextBox = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.ControlsPanel.SuspendLayout();
      this.panel1.SuspendLayout();
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
      // RequestTextBox
      // 
      this.RequestTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
      this.RequestTextBox.Location = new System.Drawing.Point(12, 301);
      this.RequestTextBox.Multiline = true;
      this.RequestTextBox.Name = "RequestTextBox";
      this.RequestTextBox.Size = new System.Drawing.Size(239, 308);
      this.RequestTextBox.TabIndex = 1;
      this.RequestTextBox.TabStop = false;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(9, 285);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(70, 13);
      this.label1.TabIndex = 2;
      this.label1.Text = "Last Request";
      // 
      // ResponseTextBox
      // 
      this.ResponseTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.ResponseTextBox.Location = new System.Drawing.Point(257, 301);
      this.ResponseTextBox.Multiline = true;
      this.ResponseTextBox.Name = "ResponseTextBox";
      this.ResponseTextBox.Size = new System.Drawing.Size(531, 308);
      this.ResponseTextBox.TabIndex = 3;
      this.ResponseTextBox.TabStop = false;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(258, 285);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(119, 13);
      this.label2.TabIndex = 4;
      this.label2.Text = "Last Incoming Message";
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
      // panel1
      // 
      this.panel1.Controls.Add(this.ArtistTextBox);
      this.panel1.Controls.Add(this.label4);
      this.panel1.Controls.Add(this.TitleTextBox);
      this.panel1.Controls.Add(this.label3);
      this.panel1.Location = new System.Drawing.Point(12, 58);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(460, 198);
      this.panel1.TabIndex = 9;
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
      // TitleTextBox
      // 
      this.TitleTextBox.Location = new System.Drawing.Point(84, 12);
      this.TitleTextBox.Name = "TitleTextBox";
      this.TitleTextBox.ReadOnly = true;
      this.TitleTextBox.Size = new System.Drawing.Size(351, 20);
      this.TitleTextBox.TabIndex = 1;
      this.TitleTextBox.TabStop = false;
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
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 621);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.ControlsPanel);
      this.Controls.Add(this.ConnectButton);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.ResponseTextBox);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.RequestTextBox);
      this.Name = "MainForm";
      this.Text = "Demo Client";
      this.ControlsPanel.ResumeLayout(false);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button GetStatusButton;
    private System.Windows.Forms.TextBox RequestTextBox;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox ResponseTextBox;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button PlayButton;
    private System.Windows.Forms.Button PauseButton;
    private System.Windows.Forms.Button ConnectButton;
    private System.Windows.Forms.Panel ControlsPanel;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.TextBox ArtistTextBox;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox TitleTextBox;
    private System.Windows.Forms.Label label3;
  }
}

