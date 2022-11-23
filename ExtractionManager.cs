using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueuingSystemCoursework
{
  internal class ExtractionManager
  {
    private Request[] buffer;
    private Device[] devices;

    private Statistics statistics;
    public ExtractionManager(Request[] buffer, Device[] devices, Statistics statistics)
    {
      this.buffer = buffer;
      this.devices = devices;
      this.statistics = statistics;
    }

    public LinkedList<(string, string, string, string, string, Request[], int?)> extractRequestAndPassToDeviceStepMode(double systemTime)
    {
      int indexOfEarliestRequest = -1;

      for (int i = 0; i < buffer.Length; i++)
      {
        if (buffer[i] != null && (indexOfEarliestRequest == -1 || buffer[i].GenerationTime < buffer[indexOfEarliestRequest].GenerationTime))
        {
          indexOfEarliestRequest = i;
        }
      }

      if (indexOfEarliestRequest == -1)
      {
        throw new Exception("Buffer is empty");
      }

      LinkedList<(string, string, string, string, string, Request[], int?)> result = new LinkedList<(string, string, string, string, string, Request[], int?)>();

      for (int i = 0; i < devices.Length; i++)
      {
        if (devices[i].isFree())
        {
          Request request = buffer[indexOfEarliestRequest];
          buffer[indexOfEarliestRequest] = null;
          result.AddLast(("EM", systemTime.ToString(), "extract " + request.Number, statistics.ServedRequestsCounter.ToString(),
        statistics.RefusedRequestsCounter.ToString(), buffer, null));

          result.AddLast(devices[i].startServiceStepMode(request, systemTime));
          return result;
        }
      }

      throw new Exception("All devices are not free");
    }

    public void extractRequestAndPassToDeviceAutomaticMode(double systemTime)
    {
      int indexOfEarliestRequest = -1;

      for (int i = 0; i < buffer.Length; i++)
      {
        if (buffer[i] != null && (indexOfEarliestRequest == -1 || buffer[i].GenerationTime < buffer[indexOfEarliestRequest].GenerationTime))
        {
          indexOfEarliestRequest = i;
        }
      }

      if (indexOfEarliestRequest == -1)
      {
        throw new Exception("Buffer is empty");
      }

      for (int i = 0; i < devices.Length; i++)
      {
        if (devices[i].isFree())
        {
          Request request = buffer[indexOfEarliestRequest];
          buffer[indexOfEarliestRequest] = null;

          devices[i].startServiceAutomaticMode(request, systemTime);
          return;
        }
      }

      throw new Exception("All devices are not free");
    }

  }

}
