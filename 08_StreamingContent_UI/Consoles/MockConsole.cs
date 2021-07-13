using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_StreamingContent_UI.Consoles
{
    public class MockConsole : IConsole
    {
        //First In First Out
        public Queue<string> UserInput;

        public string Output;

        public MockConsole(IEnumerable<string> input)
        {
            UserInput = new Queue<string>(input);

            Output = "";
        }
        public void Clear()
        {
            Output += "Called Clear Method\n";
        }

        public ConsoleKeyInfo ReadKey()
        {
            return new ConsoleKeyInfo();
        }

        public string ReadLine()
        {
            //Output += "Giving Input of: " + UserInput.Peek() + "\n";
            return UserInput.Dequeue();
        }

        public void Write(string str)
        {
            Output += str;
        }

        public void Write(object obj)
        {
            Output += obj;
        }

        public void WriteLine(string str)
        {
            Output += str + "\n";
        }

        public void WriteLine(object obj)
        {
            Output += obj + "\n";
        }
    }
}
