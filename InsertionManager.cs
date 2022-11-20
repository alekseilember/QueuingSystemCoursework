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

    public InsertionManager(Request[] buffer)
    {
      this.buffer = buffer;
    }

    public LinkedList<(string, string, string, string, string, Request[], int?)> insertRequestIntoBuffer(Request request, double systemTime)
    {
      LinkedList<(string, string, string, string, string, Request[], int?)> result =
        new LinkedList<(string, string, string, string, string, Request[], int?)>();
      if (buffer[bufferPointer] != null)
      {
        Statistics.addRefusedRequest();
        Statistics.addRequestsInSystemTime(systemTime - buffer[bufferPointer].GenerationTime);
        int requestNumber = buffer[bufferPointer].Number;
        buffer[bufferPointer] = null;

        result.AddLast(("IM", systemTime.ToString(), "refuse " + requestNumber, Statistics.ServedRequestsCounter.ToString(),
        Statistics.RefusedRequestsCounter.ToString(), buffer.ToArray(), bufferPointer));
      }

      buffer[bufferPointer] = request;
      bufferPointer = (bufferPointer + 1) % buffer.Length;

      result.AddLast(("IM", systemTime.ToString(), "insert " + request.Number, Statistics.ServedRequestsCounter.ToString(),
        Statistics.RefusedRequestsCounter.ToString(), buffer.ToArray(), bufferPointer));

      return result;
    }
  }

}
