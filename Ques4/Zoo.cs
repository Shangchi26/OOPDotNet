using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ques4
{
    public class Zoo
    {
        private List<Animal> animals;

        public Zoo()
        {
            animals = new List<Animal>();
        }

        public void Add(Animal animal)
        {
            animals.Add(animal);
        }

        public void SayHello()
        {
            foreach (var animal in animals)
            {
                animal.SayHello();
            }
        }
    }

}
