using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_task_3
{
    internal class Temperature
    {
        public double gradus;

        public double Farenheit(Temperature gradus)
        {
            return this.gradus * 9 / 5 + 32;
        }

        public double Celcius(Farenheit gradus)
        {
            return (gradus.gradus - 32) * 5 / 9;
        }

        public Temperature (double Gradus)
        {
            this.gradus = Gradus;
        }
    }
    
    class Farenheit
    {
        public double gradus;
        public Farenheit(double gradus)
        {
            this.gradus = gradus;
        }
    }

}
