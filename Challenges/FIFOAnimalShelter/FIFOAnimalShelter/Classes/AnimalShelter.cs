using System;
using System.Collections.Generic;
using System.Text;

namespace FIFOAnimalShelter.Classes
{
    public class AnimalShelter
    {
        public Animal Front { get; set; }
        public Animal Rear { get; set; }
        public int Total { get; set; }

        public AnimalShelter()
        {
            Front = null;
        }

        /// <summary>
        /// Adds new animal to the Animal Shelter queue
        /// </summary>
        /// <param name="animalType">CAT or DOG</param>
        public void Enqueue(string animalType)
        {
            animalType = animalType.ToUpper();
            if (animalType == "CAT" || animalType == "DOG")
            {
                Animal animal = new Animal(animalType);
                Total++;
                if (Front == null)
                {
                    Front = animal;
                    Rear = animal;
                }
                else
                {
                    Rear.Next = animal;
                    Rear = animal;
                }
            }
            else
            {
                Console.WriteLine("Sorry, this shelter only accomodates cats and dogs");
            }
        }

        /// <summary>
        /// Searches Animal Shelter for preferred animal
        /// Returns animal if found, oldest animal if not
        /// </summary>
        /// <param name="pref">CAT or DOG</param>
        /// <returns>new pet</returns>
        public Animal Dequeue(string pref)
        {
            Animal pet = new Animal(null);
            pref = pref.ToUpper();
            int count = 0;
            bool match = false;

            //Only cats and dogs allowed (or no preference)
            if (pref != "CAT" && pref != "DOG" && pref !="")
            {
                Console.WriteLine("Sorry, we only have cats and dogs available");
                return pet;
            }

            while (count < Total)
            {
                count++;
                //take front animal and make a temp animal
                Animal temp = new Animal(Front.Value);
                temp.Next = null;
                Front = Front.Next;

                //If animal is a match OR no preference in animal
                //and there has been no match already. If no preference,
                //this will return the oldest animal in the shelter
                if((pref == "" || temp.Value == pref) && !match)
                {
                    pet = temp;
                    match = true;
                    Total--;
                }
                else //put temp animal back into queue
                {
                    Rear.Next = temp;
                }
            }

            //return new pet
            return pet;
        }
    }
}
