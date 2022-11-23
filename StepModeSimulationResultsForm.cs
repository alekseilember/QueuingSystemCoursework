using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QueuingSystemCoursework
{
  public partial class StepModeSimulationResultsForm : Form
  {
    public StepModeSimulationResultsForm(double probabilityOfRefuse, double averageRequestInSystemTime, double[] deviceUsageCoefficients)
    {
      InitializeComponent();
      dataGridView2.Rows.Add(probabilityOfRefuse.ToString(), averageRequestInSystemTime.ToString());
      
      for (int i = 0; i < deviceUsageCoefficients.Length; i++)
      {
        dataGridView1.Rows.Add("D" + (i + 1), deviceUsageCoefficients[i].ToString());
      }
    }
  }
}
