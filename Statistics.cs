using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueuingSystemCoursework
{
  internal class Statistics
  {
    private int generatedRequestsCounter;        //количество сгенерированных заявок
    private int refusedRequestsCounter;          //количество заявок в отказе
    private int servedRequestsCounter;          //количество обслуженных заявок
    private double requestsInSystemTime;     //Время нахождения заявок в системе

    public Statistics()
    {
      clear();
    }

    public int GeneratedRequestsCounter => generatedRequestsCounter;

    public void addGeneratedRequest()
    {
      generatedRequestsCounter++;
    }

    public int RefusedRequestsCounter => refusedRequestsCounter;

    public void addRefusedRequest()
    {
      refusedRequestsCounter++;
    }

    public double RequestsInSystemTime => requestsInSystemTime;

    public void addRequestsInSystemTime(double additionalRequestsInSystemTime)
    {
      requestsInSystemTime += additionalRequestsInSystemTime;
    }

    public int ServedRequestsCounter => servedRequestsCounter;

    public void addServedRequest()
    {
      servedRequestsCounter++;
    }

    public void clear()
    {
      generatedRequestsCounter = 0;
      refusedRequestsCounter = 0;
      servedRequestsCounter = 0;
      requestsInSystemTime = 0.0;
    }
  }
}
