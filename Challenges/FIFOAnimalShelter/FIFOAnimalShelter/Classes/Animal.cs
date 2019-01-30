using System;
using System.Collections.Generic;
using System.Text;

namespace FIFOAnimalShelter.Classes
{
    public class Animal
    {
        public string Value { get; set; }
        public Animal Next { get; set; }

        /// <summary>
        /// Creates new animal with Value
        /// </summary>
        /// <param name="value">animal</param>
        public Animal(string animal)
        {
            if (animal != null) animal = animal.ToUpper();
            Value = animal;
            
        }
    }
}
