using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _04_Conditionals
{
    [TestClass]
    public class Ternary
    {
        [TestMethod]
        public void Ternaries()
        {
            //Ternary Structure
            //(Condition/Boolean) ? trueResult : falseResult;
            int age = 42;

            bool isAdult = (age >= 18) ? true : false;
            string isAdultResult = (age >= 18) ? "Is an Adult" : "Is not Adult";

            int numOne = 10;
            int numTwo = (numOne != 10) ? 30 : 20;
        }
    }
}
