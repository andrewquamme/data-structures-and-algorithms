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
            shelter.Enqueue("Dog");
            shelter.Enqueue("Dog");
            shelter.Enqueue("Dog");
            shelter.Enqueue("Dog");
            shelter.Enqueue("Cat");
            shelter.Enqueue("Cat");
            Console.WriteLine(shelter.Dequeue("cat").Value);
            Console.WriteLine(shelter.Dequeue("cat").Value);
            Console.WriteLine(shelter.Dequeue("cat").Value);
            Console.WriteLine(shelter.Dequeue("dog").Value);
            Console.WriteLine(shelter.Dequeue("dog").Value);
            Console.WriteLine(shelter.Dequeue("dog").Value);
            Console.WriteLine(shelter.Dequeue("dog").Value);
            Console.WriteLine(shelter.Dequeue("dog").Value);
        }
    }
}
