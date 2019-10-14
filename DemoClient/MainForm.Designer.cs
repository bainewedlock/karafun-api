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
      this.SuspendLayout();
      // 
      // GetStatusButton
      // 
      this.GetStatusButton.Location = new System.Drawing.Point(12, 12);
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
      this.RequestTextBox.Location = new System.Drawing.Point(12, 73);
      this.RequestTextBox.Multiline = true;
      this.RequestTextBox.Name = "RequestTextBox";
      this.RequestTextBox.Size = new System.Drawing.Size(239, 365);
      this.RequestTextBox.TabIndex = 1;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 57);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(47, 13);
      this.label1.TabIndex = 2;
      this.label1.Text = "Request";
      // 
      // ResponseTextBox
      // 
      this.ResponseTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.ResponseTextBox.Location = new System.Drawing.Point(257, 73);
      this.ResponseTextBox.Multiline = true;
      this.ResponseTextBox.Name = "ResponseTextBox";
      this.ResponseTextBox.Size = new System.Drawing.Size(531, 365);
      this.ResponseTextBox.TabIndex = 3;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(254, 57);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(55, 13);
      this.label2.TabIndex = 4;
      this.label2.Text = "Response";
      // 
      // PlayButton
      // 
      this.PlayButton.Location = new System.Drawing.Point(93, 12);
      this.PlayButton.Name = "PlayButton";
      this.PlayButton.Size = new System.Drawing.Size(75, 23);
      this.PlayButton.TabIndex = 5;
      this.PlayButton.Text = "play";
      this.PlayButton.UseVisualStyleBackColor = true;
      this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
      // 
      // PauseButton
      // 
      this.PauseButton.Location = new System.Drawing.Point(174, 12);
      this.PauseButton.Name = "PauseButton";
      this.PauseButton.Size = new System.Drawing.Size(75, 23);
      this.PauseButton.TabIndex = 6;
      this.PauseButton.Text = "pause";
      this.PauseButton.UseVisualStyleBackColor = true;
      this.PauseButton.Click += new System.EventHandler(this.PauseButton_Click);
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.PauseButton);
      this.Controls.Add(this.PlayButton);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.ResponseTextBox);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.RequestTextBox);
      this.Controls.Add(this.GetStatusButton);
      this.Name = "MainForm";
      this.Text = "Demo Client";
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
  }
}

