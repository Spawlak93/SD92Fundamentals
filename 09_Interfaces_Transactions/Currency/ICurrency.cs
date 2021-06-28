using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Interfaces_Transactions.Currency
{
    public interface ICurrency
    {
        //What is this currency called
        string Name { get; }
        //What Value does it have
        decimal Value { get; }
    }
}
