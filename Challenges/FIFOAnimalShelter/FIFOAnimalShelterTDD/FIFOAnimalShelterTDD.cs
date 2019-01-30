using FIFOAnimalShelter.Classes;
using System;
using Xunit;

namespace FIFOAnimalShelterTDD
{
    public class FIFOAnimalShelterTDD
    {
        [Fact]
        public void TestEnqueueInvalidAnimal()
        {
            AnimalShelter shelter = new AnimalShelter();
            shelter.Enqueue(new Animal("Ferret"));
            Assert.Null(shelter.Front);
        }

        [Fact]
        public void TestEnqueue()
        {
            AnimalShelter shelter = new AnimalShelter();
            shelter.Enqueue(new Animal("Cat"));
            Assert.Equal("CAT", shelter.Front.Value);
        }

        [Fact]
        public void TestMultiEnqueue()
        {
            AnimalShelter shelter = new AnimalShelter();
            shelter.Enqueue(new Animal("Dog"));
            shelter.Enqueue(new Animal("Cat"));
            Assert.Equal("CAT", shelter.Rear.Value);
        }

        [Fact]
        public void TestShelterCounter()
        {
            AnimalShelter shelter = new AnimalShelter();
            shelter.Enqueue(new Animal("Dog"));
            shelter.Enqueue(new Animal("Cat"));
            Assert.Equal(2, shelter.Total);
        }

        [Fact]
        public void TestDequeueInvalidAnimal()
        {
            AnimalShelter shelter = new AnimalShelter();
            shelter.Enqueue(new Animal("Dog"));
            shelter.Enqueue(new Animal("Cat"));
            Assert.Null(shelter.Dequeue("ferret").Value);
        }

        [Fact]
        public void TestDequeueMatch()
        {
            AnimalShelter shelter = new AnimalShelter();
            shelter.Enqueue(new Animal("Dog"));
            shelter.Enqueue(new Animal("Cat"));
            Assert.Equal("CAT", shelter.Dequeue("cat").Value);
        }

        [Fact]
        public void TestCountAfterDequeueMatch()
        {
            AnimalShelter shelter = new AnimalShelter();
            shelter.Enqueue(new Animal("Dog"));
            shelter.Enqueue(new Animal("Cat"));
            shelter.Dequeue("cat");
            Assert.Equal(1, shelter.Total);
        }

        [Fact]
        public void TestFrontAfterDequeueMatch()
        {
            AnimalShelter shelter = new AnimalShelter();
            shelter.Enqueue(new Animal("Dog"));
            shelter.Enqueue(new Animal("Cat"));
            shelter.Dequeue("dog");
            Assert.Equal("CAT", shelter.Front.Value);
        }

        [Fact]
        public void TestQueueLoopAfterMatch()
        {
            AnimalShelter shelter = new AnimalShelter();
            shelter.Enqueue(new Animal("Dog"));
            shelter.Enqueue(new Animal("Dog"));
            shelter.Enqueue(new Animal("Dog"));
            shelter.Enqueue(new Animal("Dog"));
            shelter.Enqueue(new Animal("Cat"));
            shelter.Enqueue(new Animal("Cat"));
            shelter.Dequeue("cat");
            Assert.Equal("DOG", shelter.Front.Value);
        }

        [Fact]
        public void TestNoMatch()
        {
            AnimalShelter shelter = new AnimalShelter();
            shelter.Enqueue(new Animal("Dog"));
            shelter.Enqueue(new Animal("Dog"));
            shelter.Enqueue(new Animal("Dog"));
            shelter.Enqueue(new Animal("Dog"));
            shelter.Enqueue(new Animal("Dog"));
            Assert.Null(shelter.Dequeue("cat").Value);
        }
    }
}
