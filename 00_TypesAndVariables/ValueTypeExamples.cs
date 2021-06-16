using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _00_TypesAndVariables
{
    enum PastryType { Eclaire, Croissant, Danish }

    [TestClass]
    public class ValueTypeExamples
    {
        //Variables hold values
        //Bool
        [TestMethod]
        public void Booleans()
        {
            //Declaration
            bool isDeclared;

            //Assigning value
            isDeclared = true;

            bool declaredAndAssigned = false;
        }
        //Characters
        [TestMethod]
        public void Characters()
        {
            //single quotes for characters
            char character = 'a';
            char symbol = '!';
            char number = '7';
            char space = ' ';
            char specialCaracter = '\'';
        }
        //WholeNumbers
        [TestMethod]
        public void WholeNumbers()
        {
            byte byteExample = 255;
            sbyte signedByteExample = 127;
            short shortExample = 32767;
            Int16 anotherShortExample = -32768;
            int intMax = 2147483647;
            Int32 intMin = -2147483648;
            long longExample = 9223372036854775807;
        }
        //Decimals
        [TestMethod]
        public void Decimals()
        {
            float floatExample = 1000000000000000000.9879879098123123123123123f;
            double doubleExample = 2.123123123123d;
            decimal decimalExample = 3.125345345m;

            Console.WriteLine(1000000000000000000.9879879098123123123123123f);
            Console.WriteLine(1000000000000000000.9879879098123123123123123d);
            Console.WriteLine(1000000000000000000.9879879098123123123123123m);
        }
        //Enums
        [TestMethod]
        public void Enums()
        {
            PastryType myPastry = PastryType.Eclaire;
            PastryType anotherOne = PastryType.Croissant;
            
        }
        //Structs
        //Structs have default Values. 
        [TestMethod]
        public void Structs()
        {
            DateTime today = DateTime.Today;
            DateTime tomorrow = new DateTime(2021,6,16);

        }
    }

}
