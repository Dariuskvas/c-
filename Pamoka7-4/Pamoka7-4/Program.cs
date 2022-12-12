using Pamoka7_4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pamoka7_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RotateString RotateString = new RotateString();
            RotateString.rotateString();

            PrintToConsole printConsole = new PrintToConsole();
            printConsole.printRotateList(StringArray.arrayRotateOut);
            
            Console.ReadLine();

        }
    }
}
