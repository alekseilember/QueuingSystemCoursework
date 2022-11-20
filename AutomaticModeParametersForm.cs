﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QueuingSystemCoursework
{
  public partial class AutomaticModeParametersForm : Form
  {
    public AutomaticModeParametersForm()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      if (textBox1.Text.Length > 0 && textBox2.Text.Length > 0 && textBox3.Text.Length > 0)
      {
        double alpha, beta, minLambda, maxLambda;
        try
        {
          minLambda = Convert.ToDouble(this.textBox1.Text);
          maxLambda = Convert.ToDouble(this.textBox4.Text);
          alpha = Convert.ToDouble(this.textBox2.Text);
          beta = Convert.ToDouble(this.textBox3.Text);

          if (alpha > beta)
          {
            MessageBox.Show("Maximum amount of time needed to serve request can not be less than minimum", "Error", MessageBoxButtons.OK);
            return;
          }
          if (minLambda > maxLambda)
          {
            MessageBox.Show("Maximum average amount of requests per time unit can not be less than minimum", "Error", MessageBoxButtons.OK);
            return;
          }
          if (numericUpDown1.Value > numericUpDown5.Value)
          {
            MessageBox.Show("Maximum buffer length can not be less than minimum", "Error", MessageBoxButtons.OK);
            return;
          }
          if (numericUpDown8.Value > numericUpDown7.Value)
          {
            MessageBox.Show("Maximum amount of devices can not be less than minimum", "Error", MessageBoxButtons.OK);
            return;
          }
        }
        catch
        {
          MessageBox.Show("Error parsing double value. Incorrect string(s)", "Error", MessageBoxButtons.OK);
          return;
        }

        AutomaticModeForm automaticModeForm = new AutomaticModeForm();
        automaticModeForm.FormClosing += delegate { this.Show(); };
        Hide();
        automaticModeForm.ShowDialog();
      }
      else
      {
        MessageBox.Show("You have to enter all parameters", "Error", MessageBoxButtons.OK);
      }
    }
  }
}
