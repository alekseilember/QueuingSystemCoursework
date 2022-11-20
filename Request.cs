using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueuingSystemCoursework
{
  internal class Request
  {
    private double generationTime; //время гинерации заявки
    private int number; //номер заявки

    public Request(double generationTime, int number)
    {
      this.generationTime = generationTime;
      this.number = number;
    }

    public double GenerationTime => generationTime;

    public int Number => number;
  }
}
