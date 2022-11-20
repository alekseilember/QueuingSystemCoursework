using System.Windows.Forms;

namespace QueuingSystemCoursework
{
  partial class ChooseModeForm
  {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.step = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.automatic = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // step
      // 
      this.step.Font = new System.Drawing.Font("Times New Roman", 14.25F);
      this.step.Location = new System.Drawing.Point(12, 61);
      this.step.Name = "step";
      this.step.Size = new System.Drawing.Size(87, 46);
      this.step.TabIndex = 0;
      this.step.Text = "Step";
      this.step.UseVisualStyleBackColor = true;
      this.step.Click += new System.EventHandler(this.step_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold);
      this.label1.Location = new System.Drawing.Point(34, 14);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(170, 31);
      this.label1.TabIndex = 1;
      this.label1.Text = "Choose mode";
      // 
      // automatic
      // 
      this.automatic.Font = new System.Drawing.Font("Times New Roman", 14.25F);
      this.automatic.Location = new System.Drawing.Point(124, 61);
      this.automatic.Name = "automatic";
      this.automatic.Size = new System.Drawing.Size(102, 46);
      this.automatic.TabIndex = 2;
      this.automatic.Text = "Automatic";
      this.automatic.UseVisualStyleBackColor = true;
      this.automatic.Click += new System.EventHandler(this.automatic_Click);
      // 
      // ChooseModeForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(238, 122);
      this.Controls.Add(this.automatic);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.step);
      this.Name = "ChooseModeForm";
      this.Text = "Simulation";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private Button step;
    private Label label1;
    private Button automatic;
    }
}