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
            shelter.Enqueue(new Animal("Dog"));
            shelter.Enqueue(new Animal("Dog"));
            shelter.Enqueue(new Animal("Dog"));
            shelter.Enqueue(new Animal("Dog"));
            shelter.Enqueue(new Animal("Cat"));
            shelter.Enqueue(new Animal("Cat"));
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
