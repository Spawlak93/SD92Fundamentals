using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _03_Classes_Setters
{
    [TestClass]
    public class QuackerTests
    {
        [TestMethod]
        public void ConstructorTest_ShouldStoreCorrectValues()
        {
            var quackOne = new Quacker("Daffy", 84);

            Assert.AreEqual("Daffy", quackOne.UserName);
            Assert.AreEqual(84, quackOne.Age);
        }

        [TestMethod]
        public void InvalidUserName_ShouldThrowFormatException()
        {
            Exception thrownException = null;
            //Try Catch
            try
            {
                var quacker = new Quacker("Don", 86);
            }
            //Catches Exception and runs body
            catch (FormatException err)
            {
                Console.WriteLine(err.Message);
                thrownException = err;
            }
            //Finally will always run. 
            finally
            {
                Console.WriteLine("I always Run");
            }

            Console.WriteLine("I can be stopped from running");

            Assert.IsNotNull(thrownException);
            Assert.IsInstanceOfType(thrownException, typeof(FormatException));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void InvalidAge_ShouldThrowArgumentException()
        {
            var quacky = new Quacker("Louie", 10);
        }
    }
}
