using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Classes
{
    enum VehicleType { Car, Truck, Boat, Plane, Spaceship, Motorcycle }
    class Vehicle
    {
        //Fields

        //Constructors
        //1 Access Modifier
        //2 Return Type
        //3 Parameters
        //4 Body
        //1    //2    //3 //4
        public Vehicle() { }

        //1    //2      //3
        public Vehicle(string model, int numberOfTires, VehicleType vehicleType)
        {
            //4
            Model = model;
            NumberOfTires = numberOfTires;
            TypeOfVehicle = vehicleType;
        }



        //Properties
        //Property Signature
        // 1 Access modifier => by default internal. Other options Public and Private
        // 2 Type => the type that the property holds
        // 3 Name => The name of the property. These should be PascalCase.
        // 4 Get and Set Methods (Getter and Setter)
        //1   //2  //3         //4
        public int BackSeats { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int NumberOfTires { get; set; }
        public bool Tires { get; set; }

        public VehicleType TypeOfVehicle { get; set; }

        //Methods
    }
}
