using System;
using System.Collections.Generic;
using System.Linq;

namespace QueuingSystemCoursework
{
  internal class Simulation
  {
    private double systemTime;

    private int bufferElementsCounter;

    private bool isInitialized;
    private bool isSimulationDone;
    private Statistics statistics;
    private Random random;

    private Source source;
    private LinkedList<Request> requestList;
    private Request[] buffer;
    private InsertionManager insertionManager;
    private ExtractionManager extractionManager;
    private Device[] devices;

    public Simulation()
    {
      this.isInitialized = false;
    }

    public void Init(double lambda, double alpha, double beta, int bufferLength, int amountOfDevices, int amountOfRequests)
    {
      this.isSimulationDone = false;
      this.systemTime = 0;
      this.statistics = new Statistics();
      this.random = new Random();

      this.source = new Source(lambda, random, statistics);
      this.buffer = new Request[bufferLength];
      this.bufferElementsCounter = 0;

      requestList = new LinkedList<Request>();
      for (int i = 0; i < amountOfRequests; i++)
      {
        requestList.AddLast(source.generateRequest());
      }

      this.devices = new Device[amountOfDevices];
      for (int i = 0; i < amountOfDevices; i++)
      {
        devices[i] = (new Device(i + 1, alpha, beta, random, statistics));
      }

      this.insertionManager = new InsertionManager(buffer, statistics);
      this.extractionManager = new ExtractionManager(buffer, devices, statistics);

      this.isInitialized = true;
    }

    public LinkedList<(string, string, string, string, string, Request[], int?)> NextStep()
    {
      if (!isInitialized)
      {
        throw new Exception("Simulation is not initialized");
      }

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
            LinkedList<(string, string, string, string, string, Request[], int?)> list = extractionManager.extractRequestAndPassToDeviceStepMode(systemTime);
            result.AddLast(list.ElementAt(0));
            result.AddLast(list.ElementAt(1));
            bufferElementsCounter--;
          }
        }
        else
        {
          int oldRefusedRequestsCounter = statistics.RefusedRequestsCounter;
          systemTime = requestList.ElementAt(0).GenerationTime;
          LinkedList<(string, string, string, string, string, Request[], int?)> list = insertionManager.insertRequestIntoBufferStepMode(requestList.ElementAt(0), systemTime);
          result.AddLast(list.ElementAt(0));

          if (statistics.RefusedRequestsCounter == oldRefusedRequestsCounter)
          {
            bufferElementsCounter++;
          }
          else
          {
            result.AddLast(list.ElementAt(1));
          }

          if (!isAllDevicesBusy)
          {
            list = extractionManager.extractRequestAndPassToDeviceStepMode(systemTime);
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
      if (!isInitialized)
      {
        throw new Exception("Simulation is not initialized");
      }

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
          devices[earliestDeviceEndServiceTimeIndex].endServiceAutomaticMode();
          if (bufferElementsCounter > 0)
          {
            extractionManager.extractRequestAndPassToDeviceAutomaticMode(systemTime);
            bufferElementsCounter--;
          }
        }
        else
        {
          int oldRefusedRequestsCounter = statistics.RefusedRequestsCounter;
          systemTime = requestList.ElementAt(0).GenerationTime;
          insertionManager.insertRequestIntoBufferAutomaticMode(requestList.ElementAt(0), systemTime);

          if (statistics.RefusedRequestsCounter == oldRefusedRequestsCounter)
          {
            bufferElementsCounter++;
          }

          if (!isAllDevicesBusy)
          {
            extractionManager.extractRequestAndPassToDeviceAutomaticMode(systemTime);
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
      return ((double)statistics.RefusedRequestsCounter / statistics.GeneratedRequestsCounter,
        statistics.RequestsInSystemTime / statistics.GeneratedRequestsCounter, deviceUsageCoefficients);
    }
  }
}
