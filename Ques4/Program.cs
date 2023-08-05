using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ques4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Zoo zoo = new Zoo();
            int choice;

            do
            {
                Console.WriteLine("Bạn muốn nhập con vật loại nào?");
                Console.WriteLine("1. Animal");
                Console.WriteLine("2. Dog");
                Console.WriteLine("3. Cat");
                Console.WriteLine("0. Thoát và hiển thị danh sách con vật đã nhập");
                Console.Write("Lựa chọn của bạn: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Nhập tên của Animal: ");
                        string animalName = Console.ReadLine();
                        Animal animal = new Animal(animalName);
                        zoo.Add(animal);
                        break;
                    case 2:
                        Console.Write("Nhập tên của Dog: ");
                        string dogName = Console.ReadLine();
                        Dog dog = new Dog(dogName);
                        zoo.Add(dog);
                        break;
                    case 3:
                        Console.Write("Nhập tên của Cat: ");
                        string catName = Console.ReadLine();
                        Cat cat = new Cat(catName);
                        zoo.Add(cat);
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ.");
                        break;
                }
            } while (choice != 0);

            Console.WriteLine("Danh sách con vật trong zoo:");
            zoo.SayHello();
            Console.ReadKey();
        }
    }
}
