using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _06_Inheritance_Classes
{
    [TestClass]
    public class AnimalsTests
    {
        [TestMethod]
        public void DogTests()
        {
            //Animal genericAnimal = new Animal();
            //genericAnimal.Breath();

            Console.WriteLine();
            Dog fido = new Dog();
            fido.Breath();
            fido.MakeSound();

            Console.WriteLine();
            Chihuahua betsy = new Chihuahua();
            betsy.Breath();
            betsy.MakeSound();

            Wolf balto = new Wolf();
            balto.MakeSound();

        }
    }
}
