using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_StreamingContent_UI.Consoles
{
    //Release/Production/Real
    public class RealConsole : IConsole
    {
        public void Clear()
        {
            Console.Clear();
        }

        public ConsoleKeyInfo ReadKey()
        {
            return Console.ReadKey();
        }

        public string ReadLine()
        {
            return Console.ReadLine();
        }

        public void Write(string str)
        {
            Console.Write(str);
        }

        public void Write(object obj)
        {
            Console.Write(obj);
        }

        public void WriteLine(string str)
        {
            Console.WriteLine(str);
        }

        public void WriteLine(object obj)
        {
            Console.WriteLine(obj);
        }
    }
}
