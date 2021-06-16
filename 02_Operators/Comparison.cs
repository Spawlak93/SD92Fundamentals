using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _02_Operators
{
    [TestClass]
    public class Comparison
    {
        [TestMethod]
        public void ComparisonOperators()
        {
            int year = 2021;
            string name = "Simon";
            //Equal
            bool equals = year == 2021;
            bool isSimon = "Simon" == name;

            //Not Equal
            bool isNot1990 = year != 1990;

            List<string> firstList = new List<string>();
            List<string> secondList = firstList;


            firstList.Add(name);
            secondList.Add(name);

            secondList[0] = "bob";
            //Reference types are tricky
            bool areEqual = firstList == secondList;


            //GreaterThan
            bool greater = year > 2;

            //Greater Than or Equal
            bool greaterOrEqual = year >= 2020;

            //Less Than
            bool less = 2 < 5;

            //Less or Equal
            bool lessOrEqual = 5 <= 5;

            //Or ||

            bool trueValue = true;
            bool falseValue = false;

            bool tOrT = trueValue || trueValue; //True
            bool tOrF = trueValue || falseValue; //True
            bool fOrT = falseValue || trueValue; //True
            bool fOrF = falseValue || falseValue; //False
            //And &&
            bool tandT = trueValue && trueValue; //True
            bool tandF = trueValue && falseValue; //False
            bool fandT = falseValue && trueValue;  //False
            bool fandF = falseValue && falseValue; //False
        }
    }
}
