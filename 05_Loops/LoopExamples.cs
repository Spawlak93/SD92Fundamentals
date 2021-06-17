using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _05_Loops
{
    [TestClass]
    public class LoopExamples
    {
        [TestMethod]
        public void WhileLoop()
        {
            //while loop will repeat code as long as its condition is true
            int total = 1;

            //while (boolean condition)
            //{ body }
            while (total != 10)
            {
                Console.WriteLine(total);
                //total = total + 1;
                //total += 1;
                total++;
            }

            total = 0;
            while (total > 0)
            {
                Console.WriteLine("I am greater than 0");
            }

            while (true)
            {
                if (total == 10)
                {
                    Console.WriteLine("Goal reached");
                    //Breaks out of the loop
                    break;
                }

                total++;

            }

            bool keepLooping = true;
            int counter = 0;
            //Class that generates "random" numbers
            Random rand = new Random();

            while(keepLooping)
            {
                counter = rand.Next(0, 20);

                if (counter == 6 || counter == 12)
                {
                    //continues the loop
                    continue;
                }

                Console.WriteLine(counter);

                //Exit Condition
                if (counter == 17)
                {
                    keepLooping = false;
                }
            }
        }

        [TestMethod]
        public void ForLoops()
        {
            int studentCount = 21;

            //1: for keyword
            //2: starting point
            //3: condition to continue looping
            //4: what we do after each loop
            //5: body(aka what we do during each loop)
            //1   //2       //3               //4
            for (int i = 0; i < studentCount; i++)
            {
                //5
                Console.WriteLine(i);
            }

            string[] student = { "Mark", "Scott", "Randy", "Seth", "Jess" };

            for (int i = 0; i < student.Length; i++)
            {
                Console.WriteLine($"Good Morning {student[i]}");
            }
        }

        [TestMethod]
        public void ForeachLoops()
        {
                        //1
            string[] students = { "Mark", "Scott", "Randy", "Seth", "Jess" };

            //1: Collection to loop through
            //2: foreach keyword
            //3: type in collection
            //4: name of current iteration
            //5: in keyword used to seperate the individual and the collection
            //6: Body
            //2      //3    //4     //5  //1
            foreach (string student in students)
            {
                //6
                Console.WriteLine($"Good Afternoon {student}");
            }

                    //1
            string myName = "Simon Pawlak";
            //2     //3   //4   //5 //1
            foreach(char letter in myName)
            {
                //6
                Console.WriteLine($"|{letter}|");
            }
        }

        [TestMethod]
        public void DoWhile()
        {
            int counter = 0;
            //1: do keyword
            //2: body
            //3: while
            //4: condition to continue looping

            //1
            do
            {
                //2
                Console.WriteLine("Hello");
                counter++;
            }
            //3     //4
            while (counter < 5);

            //1
            do
            {
                //2
                Console.WriteLine("My conditional is false");
            }
            //3     //4
            while (false);

            while(false)
            {
                Console.WriteLine("While loop conditional false");
            }
        }
    }
}
