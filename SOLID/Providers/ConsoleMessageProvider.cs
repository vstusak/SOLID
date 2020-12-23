using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Providers
{
    public class ConsoleMessageProvider : IMessageProvider
    {
        public ConsoleKeyInfo AskForKeyInputWithMessage(string message)
        {
            Console.WriteLine(message);
            return Console.ReadKey();
        }

        public string AskForInputWithMessage(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }

        public void ShowMessageToUser(string message)
        {
            Console.WriteLine(message);
        }
    }
}
