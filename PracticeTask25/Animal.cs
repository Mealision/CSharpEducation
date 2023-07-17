using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeTask25
{
    internal class Animal
    {

        public string Name { get; }
        public string Age { get; }
        public string Species { get; }
        public string AnimalColor { get; }
        public string Sound { get; }

        public Animal(string name, string age, string species, string animalColor, string sound)
        {
            Name = name;
            Age = age;
            Species = species;
            AnimalColor = animalColor;
            Sound = sound;
        }
    }
}
