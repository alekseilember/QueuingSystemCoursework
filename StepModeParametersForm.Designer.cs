using System.Windows.Forms;

namespace QueuingSystem
{
  partial class StepModeParametersForm
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
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
      this.textBox2 = new System.Windows.Forms.TextBox();
      this.textBox3 = new System.Windows.Forms.TextBox();
      this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
      this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
      this.label7 = new System.Windows.Forms.Label();
      this.button1 = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F);
      this.label1.Location = new System.Drawing.Point(11, 66);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(315, 21);
      this.label1.TabIndex = 0;
      this.label1.Text = "Average amount of requests per time unit";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F);
      this.label2.Location = new System.Drawing.Point(11, 107);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(378, 21);
      this.label2.TabIndex = 1;
      this.label2.Text = "Minimum amount of time needed to serve request";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F);
      this.label3.Location = new System.Drawing.Point(11, 153);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(382, 21);
      this.label3.TabIndex = 2;
      this.label3.Text = "Maximum amount of time needed to serve request";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F);
      this.label4.Location = new System.Drawing.Point(11, 197);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(106, 21);
      this.label4.TabIndex = 3;
      this.label4.Text = "Buffer length";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F);
      this.label5.Location = new System.Drawing.Point(11, 239);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(152, 21);
      this.label5.TabIndex = 4;
      this.label5.Text = "Amount of devices";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F);
      this.label6.Location = new System.Drawing.Point(11, 285);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(158, 21);
      this.label6.TabIndex = 5;
      this.label6.Text = "Amount of requests";
      // 
      // textBox1
      // 
      this.textBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F);
      this.textBox1.Location = new System.Drawing.Point(332, 63);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(258, 29);
      this.textBox1.TabIndex = 6;
      // 
      // numericUpDown1
      // 
      this.numericUpDown1.Font = new System.Drawing.Font("Times New Roman", 14.25F);
      this.numericUpDown1.Location = new System.Drawing.Point(123, 195);
      this.numericUpDown1.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
      this.numericUpDown1.Name = "numericUpDown1";
      this.numericUpDown1.Size = new System.Drawing.Size(103, 29);
      this.numericUpDown1.TabIndex = 9;
      this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      // 
      // textBox2
      // 
      this.textBox2.Font = new System.Drawing.Font("Times New Roman", 14.25F);
      this.textBox2.Location = new System.Drawing.Point(395, 104);
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new System.Drawing.Size(258, 29);
      this.textBox2.TabIndex = 10;
      // 
      // textBox3
      // 
      this.textBox3.Font = new System.Drawing.Font("Times New Roman", 14.25F);
      this.textBox3.Location = new System.Drawing.Point(399, 150);
      this.textBox3.Name = "textBox3";
      this.textBox3.Size = new System.Drawing.Size(258, 29);
      this.textBox3.TabIndex = 11;
      // 
      // numericUpDown2
      // 
      this.numericUpDown2.Font = new System.Drawing.Font("Times New Roman", 14.25F);
      this.numericUpDown2.Location = new System.Drawing.Point(169, 237);
      this.numericUpDown2.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
      this.numericUpDown2.Name = "numericUpDown2";
      this.numericUpDown2.Size = new System.Drawing.Size(103, 29);
      this.numericUpDown2.TabIndex = 12;
      this.numericUpDown2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      // 
      // numericUpDown3
      // 
      this.numericUpDown3.Font = new System.Drawing.Font("Times New Roman", 14.25F);
      this.numericUpDown3.Location = new System.Drawing.Point(175, 283);
      this.numericUpDown3.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
      this.numericUpDown3.Name = "numericUpDown3";
      this.numericUpDown3.Size = new System.Drawing.Size(103, 29);
      this.numericUpDown3.TabIndex = 13;
      this.numericUpDown3.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold);
      this.label7.Location = new System.Drawing.Point(152, 17);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(351, 31);
      this.label7.TabIndex = 14;
      this.label7.Text = "Enter simulation parameters";
      // 
      // button1
      // 
      this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F);
      this.button1.Location = new System.Drawing.Point(264, 331);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(129, 43);
      this.button1.TabIndex = 15;
      this.button1.Text = "Simulate";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // StepModeParametersForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(673, 386);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.numericUpDown3);
      this.Controls.Add(this.numericUpDown2);
      this.Controls.Add(this.textBox3);
      this.Controls.Add(this.textBox2);
      this.Controls.Add(this.numericUpDown1);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Name = "StepModeParametersForm";
      this.Text = "Parameters";
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private Label label1;
    private Label label2;
    private Label label3;
    private Label label4;
    private Label label5;
    private Label label6;
    private TextBox textBox1;
    private NumericUpDown numericUpDown1;
    private TextBox textBox2;
    private TextBox textBox3;
    private NumericUpDown numericUpDown2;
    private NumericUpDown numericUpDown3;
    private Label label7;
    private Button button1;
  }
}