using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_StreamingContent_UI.Consoles
{
    //Define what our Console needs to do
    public interface IConsole
    {

        //Console.Clear();
        void Clear();

        //Console.WriteLine
        void WriteLine(string str);

        void WriteLine(object obj);

        //Console.ReadLine();
        string ReadLine();

        //Console.Write
        void Write(string str);
        void Write(object obj);

        //Console.ReadKey
        ConsoleKeyInfo ReadKey();
    }
}
