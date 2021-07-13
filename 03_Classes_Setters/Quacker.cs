using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Classes_Setters
{
    public class Quacker
    {

        //UserName must contain at least 5 characters.
        //Users must be at least 16.
        public Quacker(string userName, int age)
        {
            UserName = userName;
            Age = age;
        }

        private string _userName; //Backing Field
        public string UserName
        {
            get //Get method return values
            {
                return _userName;
            }
            set //Set Method
            {
                if (value.Length >= 5)
                {
                    _userName = value;
                }
                else
                    throw new FormatException("UserName must be at least five characters long");
            }
        }

        //Users must be at least 16.
        private int _age;
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if(value >= 16)
                {
                    _age = value;
                }
                else
                    throw new ArgumentException("Age must be at least 16");
            }
        }
    }
}
