using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Interfaces
{
    //Interface starts with an I
    public interface IFruit
    {
        //In interface there are no access modifiers
        string Name { get; }
        bool IsPeeled { get; }
        string Peel();

    }
}
