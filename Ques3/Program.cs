using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ques3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Zoo zoo = new Zoo();

            Animal tom = new Animal("Tom");
            Animal jerry = new Animal("Jerry");
            Animal alice = new Animal("Alice");

            zoo.AddAnimal(tom);
            zoo.AddAnimal(jerry);
            zoo.AddAnimal(alice);

            zoo.AddAnimal(new Animal("Tom")); 

            zoo.RemoveAnimal("Jerry");
            zoo.RemoveAnimal("Mike");

            zoo.SayHello();
            Console.ReadKey();
        }
    }
}
