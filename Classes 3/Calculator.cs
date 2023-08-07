using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_3
{
  internal class Calculator
  {
    public double a;
    public double b;

    public Calculator(double a, double b)
    {
      this.a = a;
      this.b = b;
    }

    public double Add()
    {
      return a + b;
    }
    public double Subtract() {  return a - b; }
    public double Multiply() { return a * b; }
    public double Divide() { return a / b; }
  }
}
