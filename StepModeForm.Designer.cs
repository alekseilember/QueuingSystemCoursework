using System;
using System.Windows.Forms;

namespace QueuingSystem
{
  partial class StepModeForm
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
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.button1 = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.button3 = new System.Windows.Forms.Button();
      this.dataGridView2 = new System.Windows.Forms.DataGridView();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
      this.SuspendLayout();
      // 
      // dataGridView1
      // 
      dataGridViewCellStyle13.Font = new System.Drawing.Font("Times New Roman", 14.25F);
      this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
      dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
      dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle14.Font = new System.Drawing.Font("Times New Roman", 14.25F);
      dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
      dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Window;
      dataGridViewCellStyle15.Font = new System.Drawing.Font("Times New Roman", 14.25F);
      dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlText;
      dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle15;
      this.dataGridView1.Location = new System.Drawing.Point(17, 49);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.ReadOnly = true;
      this.dataGridView1.RowTemplate.Height = 25;
      this.dataGridView1.Size = new System.Drawing.Size(935, 573);
      this.dataGridView1.TabIndex = 0;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold);
      this.label1.Location = new System.Drawing.Point(17, 8);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(191, 31);
      this.label1.TabIndex = 2;
      this.label1.Text = "Event calendar";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold);
      this.label2.Location = new System.Drawing.Point(972, 8);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(151, 31);
      this.label2.TabIndex = 3;
      this.label2.Text = "Buffer state";
      // 
      // button1
      // 
      this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F);
      this.button1.Location = new System.Drawing.Point(481, 648);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(129, 43);
      this.button1.TabIndex = 4;
      this.button1.Text = "Next step";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // button2
      // 
      this.button2.Font = new System.Drawing.Font("Times New Roman", 14.25F);
      this.button2.Location = new System.Drawing.Point(777, 648);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(129, 43);
      this.button2.TabIndex = 5;
      this.button2.Text = "Finish";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // button3
      // 
      this.button3.Font = new System.Drawing.Font("Times New Roman", 14.25F);
      this.button3.Location = new System.Drawing.Point(624, 648);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(138, 43);
      this.button3.TabIndex = 6;
      this.button3.Text = "Simulate till end";
      this.button3.UseVisualStyleBackColor = true;
      this.button3.Click += new System.EventHandler(this.button3_Click);
      // 
      // dataGridView2
      // 
      dataGridViewCellStyle16.Font = new System.Drawing.Font("Times New Roman", 14.25F);
      this.dataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
      dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
      dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle17.Font = new System.Drawing.Font("Times New Roman", 14.25F);
      dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
      this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
      dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window;
      dataGridViewCellStyle18.Font = new System.Drawing.Font("Times New Roman", 14.25F);
      dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText;
      dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle18;
      this.dataGridView2.Location = new System.Drawing.Point(972, 49);
      this.dataGridView2.Name = "dataGridView2";
      this.dataGridView2.ReadOnly = true;
      this.dataGridView2.RowTemplate.Height = 25;
      this.dataGridView2.Size = new System.Drawing.Size(421, 573);
      this.dataGridView2.TabIndex = 7;
      // 
      // StepModeForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1411, 703);
      this.Controls.Add(this.dataGridView2);
      this.Controls.Add(this.button3);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.dataGridView1);
      this.Name = "StepModeForm";
      this.Text = "Step mode simulation";
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private DataGridView dataGridView1;
    private Label label1;
    private Label label2;
    private Button button1;
    private Button button2;

    private MainStepMode main;
    private Button button3;
    private DataGridView dataGridView2;
  }
}