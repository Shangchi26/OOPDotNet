using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ques1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int a, b, c;

            do
            {
                a = GetPositiveInput("Nhập độ dài cạnh thứ nhất của tam giác thường: ");
                b = GetPositiveInput("Nhập độ dài cạnh thứ hai của tam giác thường: ");
                c = GetPositiveInput("Nhập độ dài cạnh thứ ba của tam giác thường: ");
            } while (a + b <= c || a + c <= b || b + c <= a);

            Triangle triangle = new Triangle(a, b, c);

            int sideLength;
            do
            {
                sideLength = GetPositiveInput("Nhập độ dài cạnh của tam giác đều: ");
            } while (sideLength <= 0);

            ETriangle etriangle = new ETriangle(sideLength);

            Console.WriteLine("Chu vi của Tam giác: " + triangle.Perimeter());
            Console.WriteLine("Diện tích của Tam giác: " + triangle.Area());

            Console.WriteLine("Chu vi của Tam giác đều: " + etriangle.Perimeter());
            Console.WriteLine("Diện tích của Tam giác đều: " + etriangle.Area());

            Console.ReadKey();
        }
        static int GetPositiveInput(string prompt)
        {
            int value;
            do
            {
                Console.Write(prompt);
            } while (!int.TryParse(Console.ReadLine(), out value) || value <= 0);
            return value;
        }
    }
}
