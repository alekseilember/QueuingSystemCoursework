using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueuingSystemCoursework
{
  internal class MainStepMode
  {
    private double systemTime = 0;

    private double lambda;
    private double alpha;
    private double beta;
    private int bufferLength;

    private int bufferElementsCounter = 0;
    private int amountOfDevices;
    private int amountOfRequests;

    private bool isSimulationDone = false;

    private Source source;
    private LinkedList<Request> requestList;
    private Request[] buffer;
    private InsertionManager insertionManager;
    private ExtractionManager extractionManager;
    private Device[] devices;

    public int BufferLength { get => bufferLength; }

    public MainStepMode(double lambda, double alpha, double beta, int bufferLength, int amountOfDevices, int amountOfRequests)
    {
      Statistics.clear();

      this.lambda = lambda;
      this.alpha = alpha;
      this.beta = beta;
      this.bufferLength = bufferLength;
      this.amountOfDevices = amountOfDevices;
      this.amountOfRequests = amountOfRequests;

      this.source = new Source(lambda);
      this.buffer = new Request[bufferLength];

      requestList = new LinkedList<Request>();
      for (int i = 0; i < amountOfRequests; i++)
      {
        requestList.AddLast(source.generateRequest());
      }

      this.devices = new Device[amountOfDevices];
      for (int i = 0; i < amountOfDevices; i++)
      {
        devices[i] = (new Device(i + 1));
      }

      this.insertionManager = new InsertionManager(buffer);
      this.extractionManager = new ExtractionManager(buffer, devices);
    }

    public LinkedList<(string, string, string, string, string, Request[], int?)> NextStep()
    {
      LinkedList<(string, string, string, string, string, Request[], int?)> result =
        new LinkedList<(string, string, string, string, string, Request[], int?)>();

      if (!isSimulationDone)
      {
        bool isAllDevicesFree = true;
        bool isAllDevicesBusy = true;
        int earliestDeviceEndServiceTimeIndex = -1;

        //Проверяем приборы
        for (int i = 0; i < devices.Length; i++)
        {
          if (!devices[i].isFree())
          {
            isAllDevicesFree = false;
            if (earliestDeviceEndServiceTimeIndex == -1 || devices[earliestDeviceEndServiceTimeIndex].EndServiceTime > devices[i].EndServiceTime)
            {
              earliestDeviceEndServiceTimeIndex = i;
            }
          }
          else
          {
            isAllDevicesBusy = false;
          }
        }

        //Условие окончания симуляции
        if (isAllDevicesFree && requestList.Count == 0)
        {
          isSimulationDone = true;
          return result;
        }

        //Если не все приборы свободны и освождение одного из приборов наступит раньше, чем придёт следующая заявка
        if (!isAllDevicesFree && (requestList.Count == 0 || devices[earliestDeviceEndServiceTimeIndex].EndServiceTime < requestList.ElementAt(0).GenerationTime))
        {
          systemTime = devices[earliestDeviceEndServiceTimeIndex].EndServiceTime;
          result.AddLast(devices[earliestDeviceEndServiceTimeIndex].endServiceStepMode(systemTime));
          if (bufferElementsCounter > 0)
          {
            LinkedList<(string, string, string, string, string, Request[], int?)> list = extractionManager.extractRequestAndPassToDeviceStepMode(systemTime, alpha, beta);
            result.AddLast(list.ElementAt(0));
            result.AddLast(list.ElementAt(1));
            bufferElementsCounter--;
          }
        }
        else
        {
          int oldRefusedRequestsCounter = Statistics.RefusedRequestsCounter;
          systemTime = requestList.ElementAt(0).GenerationTime;
          LinkedList<(string, string, string, string, string, Request[], int?)> list = insertionManager.insertRequestIntoBufferStepMode(requestList.ElementAt(0), systemTime);
          result.AddLast(list.ElementAt(0));

          if (Statistics.RefusedRequestsCounter == oldRefusedRequestsCounter)
          {
            bufferElementsCounter++;
          }
          else
          {
            result.AddLast(list.ElementAt(1));
          }

          if (!isAllDevicesBusy)
          {
            list = extractionManager.extractRequestAndPassToDeviceStepMode(systemTime, alpha, beta);
            result.AddLast(list.ElementAt(0));
            result.AddLast(list.ElementAt(1));
            bufferElementsCounter--;
          }

          requestList.RemoveFirst();
        }
      }

      return result;
    }

    public (double, double, double[]) doAutomaticSimulation()
    {
      while (!isSimulationDone)
      {
        bool isAllDevicesFree = true;
        bool isAllDevicesBusy = true;
        int earliestDeviceEndServiceTimeIndex = -1;

        //Проверяем приборы
        for (int i = 0; i < devices.Length; i++)
        {
          if (!devices[i].isFree())
          {
            isAllDevicesFree = false;
            if (earliestDeviceEndServiceTimeIndex == -1 || devices[earliestDeviceEndServiceTimeIndex].EndServiceTime > devices[i].EndServiceTime)
            {
              earliestDeviceEndServiceTimeIndex = i;
            }
          }
          else
          {
            isAllDevicesBusy = false;
          }
        }

        //Условие окончания симуляции
        if (isAllDevicesFree && requestList.Count == 0)
        {
          isSimulationDone = true;
          continue;
        }

        //Если не все приборы свободны и освождение одного из приборов наступит раньше, чем придёт следующая заявка
        if (!isAllDevicesFree && (requestList.Count == 0 || devices[earliestDeviceEndServiceTimeIndex].EndServiceTime < requestList.ElementAt(0).GenerationTime))
        {
          systemTime = devices[earliestDeviceEndServiceTimeIndex].EndServiceTime;
          devices[earliestDeviceEndServiceTimeIndex].endServiceAutomaticMode(systemTime);
          if (bufferElementsCounter > 0)
          {
            extractionManager.extractRequestAndPassToDeviceAutomaticMode(systemTime, alpha, beta);
            bufferElementsCounter--;
          }
        }
        else
        {
          int oldRefusedRequestsCounter = Statistics.RefusedRequestsCounter;
          systemTime = requestList.ElementAt(0).GenerationTime;
          insertionManager.insertRequestIntoBufferAutomaticMode(requestList.ElementAt(0), systemTime);

          if (Statistics.RefusedRequestsCounter == oldRefusedRequestsCounter)
          {
            bufferElementsCounter++;
          }

          if (!isAllDevicesBusy)
          {
            extractionManager.extractRequestAndPassToDeviceAutomaticMode(systemTime, alpha, beta);
            bufferElementsCounter--;
          }

          requestList.RemoveFirst();
        }
      }

      double[] deviceUsageCoefficients = new double[devices.Length];
      for (int i = 0; i < devices.Length; i++)
      {
        deviceUsageCoefficients[i] = devices[i].FullInServiceTime / systemTime;
      }

      // Probability of refuse, average request in system time, average device usage coefficient
      return ((double)Statistics.RefusedRequestsCounter / Statistics.GeneratedRequestsCounter,
        Statistics.RequestsInSystemTime / Statistics.GeneratedRequestsCounter, deviceUsageCoefficients);
    }
  }
}
