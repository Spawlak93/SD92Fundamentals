using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Classes
{
    public class Person
    {
        //Field


        //Constructor
        public Person() { }
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }


        //Properties
        //FirstName, LastName, FullName, Haircolor, ShoeSize, Age, DateOfBirth, ID
        //Getter and Setter: Get and Set Methods
        public int Id { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FullName
        {
            get
            {
                string fullName = FirstName + " " + LastName;
                return fullName;
            }
        }
        public string HairColor { get; set; }
        public int ShoeSize { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Age { get; set; }


        //Methods
    }
}
