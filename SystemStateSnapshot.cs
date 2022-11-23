using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueuingSystemCoursework
{
  internal class SystemStateSnapshot
  {
    private string systemElement;
    private string time;
    private string action;
    private string servedRequestsCounter;
    private string refusedRequestsCounter;
    private Request[] buffer;
    private int? bufferPointer;

    public SystemStateSnapshot(string systemElement, string time, string action, string servedRequestsCounter, string refusedRequestsCounter,
      Request[] buffer, int? bufferPointer)
    {
      this.systemElement = systemElement;
      this.time = time;
      this.action = action;
      this.servedRequestsCounter = servedRequestsCounter;
      this.refusedRequestsCounter = refusedRequestsCounter;
      this.buffer = buffer;
      this.bufferPointer = bufferPointer;
    }

    public string SystemElement { get => systemElement; }
    public string Time { get => time; }
    public string Action { get => action; }
    internal Request[] Buffer { get => buffer; }
    public int? BufferPointer { get => bufferPointer; }
    public string ServedRequestsCounter { get => servedRequestsCounter; }
    public string RefusedRequestsCounter { get => refusedRequestsCounter; }
  }
}
