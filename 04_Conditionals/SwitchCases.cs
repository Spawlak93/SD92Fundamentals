using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _04_Conditionals
{
    [TestClass]
    public class SwitchCases
    {
        [TestMethod]
        public void SwitchCase()
        {
            //Structure of SwitchCase
            //1: switch Keyword
            //2: Value evaulating
            //3: cases
            //4: Breaking Out

            int input = 1;

            //1     //2
            switch (input)
            {
                //3
                case 1:
                    Console.WriteLine("Hello");
                    //4
                    break;
                //3
                case 2:
                    Console.WriteLine("That is number Two");
                    //4
                    break;
                //3
                default:
                    Console.WriteLine("This is the default option");
                    //4
                    break;
            }

            DayOfWeek today = DayOfWeek.Wednesday;
            //1     //2
            switch (today)
            {
                //3
                case DayOfWeek.Monday:
                case DayOfWeek.Tuesday:
                case DayOfWeek.Wednesday:
                case DayOfWeek.Thursday:
                    Console.WriteLine("open 10AM - 9PM");
                    //4
                    break;
                //3
                case DayOfWeek.Friday:
                case DayOfWeek.Saturday:
                    Console.WriteLine("Open 10AM - 2AM");
                    //4
                    break;
                //3
                case DayOfWeek.Sunday:
                    Console.WriteLine("2PM-3PM");
                    //4
                    break;
            }

            if(today == DayOfWeek.Monday || today == DayOfWeek.Tuesday || today == DayOfWeek.Wednesday || today == DayOfWeek.Thursday)
            {
                Console.WriteLine("open 10AM - 9PM");
            }
        }
    }
}
