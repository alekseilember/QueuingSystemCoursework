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
  internal partial class StepModeForm : Form
  {
    private LinkedList<SystemStateSnapshot> tableRows;

    private int bufferPointer = 0;
    public StepModeForm(double lambda, double alpha, double beta, int bufferLength, int amountOfDevices, int amountOfRequests)
    {
      InitializeComponent();
      this.simulation = new Simulation();
      simulation.init(lambda, alpha, beta, bufferLength, amountOfDevices, amountOfRequests);

      DataGridViewTextBoxColumn column1 = new DataGridViewTextBoxColumn();
      column1.Name = "System element";
      column1.HeaderText = column1.Name;

      DataGridViewTextBoxColumn column2 = new DataGridViewTextBoxColumn();
      column2.Name = "Time";
      column2.HeaderText = column2.Name;

      DataGridViewTextBoxColumn column3 = new DataGridViewTextBoxColumn();
      column3.Name = "Action";
      column3.HeaderText = column3.Name;

      DataGridViewTextBoxColumn column4 = new DataGridViewTextBoxColumn();
      column4.Name = "Requests served";
      column4.HeaderText = column4.Name;

      DataGridViewTextBoxColumn column5 = new DataGridViewTextBoxColumn();
      column5.Name = "Requests refused";
      column5.HeaderText = column5.Name;

      DataGridViewTextBoxColumn column6 = new DataGridViewTextBoxColumn();
      column6.Name = "Pointer";
      column6.HeaderText = column6.Name;

      DataGridViewTextBoxColumn column7 = new DataGridViewTextBoxColumn();
      column7.Name = "Index";
      column7.HeaderText = column7.Name;

      DataGridViewTextBoxColumn column8 = new DataGridViewTextBoxColumn();
      column8.Name = "Request number";
      column8.HeaderText = column8.Name;

      this.dataGridView1.Columns.Add(column1);
      this.dataGridView1.Columns.Add(column2);
      this.dataGridView1.Columns.Add(column3);
      this.dataGridView1.Columns.Add(column4);
      this.dataGridView1.Columns.Add(column5);

      this.dataGridView2.Columns.Add(column6);
      this.dataGridView2.Columns.Add(column7);
      this.dataGridView2.Columns.Add(column8);

      tableRows = simulation.nextStep();

      dataGridView2.Rows.Add(bufferLength - 1);
      for (int i = 0; i < dataGridView2.Rows.Count; i++)
      {
        dataGridView2.Rows[i].Cells["Request number"].Value = "null";
        dataGridView2.Rows[i].Cells["Index"].Value = i + 1;
      }
      dataGridView2.Rows[bufferPointer].Cells["Pointer"].Value = "-->";
    }

    private void button1_Click(object sender, EventArgs e)
    {
      if (tableRows.Count == 0)
      {
        tableRows = simulation.nextStep();
      }

      if (tableRows.Count > 0)
      {
        SystemStateSnapshot tableRow = tableRows.ElementAt(0);
        this.dataGridView1.Rows.Add(tableRow.SystemElement, tableRow.Time, tableRow.Action, tableRow.ServedRequestsCounter,
          tableRow.RefusedRequestsCounter);
        this.dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.RowCount - 1;

        if (tableRow.Buffer != null)
        {
          for (int i = 0; i < dataGridView2.Rows.Count; i++)
          {
            dataGridView2.Rows[i].Cells["Request number"].Value = tableRow.Buffer[i] == null ? "null" : tableRow.Buffer[i].Number.ToString();
          }
        }

        if (tableRow.BufferPointer != null)
        {
          dataGridView2.Rows[bufferPointer].Cells["Pointer"].Value = "";
          bufferPointer = (int)tableRow.BufferPointer;
          dataGridView2.Rows[bufferPointer].Cells["Pointer"].Value = "-->";
        }

        tableRows.RemoveFirst();
      }
      else
      {
        var resultSet = simulation.doAutomaticSimulation();
        StepModeSimulationResultsForm stepModeSimulationResultsForm = new StepModeSimulationResultsForm(resultSet.ProbabilityOfRefuse,
          resultSet.AverageRequestInSystemTime, resultSet.DeviceUsageCoefficients);
        stepModeSimulationResultsForm.FormClosing += delegate { this.Show(); };
        Hide();
        stepModeSimulationResultsForm.ShowDialog();
      }
    }

    private void button2_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void button3_Click(object sender, EventArgs e)
    {
      dataGridView2.Rows.Clear();
      while (true)
      {
        if (tableRows.Count == 0)
        {
          tableRows = simulation.nextStep();
        }

        if (tableRows.Count > 0)
        {
          SystemStateSnapshot tableRow = tableRows.ElementAt(0);
          this.dataGridView1.Rows.Add(tableRow.SystemElement, tableRow.Time, tableRow.Action, tableRow.ServedRequestsCounter,
            tableRow.RefusedRequestsCounter);
          this.dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.RowCount - 1;
          tableRows.RemoveFirst();
        }
        else
        {
          break;
        }
      }
      var resultSet = simulation.doAutomaticSimulation();
      StepModeSimulationResultsForm stepModeSimulationResultsForm = new StepModeSimulationResultsForm(resultSet.ProbabilityOfRefuse,
        resultSet.AverageRequestInSystemTime, resultSet.DeviceUsageCoefficients);
      stepModeSimulationResultsForm.FormClosing += delegate { this.Show(); };
      Hide();
      stepModeSimulationResultsForm.ShowDialog();
    }
  }
}
