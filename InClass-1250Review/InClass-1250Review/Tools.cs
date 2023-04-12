using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClass_1250Review
{
    public class Tools
    {
        //Examples of static methods; called with class name, no object instance created (see driver)

        public static void ClearConsole()
        {
            Console.Clear();
        }

        public static void PressAnyKey(string message)
        {
            Console.WriteLine(message);
            Console.ReadKey();

            /*
            //How to check for a particular key being pressed, in this case, Enter
            while(Console.ReadKey().Key != ConsoleKey.Enter)
            {
                Console.WriteLine("Wrong key, try again.");
            }
            */
        }
    }
}
