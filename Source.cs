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

    private Statistics statistics;

    public Source(double lambda, Random random, Statistics statistics)
    {
      this.lambda = lambda;
      this.random = random;
      this.statistics = statistics;
    }

    public Request generateRequest()
    {
      lastRequestGenerationTime += Math.Log(1 - random.NextDouble()) / (-lambda);
      statistics.addGeneratedRequest();
      return new Request(lastRequestGenerationTime, statistics.GeneratedRequestsCounter);
    }
  }
}
