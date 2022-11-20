using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QueuingSystem
{
  public partial class StepModeParametersForm : Form
  {
    public StepModeParametersForm()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      if (textBox1.Text.Length > 0 && textBox2.Text.Length > 0 && textBox3.Text.Length > 0)
      {
        double alpha, beta, lambda;
        try
        {
          lambda = Convert.ToDouble(this.textBox1.Text);
          alpha = Convert.ToDouble(this.textBox2.Text);
          beta = Convert.ToDouble(this.textBox3.Text);
        }
        catch
        {
          MessageBox.Show("Error parsing double value. Incorrect string(s)", "Error", MessageBoxButtons.OK);
          return;
        }

        StepModeForm stepModeForm = new StepModeForm(new MainStepMode(lambda, alpha, beta, Convert.ToInt32(numericUpDown1.Value),
          Convert.ToInt32(numericUpDown2.Value), Convert.ToInt32(numericUpDown3.Value)));
        stepModeForm.FormClosing += delegate { this.Show(); };
        Hide();
        stepModeForm.ShowDialog();
      }
      else
      {
        MessageBox.Show("You have to enter all parameters", "Error", MessageBoxButtons.OK);
      }
    }
  }
}
