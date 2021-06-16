using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _01_ReferenceTypes
{
    [TestClass]
    public class ReferenceTypeExamples
    {
        [TestMethod]
        public void Strings()
        {
            string thisIsAStringDeclaration;

            thisIsAStringDeclaration = "Hello World";

            string declaredAndInitialized = "Hello Peoples";

            //Manipulation of string
            string firstName = "Simon";
            string lastName = "Pawlak";

            //Concatination
            string concatinatedName = firstName + " " + lastName;
            //Composite
            string compositeName = string.Format("{0} {1}", firstName, lastName);
            //Interpolation
            string interpolatedName = $"{firstName} {lastName}";

            Console.WriteLine(firstName);
            Console.WriteLine(lastName);
            Console.WriteLine(concatinatedName);
            Console.WriteLine(compositeName);
            Console.WriteLine(interpolatedName);
        }

        [TestMethod]
        public void Collections()
        {
            string stringExample = "Hi";
            //Array
            string[] stringArray = { "Hello", "World", "Pickles", stringExample };

            string secondItem = stringArray[1];

            int[] intArray = new int[4];
            int firstItem = intArray[0];

            //List
            List<string> listOfStrings = new List<string>();

            listOfStrings.Add("First string in list");

            Console.WriteLine(listOfStrings[0]);

            //Queue
            //First In First Out
            Queue<string> queueOfStrings = new Queue<string>();
            queueOfStrings.Enqueue("first");
            queueOfStrings.Enqueue("second");

            string firstQueue = queueOfStrings.Dequeue();
            string secondQueue = queueOfStrings.Peek();


            //Stack
            //First In Last Out
            Stack<int> intStack = new Stack<int>();
            intStack.Push(1);
            intStack.Push(2);

            int firstStack = intStack.Pop();
            int secondStack = intStack.Peek();

            //Dictionaries
            //Key Value Pair
            Dictionary<string, string> keyAndValue = new Dictionary<string, string>();

            keyAndValue.Add("Pie", "Apple Pie");
            keyAndValue.Add("7", "Tacos");

            string pieExample = keyAndValue["Pie"];

        }

        [TestMethod]
        public void Classes()
        {
            Random randomNumberGenerator = new Random();

            int randomNumber = randomNumberGenerator.Next();
        }
    }
}
