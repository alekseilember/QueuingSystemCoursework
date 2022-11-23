using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueuingSystemCoursework
{
  internal class InsertionManager
  {
    private Request[] buffer;
    private int bufferPointer = 0;

    Statistics statistics;
    public InsertionManager(Request[] buffer, Statistics statistics)
    {
      this.buffer = buffer;
      this.statistics = statistics;
    }

    public LinkedList<(string, string, string, string, string, Request[], int?)> insertRequestIntoBufferStepMode(Request request, double systemTime)
    {
      LinkedList<(string, string, string, string, string, Request[], int?)> result =
        new LinkedList<(string, string, string, string, string, Request[], int?)>();
      if (buffer[bufferPointer] != null)
      {
        statistics.addRefusedRequest();
        statistics.addRequestsInSystemTime(systemTime - buffer[bufferPointer].GenerationTime);
        int requestNumber = buffer[bufferPointer].Number;
        buffer[bufferPointer] = null;

        result.AddLast(("IM", systemTime.ToString(), "refuse " + requestNumber, statistics.ServedRequestsCounter.ToString(),
        statistics.RefusedRequestsCounter.ToString(), buffer.ToArray(), bufferPointer));
      }

      buffer[bufferPointer] = request;
      bufferPointer = (bufferPointer + 1) % buffer.Length;

      result.AddLast(("IM", systemTime.ToString(), "insert " + request.Number, statistics.ServedRequestsCounter.ToString(),
        statistics.RefusedRequestsCounter.ToString(), buffer.ToArray(), bufferPointer));

      return result;
    }

    public void insertRequestIntoBufferAutomaticMode(Request request, double systemTime)
    {
      if (buffer[bufferPointer] != null)
      {
        statistics.addRefusedRequest();
        statistics.addRequestsInSystemTime(systemTime - buffer[bufferPointer].GenerationTime);
      }

      buffer[bufferPointer] = request;
      bufferPointer = (bufferPointer + 1) % buffer.Length;
    }
  }

}
