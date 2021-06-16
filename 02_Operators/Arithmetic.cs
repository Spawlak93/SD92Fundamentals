using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _02_Operators
{
    [TestClass]
    public class Arithmetic
    {
        [TestMethod]
        public void SimpleOperators()
        {
            int a = 5;
            int b = 32;

            //Addition: +

            int sum = a + b; //37

            // Multiplication *
            int product = a * b; //160

            // Division: /
            int qoutient = b / a; //6

            // Remainder: %
            // modulus
            int remainder = b % a; //2

            DateTime now = DateTime.Now;
            DateTime then = new DateTime(2000, 07, 12);

            TimeSpan timeSpan = now - then;

            char seven = '7';
            int test = seven / 7;

            byte exampleByte = 255;
        }
    }
}
