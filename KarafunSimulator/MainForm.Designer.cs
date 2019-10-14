namespace KarafunSimulator
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
      this.StartServerButton = new System.Windows.Forms.Button();
      this.ProtokollListBox = new System.Windows.Forms.ListBox();
      this.SimulateDelayCheckbox = new System.Windows.Forms.CheckBox();
      this.SuspendLayout();
      // 
      // StartServerButton
      // 
      this.StartServerButton.Location = new System.Drawing.Point(12, 12);
      this.StartServerButton.Name = "StartServerButton";
      this.StartServerButton.Size = new System.Drawing.Size(75, 23);
      this.StartServerButton.TabIndex = 0;
      this.StartServerButton.Text = "Start Server";
      this.StartServerButton.UseVisualStyleBackColor = true;
      this.StartServerButton.Click += new System.EventHandler(this.StartServerButton_Click);
      // 
      // ProtokollListBox
      // 
      this.ProtokollListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.ProtokollListBox.FormattingEnabled = true;
      this.ProtokollListBox.Location = new System.Drawing.Point(12, 41);
      this.ProtokollListBox.Name = "ProtokollListBox";
      this.ProtokollListBox.Size = new System.Drawing.Size(776, 394);
      this.ProtokollListBox.TabIndex = 1;
      // 
      // SimulateDelayCheckbox
      // 
      this.SimulateDelayCheckbox.AutoSize = true;
      this.SimulateDelayCheckbox.Checked = true;
      this.SimulateDelayCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
      this.SimulateDelayCheckbox.Location = new System.Drawing.Point(93, 16);
      this.SimulateDelayCheckbox.Name = "SimulateDelayCheckbox";
      this.SimulateDelayCheckbox.Size = new System.Drawing.Size(106, 17);
      this.SimulateDelayCheckbox.TabIndex = 2;
      this.SimulateDelayCheckbox.Text = "simulate 1s delay";
      this.SimulateDelayCheckbox.UseVisualStyleBackColor = true;
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.SimulateDelayCheckbox);
      this.Controls.Add(this.ProtokollListBox);
      this.Controls.Add(this.StartServerButton);
      this.Name = "MainForm";
      this.Text = "Karafun Simulator";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button StartServerButton;
    private System.Windows.Forms.ListBox ProtokollListBox;
    private System.Windows.Forms.CheckBox SimulateDelayCheckbox;
  }
}

