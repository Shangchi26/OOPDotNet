using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ques2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập tên động vật: ");
            string animalName = Console.ReadLine();
            Animal animal = new Animal(animalName);

            Console.Write("Nhập tên mèo: ");
            string catName = Console.ReadLine();
            Cat cat = new Cat(catName);

            Console.Write("Nhập tên chó: ");
            string dogName = Console.ReadLine();
            Dog dog = new Dog(dogName);       

            animal.SayHello();
            cat.SayHello();
            dog.SayHello();
            Console.ReadKey();

            Animal a = new Animal("Maica"); a.SayHello();
            Dog d = new Dog("Hecules"); d.SayHello();
            Cat c = new Cat("Tom"); c.SayHello();
        }
    }
}
