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

    private int servedRequestsCounter = 0;
    private double startServiceTime;        //время поступения заявки

    private double endServiceTime = 0;          //время ухода из прибора
    private double fullInServiceTime = 0;       //время обработки заявок этим прибором
    private double inServiceTime;         //время, которое нужно на обработку

    private Random random;

    private Statistics statistics;

    public Device(int number, double alpha, double beta, Statistics statistics)
    {
      this.number = number;
      random = new Random();

      this.alpha = alpha;
      this.beta = beta;

      this.statistics = statistics;
    }

    public (string, string, string, string, string, Request[], int?) startServiceStepMode(Request request, double systemTime)
    {
      if (!isFree())
      {
        throw new Exception("Device " + this.Number + " is not empty");
      }

      this.request = request;
      startServiceTime = systemTime;

      inServiceTime = (beta - alpha) * random.NextDouble() + alpha;
      endServiceTime = startServiceTime + inServiceTime;

      return ("D" + this.number.ToString(), systemTime.ToString(), "start service " + request.Number, statistics.ServedRequestsCounter.ToString(),
        statistics.RefusedRequestsCounter.ToString(), null, null);
    }

    public void startServiceAutomaticMode(Request request, double systemTime)
    {
      if (!isFree())
      {
        throw new Exception("Device " + this.Number + " is not empty");
      }

      this.request = request;
      startServiceTime = systemTime;

      inServiceTime = (beta - alpha) * random.NextDouble() + alpha;
      endServiceTime = startServiceTime + inServiceTime;
    }

    public (string, string, string, string, string, Request[], int?) endServiceStepMode(double systemTime)
    {
      fullInServiceTime += inServiceTime;
      statistics.addServedRequest();
      statistics.addRequestsInSystemTime(endServiceTime - request.GenerationTime);
      this.addServedRequest();

      int requestNumber = request.Number;
      request = null;

      return ("D" + this.number.ToString(), systemTime.ToString(), "end service " + requestNumber, statistics.ServedRequestsCounter.ToString(),
        statistics.RefusedRequestsCounter.ToString(), null, null);
    }

    public void endServiceAutomaticMode()
    {
      fullInServiceTime += inServiceTime;
      statistics.addServedRequest();
      statistics.addRequestsInSystemTime(endServiceTime - request.GenerationTime);
      this.addServedRequest();

      request = null;
    }

    public bool isFree()
    {
      return request == null;   //находится ли прибор в простое
    }

    public int Number => number;

    public double FullInServiceTime => fullInServiceTime;

    public int ServedRequestsCounter => servedRequestsCounter;

    private void addServedRequest()
    {
      servedRequestsCounter++;
    }

    public double EndServiceTime => endServiceTime;
  }

}
