using System.Windows.Forms;

namespace QueuingSystemCoursework
{
  partial class AutomaticModeParametersForm
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
      this.label6 = new System.Windows.Forms.Label();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
      this.textBox2 = new System.Windows.Forms.TextBox();
      this.textBox3 = new System.Windows.Forms.TextBox();
      this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
      this.label7 = new System.Windows.Forms.Label();
      this.button1 = new System.Windows.Forms.Button();
      this.textBox4 = new System.Windows.Forms.TextBox();
      this.label8 = new System.Windows.Forms.Label();
      this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
      this.label9 = new System.Windows.Forms.Label();
      this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
      this.label10 = new System.Windows.Forms.Label();
      this.numericUpDown7 = new System.Windows.Forms.NumericUpDown();
      this.label12 = new System.Windows.Forms.Label();
      this.numericUpDown8 = new System.Windows.Forms.NumericUpDown();
      this.label13 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.label11 = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown7)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown8)).BeginInit();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F);
      this.label1.Location = new System.Drawing.Point(15, 111);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(386, 21);
      this.label1.TabIndex = 0;
      this.label1.Text = "Minimum average amount of requests per time unit";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F);
      this.label2.Location = new System.Drawing.Point(15, 477);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(378, 21);
      this.label2.TabIndex = 1;
      this.label2.Text = "Minimum amount of time needed to serve request";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F);
      this.label3.Location = new System.Drawing.Point(15, 523);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(382, 21);
      this.label3.TabIndex = 2;
      this.label3.Text = "Maximum amount of time needed to serve request";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F);
      this.label4.Location = new System.Drawing.Point(15, 245);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(179, 21);
      this.label4.TabIndex = 3;
      this.label4.Text = "Buffer minimum length";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F);
      this.label6.Location = new System.Drawing.Point(15, 569);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(158, 21);
      this.label6.TabIndex = 5;
      this.label6.Text = "Amount of requests";
      // 
      // textBox1
      // 
      this.textBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F);
      this.textBox1.Location = new System.Drawing.Point(407, 108);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(258, 29);
      this.textBox1.TabIndex = 6;
      // 
      // numericUpDown1
      // 
      this.numericUpDown1.Font = new System.Drawing.Font("Times New Roman", 14.25F);
      this.numericUpDown1.Location = new System.Drawing.Point(200, 243);
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
      this.textBox2.Location = new System.Drawing.Point(399, 474);
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new System.Drawing.Size(258, 29);
      this.textBox2.TabIndex = 10;
      // 
      // textBox3
      // 
      this.textBox3.Font = new System.Drawing.Font("Times New Roman", 14.25F);
      this.textBox3.Location = new System.Drawing.Point(403, 520);
      this.textBox3.Name = "textBox3";
      this.textBox3.Size = new System.Drawing.Size(258, 29);
      this.textBox3.TabIndex = 11;
      // 
      // numericUpDown3
      // 
      this.numericUpDown3.Font = new System.Drawing.Font("Times New Roman", 14.25F);
      this.numericUpDown3.Location = new System.Drawing.Point(179, 567);
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
      this.label7.Location = new System.Drawing.Point(194, 20);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(351, 31);
      this.label7.TabIndex = 14;
      this.label7.Text = "Enter simulation parameters";
      // 
      // button1
      // 
      this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F);
      this.button1.Location = new System.Drawing.Point(312, 624);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(129, 43);
      this.button1.TabIndex = 15;
      this.button1.Text = "Simulate";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // textBox4
      // 
      this.textBox4.Font = new System.Drawing.Font("Times New Roman", 14.25F);
      this.textBox4.Location = new System.Drawing.Point(411, 153);
      this.textBox4.Name = "textBox4";
      this.textBox4.Size = new System.Drawing.Size(258, 29);
      this.textBox4.TabIndex = 17;
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Font = new System.Drawing.Font("Times New Roman", 14.25F);
      this.label8.Location = new System.Drawing.Point(15, 156);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(390, 21);
      this.label8.TabIndex = 16;
      this.label8.Text = "Maximum average amount of requests per time unit";
      // 
      // numericUpDown4
      // 
      this.numericUpDown4.Font = new System.Drawing.Font("Times New Roman", 14.25F);
      this.numericUpDown4.Location = new System.Drawing.Point(174, 198);
      this.numericUpDown4.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
      this.numericUpDown4.Name = "numericUpDown4";
      this.numericUpDown4.Size = new System.Drawing.Size(103, 29);
      this.numericUpDown4.TabIndex = 19;
      this.numericUpDown4.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Font = new System.Drawing.Font("Times New Roman", 14.25F);
      this.label9.Location = new System.Drawing.Point(15, 200);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(157, 21);
      this.label9.TabIndex = 18;
      this.label9.Text = "Amount of intervals";
      // 
      // numericUpDown5
      // 
      this.numericUpDown5.Font = new System.Drawing.Font("Times New Roman", 14.25F);
      this.numericUpDown5.Location = new System.Drawing.Point(200, 291);
      this.numericUpDown5.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
      this.numericUpDown5.Name = "numericUpDown5";
      this.numericUpDown5.Size = new System.Drawing.Size(103, 29);
      this.numericUpDown5.TabIndex = 21;
      this.numericUpDown5.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      // 
      // label10
      // 
      this.label10.AutoSize = true;
      this.label10.Font = new System.Drawing.Font("Times New Roman", 14.25F);
      this.label10.Location = new System.Drawing.Point(15, 293);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(183, 21);
      this.label10.TabIndex = 20;
      this.label10.Text = "Buffer maximum length";
      // 
      // numericUpDown7
      // 
      this.numericUpDown7.Font = new System.Drawing.Font("Times New Roman", 14.25F);
      this.numericUpDown7.Location = new System.Drawing.Point(247, 385);
      this.numericUpDown7.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
      this.numericUpDown7.Name = "numericUpDown7";
      this.numericUpDown7.Size = new System.Drawing.Size(103, 29);
      this.numericUpDown7.TabIndex = 27;
      this.numericUpDown7.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      // 
      // label12
      // 
      this.label12.AutoSize = true;
      this.label12.Font = new System.Drawing.Font("Times New Roman", 14.25F);
      this.label12.Location = new System.Drawing.Point(15, 387);
      this.label12.Name = "label12";
      this.label12.Size = new System.Drawing.Size(226, 21);
      this.label12.TabIndex = 26;
      this.label12.Text = "Maximum amount of devices";
      // 
      // numericUpDown8
      // 
      this.numericUpDown8.Font = new System.Drawing.Font("Times New Roman", 14.25F);
      this.numericUpDown8.Location = new System.Drawing.Point(243, 338);
      this.numericUpDown8.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
      this.numericUpDown8.Name = "numericUpDown8";
      this.numericUpDown8.Size = new System.Drawing.Size(103, 29);
      this.numericUpDown8.TabIndex = 25;
      this.numericUpDown8.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      // 
      // label13
      // 
      this.label13.AutoSize = true;
      this.label13.Font = new System.Drawing.Font("Times New Roman", 14.25F);
      this.label13.Location = new System.Drawing.Point(15, 340);
      this.label13.Name = "label13";
      this.label13.Size = new System.Drawing.Size(222, 21);
      this.label13.TabIndex = 24;
      this.label13.Text = "Minimum amount of devices";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Times New Roman", 17.25F, System.Drawing.FontStyle.Bold);
      this.label5.Location = new System.Drawing.Point(15, 68);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(89, 25);
      this.label5.TabIndex = 28;
      this.label5.Text = "Varying";
      // 
      // label11
      // 
      this.label11.AutoSize = true;
      this.label11.Font = new System.Drawing.Font("Times New Roman", 17.25F, System.Drawing.FontStyle.Bold);
      this.label11.Location = new System.Drawing.Point(15, 431);
      this.label11.Name = "label11";
      this.label11.Size = new System.Drawing.Size(104, 25);
      this.label11.TabIndex = 29;
      this.label11.Text = "Constant";
      // 
      // AutomaticModeParametersForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(770, 679);
      this.Controls.Add(this.label11);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.numericUpDown7);
      this.Controls.Add(this.label12);
      this.Controls.Add(this.numericUpDown8);
      this.Controls.Add(this.label13);
      this.Controls.Add(this.numericUpDown5);
      this.Controls.Add(this.label10);
      this.Controls.Add(this.numericUpDown4);
      this.Controls.Add(this.label9);
      this.Controls.Add(this.textBox4);
      this.Controls.Add(this.label8);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.numericUpDown3);
      this.Controls.Add(this.textBox3);
      this.Controls.Add(this.textBox2);
      this.Controls.Add(this.numericUpDown1);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Name = "AutomaticModeParametersForm";
      this.Text = "Parameters";
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown7)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown8)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private Label label1;
    private Label label2;
    private Label label3;
    private Label label4;
    private Label label6;
    private TextBox textBox1;
    private NumericUpDown numericUpDown1;
    private TextBox textBox2;
    private TextBox textBox3;
    private NumericUpDown numericUpDown3;
    private Label label7;
    private Button button1;
    private TextBox textBox4;
    private Label label8;
    private NumericUpDown numericUpDown4;
    private Label label9;
    private NumericUpDown numericUpDown5;
    private Label label10;
    private NumericUpDown numericUpDown7;
    private Label label12;
    private NumericUpDown numericUpDown8;
    private Label label13;
    private Label label5;
    private Label label11;
  }
}