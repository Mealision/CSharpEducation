using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes_1
{
  internal class student
  {
    string name;
    int age;

    public student (string name, int age)
    {
      this.name = name;
      this.age = age;
    }

    public void ShowStudent()
    {
      Console.WriteLine($"Name:{name}\nAge:{age}");
    }
  }
}
