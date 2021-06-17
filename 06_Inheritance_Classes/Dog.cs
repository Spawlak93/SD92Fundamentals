using _03_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Inheritance_Classes
{
    public class Dog : Animal
    {
        public Dog()
        {
            Console.WriteLine("This is my Dog Constructor");
            NumberOfLegs = 4;
            DietType = DietType.Omnivore;
        }

        public double ToothLength { get; set; }

        public virtual void MakeSound()
        {
            Console.WriteLine("Woof");
        }

    }

    public class Chihuahua : Dog
    {
        public Chihuahua()
        {
            Console.WriteLine("This makes a Chihuahua");
        }

        public Person Owner { get; set; }
        public override void MakeSound()
        {
            Console.WriteLine("yip yip");
        }

        

    }

    public class Wolf : Dog 
    {
        public Wolf()
        {
            Console.WriteLine("This makes a Wolf");
        }

        public override void MakeSound()
        {
            Console.WriteLine("Howl");
        }
    }
}
