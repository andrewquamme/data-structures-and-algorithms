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
        /// <param name="value">CAT or DOG</param>
        public Animal(string value)
        {
            if (value != null) Value = value.ToUpper();
            else Value = value;
        }
    }
}
