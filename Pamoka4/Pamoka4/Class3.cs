using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pamoka4
{
    internal class Class3

    {
        public void uzduotis3() 

            //ivesta sakini paraso atvirksciai

        {
            Console.WriteLine("Iveskite sakini ir ji atspausdins stvirksciai");
            string inputText = Console.ReadLine();
            if (inputText == null || inputText=="")
            { 
                Console.WriteLine("Nieko neivesta");
                Environment.Exit(0);
            }
            
            string[] arrayText = inputText.Split(" ");
            Array.Reverse(arrayText);
            Console.WriteLine(String.Join(" ",arrayText));
        }
    }
}
