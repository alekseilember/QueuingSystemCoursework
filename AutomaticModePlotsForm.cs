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
using System.Windows.Forms.DataVisualization.Charting;

namespace QueuingSystemCoursework
{
  public partial class AutomaticModePlotsForm : Form
  {
    public AutomaticModePlotsForm()
    {
      InitializeComponent();

      comboBox1.Text = "probability of refuse";
      comboBox2.Text = "average amount of requests per time unit";
    }

    private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
    {
      switch (comboBox2.Text)
      {
        case "average amount of requests per time unit":
          textBox5.Enabled = false;
          numericUpDown1.Enabled = false;
          numericUpDown5.Enabled = false;
          numericUpDown9.Enabled = false;
          numericUpDown8.Enabled = false;

          textBox1.Enabled = true;
          textBox4.Enabled = true;
          numericUpDown4.Enabled = true;
          numericUpDown6.Enabled = true;
          numericUpDown2.Enabled = true;
          break;
        case "amount of devices":
          textBox5.Enabled = true;
          numericUpDown1.Enabled = true;
          numericUpDown5.Enabled = true;
          numericUpDown9.Enabled = false;
          numericUpDown8.Enabled = false;

          textBox1.Enabled = false;
          textBox4.Enabled = false;
          numericUpDown4.Enabled = false;
          numericUpDown6.Enabled = false;
          numericUpDown2.Enabled = true;
          break;
        case "buffer length":
          textBox5.Enabled = true;
          numericUpDown1.Enabled = false;
          numericUpDown5.Enabled = false;
          numericUpDown9.Enabled = true;
          numericUpDown8.Enabled = true;

          textBox1.Enabled = false;
          textBox4.Enabled = false;
          numericUpDown4.Enabled = false;
          numericUpDown6.Enabled = true;
          numericUpDown2.Enabled = false;
          break;
      }
    }

