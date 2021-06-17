using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Inheritance_Classes
{
    public enum DietType { Herbivore, Omnivore, Canivore }
    public class Animal
    {
        //Constructor
        public Animal()
        {
            Console.WriteLine("This is the Animal constructor");
        }

        //Properties        
        public bool HasFur { get; set; }
        public int NumberOfLegs { get; set; }
        public DietType DietType { get; set; }

        //Method
        public void Breath()
        {
            Console.WriteLine($"this {GetType().Name} takes a breath");
        }

    }
}
