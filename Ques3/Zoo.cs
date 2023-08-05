using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ques3
{
    internal class Zoo
    {
        private List<Animal> animals;

        public Zoo()
        {
            animals = new List<Animal>();
        }

        public void AddAnimal(Animal animal)
        {
            if (!IsDuplicateName(animal.Name))
            {
                animals.Add(animal);
                Console.WriteLine($"{animal.Name} added to the zoo.");
            }
            else
            {
                Console.WriteLine($"{animal.Name} already exists in the zoo.");
            }
        }

        public void RemoveAnimal(string name)
        {
            Animal animalToRemove = animals.Find(a => a.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
            if (animalToRemove != null)
            {
                animals.Remove(animalToRemove);
                Console.WriteLine($"{name} removed from the zoo.");
            }
            else
            {
                Console.WriteLine($"{name} not found in the zoo.");
            }
        }

        public void SayHello()
        {
            foreach (Animal animal in animals)
            {
                animal.SayHello();
            }
        }

        private bool IsDuplicateName(string name)
        {
            return animals.Exists(a => a.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        }
    }
}
