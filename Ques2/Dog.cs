using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Ques2
{
    internal class Dog : Animal
    {
        public Dog(string name) : base(name)
        {
        }

        public override void SayHello()
        {
            Console.WriteLine("Woof, woof, my name is " + name);
        }
    }
}
