using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueuingSystemCoursework
{
  internal class Device
  {
    private Request request = null;           //заявка, которая находится на приборе
    private int number;                   //номер прибора

    private double alpha;
    private double beta;

    private double startServiceTime;        //время поступения заявки

    private double endServiceTime = 0;          //время ухода из прибора
    private double fullInServiceTime = 0;       //время обработки заявок этим прибором

    private Random random;

    private Statistics statistics;

    public Device(int number, double alpha, double beta, Random random, Statistics statistics)
    {
      this.number = number;
      this.random = random;

      this.alpha = alpha;
      this.beta = beta;

      this.statistics = statistics;
    }

    public SystemStateSnapshot startServiceStepMode(Request request, double systemTime)
    {
      if (!isFree())
      {
        throw new Exception("Device " + this.Number + " is not empty");
      }

      this.request = request;
      startServiceTime = systemTime;

      endServiceTime = startServiceTime + (beta - alpha) * random.NextDouble() + alpha;

      return new SystemStateSnapshot("D" + this.number.ToString(), systemTime.ToString(), "start service " + request.Number,
        statistics.ServedRequestsCounter.ToString(), statistics.RefusedRequestsCounter.ToString(), null, null);
    }

    public void startServiceAutomaticMode(Request request, double systemTime)
    {
      if (!isFree())
      {
        throw new Exception("Device " + this.Number + " is not empty");
      }

      this.request = request;
      startServiceTime = systemTime;

      endServiceTime = startServiceTime + (beta - alpha) * random.NextDouble() + alpha;
    }

    public SystemStateSnapshot endServiceStepMode(double systemTime)
    {
      fullInServiceTime += endServiceTime - startServiceTime;
      statistics.addServedRequest();
      statistics.addRequestsInSystemTime(endServiceTime - request.GenerationTime);

      int requestNumber = request.Number;
      request = null;

      return new SystemStateSnapshot("D" + this.number.ToString(), systemTime.ToString(), "end service " + requestNumber, statistics.ServedRequestsCounter.ToString(),
        statistics.RefusedRequestsCounter.ToString(), null, null);
    }

    public void endServiceAutomaticMode()
    {
      fullInServiceTime += endServiceTime - startServiceTime;
      statistics.addServedRequest();
      statistics.addRequestsInSystemTime(endServiceTime - request.GenerationTime);

      request = null;
    }

    public bool isFree()
    {
      return request == null;   //находится ли прибор в простое
    }

    public int Number => number;

    public double FullInServiceTime => fullInServiceTime;

    public double EndServiceTime => endServiceTime;
  }

}
