using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_task_2
{
    internal class Animal
    {
        virtual public string MakeSound()
        {
            return "sound";
        }
    }
    internal class Dog : Animal
    {
        public override string MakeSound()
        {
            return "bark";
        }
    }

    internal class Cat : Animal
    {
        public override string MakeSound()
        {
            return "Meow";
        }
    }

}
