using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _03_Classes
{
    [TestClass]
    public class ClassTests
    {
        [TestMethod]
        public void VehicleTests()
        {
            VehicleType typeOfVehicle = VehicleType.Boat;

            Vehicle myCar = new Vehicle();

            myCar.NumberOfTires = 4;
            myCar.BackSeats = 12;
            myCar.Tires = true;

            int numberOfTires = myCar.NumberOfTires;
            Console.WriteLine(myCar.NumberOfTires);
            Vehicle moonLander = new Vehicle();
            moonLander.Tires = false;

            int number = moonLander.BackSeats;

            Vehicle newCar = new Vehicle("Accord", 4, VehicleType.Car);
        }

        [TestMethod]
        public void CalcuclatorTests()
        {
            Calculator calc = new Calculator();

            
            int seven = 7;
            int five = 5;

            int result = calc.Addition(seven, five);
        }

        [TestMethod]
        public void PersonTests()
        {
            Person simon = new Person("Frank", "Underwood");
            Person robert = new Person();

            simon.FirstName = "Simon";
            simon.LastName = "Pawlak";
            //simon.FullName = simon.FirstName + " " + simon.LastName;
            simon.FirstName = "bob";

            Person desmond = new Person();
            desmond.FirstName = "Desmond";

            Person amanda = new Person("Amanda", "Knight");
            //amanda.FullName = "Amanda Knight";
            //amanda.FullName = "Banana";
        }
    }
}