    private void button1_Click(object sender, EventArgs e)
    {

      if (textBox2.Text.Length > 0 && textBox3.Text.Length > 0)
      {
        double alpha, beta, lambda = 0, minLambda = 0, maxLambda = 0, lambdaStep = 0;

        try
        {
          alpha = Convert.ToDouble(this.textBox2.Text);
          beta = Convert.ToDouble(this.textBox3.Text);

          if (alpha > beta)
          {
            MessageBox.Show("Maximum amount of time needed to serve request can not be less than minimum", "Error", MessageBoxButtons.OK);
            return;
          }
          if (alpha <= 0.0 || beta <= 0.0)
          {
            MessageBox.Show("Maximum and minimum amounts of time needed to serve request must be more than zero", "Error", MessageBoxButtons.OK);
            return;
          }
        }
        catch
        {
          MessageBox.Show("Error parsing double value. Incorrect string(s)", "Error", MessageBoxButtons.OK);
          return;
        }


        switch (comboBox2.Text)
        {
          case "average amount of requests per time unit":
            if (textBox1.Text.Length > 0 && textBox4.Text.Length > 0)
            {
              try
              {
                minLambda = Convert.ToDouble(this.textBox1.Text);
                maxLambda = Convert.ToDouble(this.textBox4.Text);
                lambdaStep = (maxLambda - minLambda) / (int)numericUpDown4.Value;

                if (minLambda > maxLambda)
                {
                  MessageBox.Show("Maximum average amount of requests per time unit can not be less than minimum", "Error", MessageBoxButtons.OK);
                  return;
                }
                if (minLambda <= 0.0 || maxLambda <= 0.0)
                {
                  MessageBox.Show("Maximum and minimum average amounts of requests per time unit must be more than zero", "Error", MessageBoxButtons.OK);
                  return;
                }
              }
              catch
              {
                MessageBox.Show("Error parsing double value. Incorrect string(s)", "Error", MessageBoxButtons.OK);
                return;
              }
            }
            else
            {
              MessageBox.Show("You have to enter minimum and maximum average amount of time\nneeded to serve request parameters", "Error", MessageBoxButtons.OK);
            }

            InitializeChart();

            progressBar1.Maximum = (int)numericUpDown4.Value + 1;
            progressBar1.Visible = true;
            progressBar1.Value = 0;

            switch (comboBox1.Text)
            {
              case "probability of refuse":
                for (int i = 0; i <= (int)numericUpDown4.Value; i++)
                {
                  Simulation main = new Simulation(minLambda + i * lambdaStep, alpha, beta, (int)numericUpDown2.Value,
                    (int)numericUpDown6.Value, (int)numericUpDown3.Value);
                  var result = main.doAutomaticSimulation();

                  chart1.Series[0].Points.AddXY(minLambda + i * lambdaStep, result.Item1);
                  progressBar1.PerformStep();
                }
                break;
              case "average request in system time":
                for (int i = 0; i <= (int)numericUpDown4.Value; i++)
                {
                  Simulation main = new Simulation(minLambda + i * lambdaStep, alpha, beta, (int)numericUpDown2.Value,
                    (int)numericUpDown6.Value, (int)numericUpDown3.Value);
                  var result = main.doAutomaticSimulation();

                  chart1.Series[0].Points.AddXY(minLambda + i * lambdaStep, result.Item2);
                  progressBar1.PerformStep();
                }
                break;
              case "devices usage coefficients":
                chart1.Legends.Add("Legend1");
                chart1.Legends[0].Font = chart1.Series[0].Font;
                for (int i = 1; i < (int)numericUpDown6.Value; i++)
                {
                  chart1.Series.Add("D" + (i + 1));
                  chart1.Series[i].ChartType = chart1.Series[0].ChartType;
                  chart1.Series[i].BorderWidth = chart1.Series[0].BorderWidth;
                }

                for (int i = 0; i <= (int)numericUpDown4.Value; i++)
                {
                  Simulation main = new Simulation(minLambda + i * lambdaStep, alpha, beta, (int)numericUpDown2.Value,
                    (int)numericUpDown6.Value, (int)numericUpDown3.Value);
                  var result = main.doAutomaticSimulation();

                  for (int j = 0; j < chart1.Series.Count; j++)
                  {
                    chart1.Series[j].Points.AddXY(minLambda + i * lambdaStep, result.Item3[j]);
                  }

                  progressBar1.PerformStep();
                }
                break;
            }

            progressBar1.Visible = false;
            break;

          case "amount of devices":
            if (numericUpDown5.Value > numericUpDown1.Value)
            {
              MessageBox.Show("Maximum amount of devices can not be less than minimum", "Error", MessageBoxButtons.OK);
              return;
            }

            try
            {
              lambda = Convert.ToDouble(this.textBox5.Text);

              if (lambda <= 0.0)
              {
                MessageBox.Show("Average amounts of requests per time unit must be more than zero", "Error", MessageBoxButtons.OK);
                return;
              }
            }
            catch
            {
              MessageBox.Show("Error parsing double value. Incorrect string(s)", "Error", MessageBoxButtons.OK);
              return;
            }

            InitializeChart();

            progressBar1.Maximum = (int)(numericUpDown1.Value - numericUpDown5.Value);
            progressBar1.Visible = true;
            progressBar1.Value = 0;

            switch (comboBox1.Text)
            {
              case "probability of refuse":
                for (int i = (int)numericUpDown5.Value; i <= (int)numericUpDown1.Value; i++)
                {
                  Simulation main = new Simulation(lambda, alpha, beta, (int)numericUpDown2.Value, i, (int)numericUpDown3.Value);
                  var result = main.doAutomaticSimulation();

                  chart1.Series[0].Points.AddXY(i, result.Item1);
                  progressBar1.PerformStep();
                }
                break;

              case "average request in system time":
                for (int i = (int)numericUpDown5.Value; i <= (int)numericUpDown1.Value; i++)
                {
                  Simulation main = new Simulation(lambda, alpha, beta, (int)numericUpDown2.Value, i, (int)numericUpDown3.Value);
                  var result = main.doAutomaticSimulation();

                  chart1.Series[0].Points.AddXY(i, result.Item2);
                  progressBar1.PerformStep();
                }
                break;
                
              case "devices usage coefficients":
                chart1.Legends.Add("Legend1");
                chart1.Legends[0].Font = chart1.Series[0].Font;
                for (int i = 1; i < (int)numericUpDown1.Value; i++)
                {
                  chart1.Series.Add("D" + (i + 1));
                  chart1.Series[i].ChartType = chart1.Series[0].ChartType;
                  chart1.Series[i].BorderWidth = chart1.Series[0].BorderWidth;
                }

                for (int i = (int)numericUpDown5.Value; i <= (int)numericUpDown1.Value; i++)
                {
                  Simulation main = new Simulation(lambda, alpha, beta, (int)numericUpDown2.Value, i, (int)numericUpDown3.Value);
                  var result = main.doAutomaticSimulation();

                  for (int j = 0; j < result.Item3.Length; j++)
                  {
                    chart1.Series[j].Points.AddXY(i, result.Item3[j]);
                  }

                  progressBar1.PerformStep();
                }
                break;
            }

            progressBar1.Visible = false;

            break;

          case "buffer length":
            if (numericUpDown8.Value > numericUpDown9.Value)
            {
              MessageBox.Show("Maximum buffer length can not be less than minimum", "Error", MessageBoxButtons.OK);
              return;
            }

            try
            {
              lambda = Convert.ToDouble(this.textBox5.Text);

              if (lambda <= 0.0)
              {
                MessageBox.Show("Average amounts of requests per time unit must be more than zero", "Error", MessageBoxButtons.OK);
                return;
              }
            }
            catch
            {
              MessageBox.Show("Error parsing double value. Incorrect string(s)", "Error", MessageBoxButtons.OK);
              return;
            }

            InitializeChart();

            progressBar1.Maximum = (int)(numericUpDown9.Value - numericUpDown8.Value);
            progressBar1.Visible = true;
            progressBar1.Value = 0;

            switch (comboBox1.Text)
            {
              case "probability of refuse":
                for (int i = (int)numericUpDown8.Value; i <= (int)numericUpDown9.Value; i++)
                {
                  Simulation main = new Simulation(lambda, alpha, beta, i, (int)numericUpDown6.Value, (int)numericUpDown3.Value);
                  var result = main.doAutomaticSimulation();

                  chart1.Series[0].Points.AddXY(i, result.Item1);
                  progressBar1.PerformStep();
                }
                break;

              case "average request in system time":
                for (int i = (int)numericUpDown8.Value; i <= (int)numericUpDown9.Value; i++)
                {
                  Simulation main = new Simulation(lambda, alpha, beta, i, (int)numericUpDown6.Value, (int)numericUpDown3.Value);
                  var result = main.doAutomaticSimulation();

                  chart1.Series[0].Points.AddXY(i, result.Item2);
                  progressBar1.PerformStep();
                }
                break;

              case "devices usage coefficients":
                chart1.Legends.Add("Legend1");
                chart1.Legends[0].Font = chart1.Series[0].Font;
                for (int i = 1; i < (int)numericUpDown6.Value; i++)
                {
                  chart1.Series.Add("D" + (i + 1));
                  chart1.Series[i].ChartType = chart1.Series[0].ChartType;
                  chart1.Series[i].BorderWidth = chart1.Series[0].BorderWidth;
                }

                for (int i = (int)numericUpDown8.Value; i <= (int)numericUpDown9.Value; i++)
                {
                  Simulation main = new Simulation(lambda, alpha, beta, i, (int)numericUpDown6.Value, (int)numericUpDown3.Value);
                  var result = main.doAutomaticSimulation();

                  for (int j = 0; j < chart1.Series.Count; j++)
                  {
                    chart1.Series[j].Points.AddXY(i, result.Item3[j]);
                  }

                  progressBar1.PerformStep();
                }
                break;
            }

            progressBar1.Visible = false;
            break;
        }
      }
      else
      {
        MessageBox.Show("You have to enter constant parameters", "Error", MessageBoxButtons.OK);
      }

    }

    private void InitializeChart()
    {
      chart1.Legends.Clear();
      if (chart1.Series.Count > 1)
      {
        Series series = chart1.Series[0];
        chart1.Series.Clear();
        chart1.Series.Add(series);
      }
      chart1.Series[0].Points.Clear();

      chart1.ChartAreas["ChartArea1"].AxisX.Title = comboBox2.Text;
      chart1.ChartAreas["ChartArea1"].AxisY.Title = comboBox1.Text;
    }

  }
}
