using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_2
{
  internal class Student
  {
    private string name;
    private int age;
    private double averageScore;

    public string Name
    {
      get { return name; }
      set { name = value; }
    }

    public int Age
    {
      get { return age; }
      set { age = value; }
    }

    public double AverageScore
    {
      get { return averageScore; }
      set
      {
        if (value >= 0 && value <= 5)
        {
          averageScore = value;
        }
        else
        {
          throw new ArgumentException("Средний балл должен быть в диапазоне от 0 до 5");
        }
      }
    }

    public Student(int age, string name, double averageScore)
    {
      this.age = age;
      this.name = name;
      this.averageScore = averageScore;
    }
  }
}
