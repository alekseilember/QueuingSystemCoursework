namespace QueuingSystemCoursework
{
    partial class AutomaticModePlotsForm
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
      System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
      System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
      this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
      this.button1 = new System.Windows.Forms.Button();
      this.label7 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.comboBox1 = new System.Windows.Forms.ComboBox();
      this.comboBox2 = new System.Windows.Forms.ComboBox();
      this.label5 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.label11 = new System.Windows.Forms.Label();
      this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
      this.label1 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
      this.label9 = new System.Windows.Forms.Label();
      this.textBox4 = new System.Windows.Forms.TextBox();
      this.label8 = new System.Windows.Forms.Label();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.label10 = new System.Windows.Forms.Label();
      this.textBox2 = new System.Windows.Forms.TextBox();
      this.textBox3 = new System.Windows.Forms.TextBox();
      this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
      this.label16 = new System.Windows.Forms.Label();
      this.numericUpDown6 = new System.Windows.Forms.NumericUpDown();
      this.label17 = new System.Windows.Forms.Label();
      this.textBox5 = new System.Windows.Forms.TextBox();
      this.label12 = new System.Windows.Forms.Label();
      this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
      this.label13 = new System.Windows.Forms.Label();
      this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
      this.label14 = new System.Windows.Forms.Label();
      this.numericUpDown8 = new System.Windows.Forms.NumericUpDown();
      this.label18 = new System.Windows.Forms.Label();
      this.numericUpDown9 = new System.Windows.Forms.NumericUpDown();
      this.label19 = new System.Windows.Forms.Label();
      this.label15 = new System.Windows.Forms.Label();
      this.label20 = new System.Windows.Forms.Label();
      this.label21 = new System.Windows.Forms.Label();
      this.progressBar1 = new System.Windows.Forms.ProgressBar();
      ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown8)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown9)).BeginInit();
      this.SuspendLayout();
      // 
      // chart1
      // 
      chartArea1.AxisX.Title = "Amount of devices";
      chartArea1.AxisX.TitleFont = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      chartArea1.AxisY.Title = "Probability of refuse";
      chartArea1.AxisY.TitleFont = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      chartArea1.Name = "ChartArea1";
      this.chart1.ChartAreas.Add(chartArea1);
      this.chart1.Location = new System.Drawing.Point(12, 345);
      this.chart1.Name = "chart1";
      series1.BorderColor = System.Drawing.Color.White;
      series1.BorderWidth = 3;
      series1.ChartArea = "ChartArea1";
      series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
      series1.Color = System.Drawing.Color.Blue;
      series1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      series1.Name = "D1";
      this.chart1.Series.Add(series1);
      this.chart1.Size = new System.Drawing.Size(1469, 654);
      this.chart1.TabIndex = 0;
      this.chart1.Text = "chart1";
      // 
      // button1
      // 
      this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.button1.Location = new System.Drawing.Point(1362, 257);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(120, 82);
      this.button1.TabIndex = 1;
      this.button1.Text = "Simulate and build plot";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold);
      this.label7.Location = new System.Drawing.Point(7, 113);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(254, 31);
      this.label7.TabIndex = 15;
      this.label7.Text = "Variable parameters";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label4.Location = new System.Drawing.Point(11, 54);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(124, 21);
      this.label4.TabIndex = 16;
      this.label4.Text = "Dependency of";
      this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
      // 
      // comboBox1
      // 
      this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.comboBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.comboBox1.FormattingEnabled = true;
      this.comboBox1.Items.AddRange(new object[] {
            "probability of refuse",
            "average request in system time",
            "devices usage coefficients"});
      this.comboBox1.Location = new System.Drawing.Point(141, 51);
      this.comboBox1.Name = "comboBox1";
      this.comboBox1.Size = new System.Drawing.Size(275, 29);
      this.comboBox1.TabIndex = 17;
      // 
      // comboBox2
      // 
      this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.comboBox2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.comboBox2.FormattingEnabled = true;
      this.comboBox2.Items.AddRange(new object[] {
            "average amount of requests per time unit",
            "amount of devices",
            "buffer length"});
      this.comboBox2.Location = new System.Drawing.Point(474, 51);
      this.comboBox2.Name = "comboBox2";
      this.comboBox2.Size = new System.Drawing.Size(337, 29);
      this.comboBox2.TabIndex = 19;
      this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label5.Location = new System.Drawing.Point(422, 56);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(46, 21);
      this.label5.TabIndex = 18;
      this.label5.Text = "from";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold);
      this.label6.Location = new System.Drawing.Point(6, 9);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(118, 31);
      this.label6.TabIndex = 20;
      this.label6.Text = "Plot type";
      // 
      // label11
      // 
      this.label11.AutoSize = true;
      this.label11.Font = new System.Drawing.Font("Times New Roman", 17.25F, System.Drawing.FontStyle.Bold);
      this.label11.Location = new System.Drawing.Point(839, 14);
      this.label11.Name = "label11";
      this.label11.Size = new System.Drawing.Size(225, 25);
      this.label11.TabIndex = 34;
      this.label11.Text = "Constant parameters";
      // 
      // numericUpDown3
      // 
      this.numericUpDown3.Font = new System.Drawing.Font("Times New Roman", 14.25F);
      this.numericUpDown3.Location = new System.Drawing.Point(1378, 16);
      this.numericUpDown3.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
      this.numericUpDown3.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.numericUpDown3.Name = "numericUpDown3";
      this.numericUpDown3.Size = new System.Drawing.Size(103, 29);
      this.numericUpDown3.TabIndex = 33;
      this.numericUpDown3.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F);
      this.label1.Location = new System.Drawing.Point(1214, 18);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(158, 21);
      this.label1.TabIndex = 32;
      this.label1.Text = "Amount of requests";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F);
      this.label3.Location = new System.Drawing.Point(839, 106);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(382, 21);
      this.label3.TabIndex = 31;
      this.label3.Text = "Maximum amount of time needed to serve request";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F);
      this.label2.Location = new System.Drawing.Point(839, 60);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(378, 21);
      this.label2.TabIndex = 30;
      this.label2.Text = "Minimum amount of time needed to serve request";
      // 
      // numericUpDown4
      // 
      this.numericUpDown4.Font = new System.Drawing.Font("Times New Roman", 14.25F);
      this.numericUpDown4.Location = new System.Drawing.Point(172, 241);
      this.numericUpDown4.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
      this.numericUpDown4.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.numericUpDown4.Name = "numericUpDown4";
      this.numericUpDown4.Size = new System.Drawing.Size(103, 29);
      this.numericUpDown4.TabIndex = 40;
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
      this.label9.Location = new System.Drawing.Point(13, 243);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(157, 21);
      this.label9.TabIndex = 39;
      this.label9.Text = "Amount of intervals";
      // 
      // textBox4
      // 
      this.textBox4.Font = new System.Drawing.Font("Times New Roman", 14.25F);
      this.textBox4.Location = new System.Drawing.Point(409, 196);
      this.textBox4.Name = "textBox4";
      this.textBox4.Size = new System.Drawing.Size(258, 29);
      this.textBox4.TabIndex = 38;
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Font = new System.Drawing.Font("Times New Roman", 14.25F);
      this.label8.Location = new System.Drawing.Point(13, 199);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(390, 21);
      this.label8.TabIndex = 37;
      this.label8.Text = "Maximum average amount of requests per time unit";
      // 
      // textBox1
      // 
      this.textBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F);
      this.textBox1.Location = new System.Drawing.Point(405, 151);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(258, 29);
      this.textBox1.TabIndex = 36;
      // 
      // label10
      // 
      this.label10.AutoSize = true;
      this.label10.Font = new System.Drawing.Font("Times New Roman", 14.25F);
      this.label10.Location = new System.Drawing.Point(13, 154);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(386, 21);
      this.label10.TabIndex = 35;
      this.label10.Text = "Minimum average amount of requests per time unit";
      // 
      // textBox2
      // 
      this.textBox2.Font = new System.Drawing.Font("Times New Roman", 14.25F);
      this.textBox2.Location = new System.Drawing.Point(1223, 53);
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new System.Drawing.Size(258, 29);
      this.textBox2.TabIndex = 49;
      // 
      // textBox3
      // 
      this.textBox3.Font = new System.Drawing.Font("Times New Roman", 14.25F);
      this.textBox3.Location = new System.Drawing.Point(1223, 103);
      this.textBox3.Name = "textBox3";
      this.textBox3.Size = new System.Drawing.Size(258, 29);
      this.textBox3.TabIndex = 50;
      // 
      // numericUpDown2
      // 
      this.numericUpDown2.Font = new System.Drawing.Font("Times New Roman", 14.25F);
      this.numericUpDown2.Location = new System.Drawing.Point(1182, 274);
      this.numericUpDown2.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
      this.numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.numericUpDown2.Name = "numericUpDown2";
      this.numericUpDown2.Size = new System.Drawing.Size(103, 29);
      this.numericUpDown2.TabIndex = 52;
      this.numericUpDown2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      // 
      // label16
      // 
      this.label16.AutoSize = true;
      this.label16.Font = new System.Drawing.Font("Times New Roman", 14.25F);
      this.label16.Location = new System.Drawing.Point(1070, 276);
      this.label16.Name = "label16";
      this.label16.Size = new System.Drawing.Size(106, 21);
      this.label16.TabIndex = 51;
      this.label16.Text = "Buffer length";
      // 
      // numericUpDown6
      // 
      this.numericUpDown6.Font = new System.Drawing.Font("Times New Roman", 14.25F);
      this.numericUpDown6.Location = new System.Drawing.Point(851, 274);
      this.numericUpDown6.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
      this.numericUpDown6.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.numericUpDown6.Name = "numericUpDown6";
      this.numericUpDown6.Size = new System.Drawing.Size(103, 29);
      this.numericUpDown6.TabIndex = 54;
      this.numericUpDown6.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      // 
      // label17
      // 
      this.label17.AutoSize = true;
      this.label17.Font = new System.Drawing.Font("Times New Roman", 14.25F);
      this.label17.Location = new System.Drawing.Point(694, 276);
      this.label17.Name = "label17";
      this.label17.Size = new System.Drawing.Size(152, 21);
      this.label17.TabIndex = 53;
      this.label17.Text = "Amount of devices";
      // 
      // textBox5
      // 
      this.textBox5.Font = new System.Drawing.Font("Times New Roman", 14.25F);
      this.textBox5.Location = new System.Drawing.Point(336, 310);
      this.textBox5.Name = "textBox5";
      this.textBox5.Size = new System.Drawing.Size(258, 29);
      this.textBox5.TabIndex = 56;
      // 
      // label12
      // 
      this.label12.AutoSize = true;
      this.label12.Font = new System.Drawing.Font("Times New Roman", 14.25F);
      this.label12.Location = new System.Drawing.Point(15, 313);
      this.label12.Name = "label12";
      this.label12.Size = new System.Drawing.Size(315, 21);
      this.label12.TabIndex = 55;
      this.label12.Text = "Average amount of requests per time unit";
      // 
      // numericUpDown1
      // 
      this.numericUpDown1.Font = new System.Drawing.Font("Times New Roman", 14.25F);
      this.numericUpDown1.Location = new System.Drawing.Point(926, 199);
      this.numericUpDown1.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
      this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.numericUpDown1.Name = "numericUpDown1";
      this.numericUpDown1.Size = new System.Drawing.Size(103, 29);
      this.numericUpDown1.TabIndex = 58;
      this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      // 
      // label13
      // 
      this.label13.AutoSize = true;
      this.label13.Font = new System.Drawing.Font("Times New Roman", 14.25F);
      this.label13.Location = new System.Drawing.Point(694, 201);
      this.label13.Name = "label13";
      this.label13.Size = new System.Drawing.Size(226, 21);
      this.label13.TabIndex = 57;
      this.label13.Text = "Maximum amount of devices";
      // 
      // numericUpDown5
      // 
      this.numericUpDown5.Font = new System.Drawing.Font("Times New Roman", 14.25F);
      this.numericUpDown5.Location = new System.Drawing.Point(922, 151);
      this.numericUpDown5.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
      this.numericUpDown5.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.numericUpDown5.Name = "numericUpDown5";
      this.numericUpDown5.Size = new System.Drawing.Size(103, 29);
      this.numericUpDown5.TabIndex = 60;
      this.numericUpDown5.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      // 
      // label14
      // 
      this.label14.AutoSize = true;
      this.label14.Font = new System.Drawing.Font("Times New Roman", 14.25F);
      this.label14.Location = new System.Drawing.Point(694, 153);
      this.label14.Name = "label14";
      this.label14.Size = new System.Drawing.Size(222, 21);
      this.label14.TabIndex = 59;
      this.label14.Text = "Minimum amount of devices";
      // 
      // numericUpDown8
      // 
      this.numericUpDown8.Font = new System.Drawing.Font("Times New Roman", 14.25F);
      this.numericUpDown8.Location = new System.Drawing.Point(1249, 146);
      this.numericUpDown8.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
      this.numericUpDown8.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.numericUpDown8.Name = "numericUpDown8";
      this.numericUpDown8.Size = new System.Drawing.Size(103, 29);
      this.numericUpDown8.TabIndex = 64;
      this.numericUpDown8.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      // 
      // label18
      // 
      this.label18.AutoSize = true;
      this.label18.Font = new System.Drawing.Font("Times New Roman", 14.25F);
      this.label18.Location = new System.Drawing.Point(1064, 148);
      this.label18.Name = "label18";
      this.label18.Size = new System.Drawing.Size(179, 21);
      this.label18.TabIndex = 63;
      this.label18.Text = "Minimum buffer length";
      // 
      // numericUpDown9
      // 
      this.numericUpDown9.Font = new System.Drawing.Font("Times New Roman", 14.25F);
      this.numericUpDown9.Location = new System.Drawing.Point(1253, 196);
      this.numericUpDown9.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
      this.numericUpDown9.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.numericUpDown9.Name = "numericUpDown9";
      this.numericUpDown9.Size = new System.Drawing.Size(103, 29);
      this.numericUpDown9.TabIndex = 66;
      this.numericUpDown9.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      // 
      // label19
      // 
      this.label19.AutoSize = true;
      this.label19.Font = new System.Drawing.Font("Times New Roman", 14.25F);
      this.label19.Location = new System.Drawing.Point(1064, 198);
      this.label19.Name = "label19";
      this.label19.Size = new System.Drawing.Size(183, 21);
      this.label19.TabIndex = 65;
      this.label19.Text = "Maximum buffer length";
      // 
      // label15
      // 
      this.label15.AutoSize = true;
      this.label15.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold);
      this.label15.Location = new System.Drawing.Point(692, 233);
      this.label15.Name = "label15";
      this.label15.Size = new System.Drawing.Size(347, 31);
      this.label15.TabIndex = 67;
      this.label15.Text = "-------------------------------------";
      // 
      // label20
      // 
      this.label20.AutoSize = true;
      this.label20.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold);
      this.label20.Location = new System.Drawing.Point(11, 276);
      this.label20.Name = "label20";
      this.label20.Size = new System.Drawing.Size(662, 31);
      this.label20.TabIndex = 68;
      this.label20.Text = "------------------------------------------------------------------------";
      // 
      // label21
      // 
      this.label21.AutoSize = true;
      this.label21.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold);
      this.label21.Location = new System.Drawing.Point(1062, 233);
      this.label21.Name = "label21";
      this.label21.Size = new System.Drawing.Size(302, 31);
      this.label21.TabIndex = 69;
      this.label21.Text = "--------------------------------";
      // 
      // progressBar1
      // 
      this.progressBar1.ForeColor = System.Drawing.SystemColors.HotTrack;
      this.progressBar1.Location = new System.Drawing.Point(616, 632);
      this.progressBar1.Name = "progressBar1";
      this.progressBar1.Size = new System.Drawing.Size(300, 25);
      this.progressBar1.Step = 1;
      this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
      this.progressBar1.TabIndex = 70;
      this.progressBar1.Visible = false;
      // 
      // AutomaticModePlotsForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1494, 1007);
      this.Controls.Add(this.progressBar1);
      this.Controls.Add(this.label21);
      this.Controls.Add(this.label20);
      this.Controls.Add(this.label15);
      this.Controls.Add(this.numericUpDown9);
      this.Controls.Add(this.label19);
      this.Controls.Add(this.numericUpDown8);
      this.Controls.Add(this.label18);
      this.Controls.Add(this.numericUpDown5);
      this.Controls.Add(this.label14);
      this.Controls.Add(this.numericUpDown1);
      this.Controls.Add(this.label13);
      this.Controls.Add(this.textBox5);
      this.Controls.Add(this.label12);
      this.Controls.Add(this.numericUpDown6);
      this.Controls.Add(this.label17);
      this.Controls.Add(this.numericUpDown2);
      this.Controls.Add(this.label16);
      this.Controls.Add(this.textBox3);
      this.Controls.Add(this.textBox2);
      this.Controls.Add(this.numericUpDown4);
      this.Controls.Add(this.label9);
      this.Controls.Add(this.textBox4);
      this.Controls.Add(this.label8);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.label10);
      this.Controls.Add(this.label11);
      this.Controls.Add(this.numericUpDown3);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.comboBox2);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.comboBox1);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.chart1);
      this.Name = "AutomaticModePlotsForm";
      this.Text = "Plots";
      ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown8)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown9)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown numericUpDown6;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown numericUpDown5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown numericUpDown8;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.NumericUpDown numericUpDown9;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}