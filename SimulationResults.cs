using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueuingSystemCoursework
{
  internal class SimulationResults
  {
    private double probabilityOfRefuse;
    private double averageRequestInSystemTime;
    private double[] deviceUsageCoefficients;

    public SimulationResults(double probabilityOfRefuse, double averageRequestInSystemTime, double[] deviceUsageCoefficients)
    {
      this.probabilityOfRefuse = probabilityOfRefuse;
      this.averageRequestInSystemTime = averageRequestInSystemTime;
      this.deviceUsageCoefficients = deviceUsageCoefficients;
    }

    public double ProbabilityOfRefuse { get => probabilityOfRefuse; }
    public double AverageRequestInSystemTime { get => averageRequestInSystemTime; }
    public double[] DeviceUsageCoefficients { get => deviceUsageCoefficients; }
  }
}
