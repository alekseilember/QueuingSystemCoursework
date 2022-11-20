using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueuingSystemCoursework
{
  internal class Source
  {
    private double lastRequestGenerationTime = 0.0;
    private Random random;
    private double lambda;

    public Source(double lambda)
    {
      this.lambda = lambda;
      this.random = new Random();
    }

    public Request generateRequest()
    {
      lastRequestGenerationTime += Math.Log(1 - random.NextDouble()) / (-lambda);
      Statistics.addGeneratedRequest();
      return new Request(lastRequestGenerationTime, Statistics.GeneratedRequestsCounter);
    }
  }
}
