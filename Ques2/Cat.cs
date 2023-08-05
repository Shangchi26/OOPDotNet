using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ques2
{
    internal class Cat : Animal
    {
        public Cat(string name) : base(name)
        {
        }

        public override void SayHello()
        {
            Console.WriteLine("Meow, my name is " + name);
        }
    }
}
