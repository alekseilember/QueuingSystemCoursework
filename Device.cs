using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueuingSystem
{
  internal class Device
  {
    private Request request = null;           //заявка, которая находится на приборе
    private int number;                   //номер прибора

    private int servedRequestsCounter = 0;
    private double startServiceTime;        //время поступения заявки

    private double endServiceTime = 0;          //время ухода из прибора
    private double fullInServiceTime = 0;       //время обработки заявок этим прибором
    private double inServiceTime;         //время, которое нужно на обработку

    private Random random;

    public Device(int number)
    {
      this.number = number;
      random = new Random();
    }

    public (string, string, string, string, string, Request[], int?) startService(Request request, double systemTime, double alpha, double beta)
    {
      if (!isFree())
      {
        throw new Exception("Device " + this.Number + " is not empty");
      }

      this.request = request;
      startServiceTime = systemTime;

      inServiceTime = (beta - alpha) * random.NextDouble() + alpha;
      endServiceTime = startServiceTime + inServiceTime;

      return ("D" + this.number.ToString(), systemTime.ToString(), "start service " + request.Number, Statistics.ServedRequestsCounter.ToString(),
        Statistics.RefusedRequestsCounter.ToString(), null, null);
    }

    public (string, string, string, string, string, Request[], int?) endService(double systemTime)
    {
      fullInServiceTime += inServiceTime;
      Statistics.addServedRequest();
      Statistics.addRequestsInSystemTime(endServiceTime - request.GenerationTime);
      this.addServedRequest();

      int requestNumber = request.Number;
      request = null;

      return ("D" + this.number.ToString(), systemTime.ToString(), "end service " + requestNumber, Statistics.ServedRequestsCounter.ToString(),
        Statistics.RefusedRequestsCounter.ToString(), null, null);
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
