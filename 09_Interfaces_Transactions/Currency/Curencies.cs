using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Interfaces_Transactions.Currency
{
    public class Penny : ICurrency
    {
        public string Name
        {
            get { return "Penny"; }
        }

        public decimal Value
        {
            get
            {
                return 0.01m;
            }
        }
    }

    public class Dime : ICurrency
    {
        public string Name { get { return "Dime"; } }

        public decimal Value { get { return 0.10m; } }
    }


    public class Dollar : ICurrency
    {
        public string Name { get => "Dollar"; } 

        public decimal Value { get => 1.00m; }
    }

    //Electronic Payment
    public class ElectronicPayment : ICurrency
    {
        public string Name { get { return "Electronic Payment"; } }

        public decimal Value { get; }

        public ElectronicPayment(decimal value)
        {
            //Constructors can set readonly values
            Value = value;
        }

    }

    public class Euro : ICurrency
    {
        //Same as saying
        //public string Name { get { return "Euro"; } }
        public string Name => "Euro";

        public decimal Value => 1.19m;
    }

}
