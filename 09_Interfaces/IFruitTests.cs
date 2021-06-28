using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _09_Interfaces
{
    [TestClass]
    public class IFruitTests
    {
        [TestMethod]
        public void CallingInterfaceMethods()
        {
            IFruit banana = new Banana();

            Console.WriteLine("The Banana is peeled: " + banana.IsPeeled);

            var output = banana.Peel();
            Console.WriteLine(output);

            Console.WriteLine("The Banana is peeled: " + banana.IsPeeled);

            //Cannot assign to IsPeeled since it has private set
            //banana.IsPeeled = true;

            Assert.IsTrue(banana.IsPeeled);
        }

        [TestMethod]
        public void InterfacesInCollections()
        {
            var orange = new Orange();

            var bagOfFruit = new List<IFruit>
            {
                new Banana(),
                new Grape(),
                orange
            };

            bagOfFruit.Add(new Banana());

            foreach(var fruit in bagOfFruit)
            {
                Console.WriteLine(fruit.Name);
                Console.WriteLine(fruit.Peel());
                //IFruit does not have squeeze method
                //Console.WriteLine(fruit.Squeeze());
            }

            Console.WriteLine(orange.Squeeze());
        }

        private string GetFruitName(IFruit fruit)
        {
            return $"This fruit is called {fruit.Name}";
        }

        [TestMethod]
        public void InterfacesInMethods()
        {
            //Arrange
            var grape = new Grape();
            //ACT
            var output = GetFruitName(grape);

            Console.WriteLine(output);
            //ASSERT
            Assert.IsTrue(output.Contains("This fruit is called Grape"));
        }

        [TestMethod]
        public void TypeOfInstance()
        {
            var bagOfFruit = new List<IFruit>
            {
                new Orange(true),
                new Orange(),
                new Grape(),
                new Orange(),
                new Banana(),
                new Grape(),
                new Banana(true)
            };

            Console.WriteLine("What fruit is it and is it peeled?");
            foreach(var fruit in bagOfFruit)
            {
                if(fruit is Orange orange) //Pattern matching
                {
                    if(orange.IsPeeled)
                    {
                        Console.WriteLine("This is a peeled Orange");
                        orange.Squeeze();
                    }
                    else
                    {
                        Console.WriteLine("This is an unpeeled Orange");
                    }
                }
                else if(fruit.GetType() == typeof(Grape))
                {
                    Console.WriteLine("This is a Grape");

                    var grape = (Grape)fruit;
                    grape.Peel();
                }
                else if (fruit is Banana banana)
                {
                    if (banana.IsPeeled)
                    {
                        Console.WriteLine("This is a peeled Banana");
                    }
                    else
                    {
                        Console.WriteLine("This is an unpeeled Banana");
                    }
                }
            }
        }
    }
}
