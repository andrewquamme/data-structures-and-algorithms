using FIFOAnimalShelter.Classes;
using System;

namespace FIFOAnimalShelter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            FIFOAnimalShelter();
        }

        static void FIFOAnimalShelter()
        {
            AnimalShelter shelter = new AnimalShelter();
            shelter.Enqueue("Cat");
            shelter.Enqueue("Dog");
            Console.WriteLine(shelter.Dequeue("cat").Value);
        }
    }
}
