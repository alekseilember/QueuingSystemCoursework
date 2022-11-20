using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueuingSystem
{
  internal class Statistics
  {
    private static int generatedRequestsCounter = 0;        //количество сгенерированных заявок
    private static int refusedRequestsCounter = 0;          //количество заявок в отказе
    private static int servedRequestsCounter = 0;          //количество обслуженных заявок
    private static double requestsInSystemTime = 0.0;     //Время нахождения заявок в системе

    public static int GeneratedRequestsCounter => generatedRequestsCounter;

    public static void addGeneratedRequest()
    {
      Statistics.generatedRequestsCounter++;
    }

    public static int RefusedRequestsCounter => refusedRequestsCounter;

    public static void addRefusedRequest()
    {
      Statistics.refusedRequestsCounter++;
    }

    public static double RequestsInSystemTime => requestsInSystemTime;

    public static void addRequestsInSystemTime(double additionalRequestsInSystemTime)
    {
      Statistics.requestsInSystemTime += additionalRequestsInSystemTime;
    }

    public static int ServedRequestsCounter => servedRequestsCounter;

    public static void addServedRequest()
    {
      Statistics.servedRequestsCounter++;
    }

    public static void clear()
    {
      generatedRequestsCounter = 0;
      refusedRequestsCounter = 0;
      servedRequestsCounter = 0;
      requestsInSystemTime = 0.0;
    }
  }
}
