using Pamoka7_4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pamoka7_4
{
    internal class PrintToConsole
    {
 
        internal void printRotateList(string[] anyStrinArray)
        {
            foreach(string x in anyStrinArray)
            {
                Console.WriteLine(x);
            }
        }

    }
}
