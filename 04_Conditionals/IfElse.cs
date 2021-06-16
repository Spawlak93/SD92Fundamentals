using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _04_Conditionals
{
    [TestClass]
    public class IfElse
    {
        [TestMethod]
        public void IfStatements()
        {
            bool userIsHungry = false;
            //evaluates this bool
            if (userIsHungry)
            {
                Console.WriteLine("Go Eat Food");
            }

            int hoursSpentStudying = 40;

            if (hoursSpentStudying < 36)
            {
                Console.WriteLine("Do More");
            }
        }

        [TestMethod]
        public void IfElseStatements()
        {
            bool choresAreDone = true;
            if (choresAreDone)
            {
                Console.WriteLine("Go enjoy a relaxing nap");
            }

            else
            {
                Console.WriteLine("Go do those dishes");
            }
            //Psudo user input
            string input = "10";
            //Converting string to int
            int sleepingHours = int.Parse(input);

            if (sleepingHours > 8)
            {
                Console.WriteLine("You should be well rested");

                if(sleepingHours > 24)
                {

                }
            }
            else if (sleepingHours > 6)
            {
                Console.WriteLine("You might be tired today");
            }
            else if (sleepingHours > 4)
            {
                Console.WriteLine("You should get more sleep");
            }
            else
            {
                Console.WriteLine("Hope you get more sleep soon");

                if (sleepingHours < -3)
                {
                    Console.WriteLine("Stephon Go To BED!!!!");
                }
            }
        }
    }
}

