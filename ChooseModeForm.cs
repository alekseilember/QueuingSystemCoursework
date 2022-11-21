using System.Windows.Forms;
using System;

namespace QueuingSystemCoursework
{
  public partial class ChooseModeForm : Form
  {
    public ChooseModeForm()
    {
      InitializeComponent();
    }

    private void step_Click(object sender, EventArgs e)
    {
      StepModeParametersForm stepModeParametersForm = new StepModeParametersForm();
      stepModeParametersForm.FormClosing += delegate { this.Show(); };
      Hide();
      stepModeParametersForm.ShowDialog();
    }

    private void automatic_Click(object sender, EventArgs e)
    {
      AutomaticModePlotsForm automaticModePlotsForm = new AutomaticModePlotsForm();
      automaticModePlotsForm.FormClosing += delegate { this.Show(); };
      Hide();
      automaticModePlotsForm.ShowDialog();
    }
  }
}