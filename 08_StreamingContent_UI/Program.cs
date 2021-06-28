using _08_StreamingContent_UI.Consoles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_StreamingContent_UI
{
    class Program
    {
        static void Main(string[] args)
        {
            RealConsole productionConsole = new RealConsole();
            //User Interface
            ProgramUI ui = new ProgramUI(productionConsole);
            ui.Run();
        }
    }
}
