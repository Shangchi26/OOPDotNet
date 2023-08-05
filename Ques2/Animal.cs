using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ques2
{
    public class Animal
    {
        protected string name;

        public Animal(string name)
        {
            this.name = name;
        }

        public virtual void SayHello()
        {
            Console.WriteLine("Whereas " + name + " is the name of that animal");
        }
    }
}
