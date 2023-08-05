using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ques4
{
    public class Cat : Animal
    {
        public Cat(string name) : base(name)
        {
        }

        public override void SayHello()
        {
            Console.WriteLine($"Hello, I am a Cat named {Name}.");
        }
    }
}
