using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pamoka1_1
{
    public class Tasks
    {
        public void uzduotis1()
        {
            string[] labas = { "L", "a", "b", "a", "s" };
            foreach (string laba in labas)
            {
                Console.WriteLine(laba);
            }
        }
        public void uzduotis2() 
        {
            string[] labas1 = { "L", "a", "b", "a", "s" };
            foreach (string laba1 in labas1)
            {
                Console.Write($"{laba1} ");
            }
        Console.WriteLine();
        }
        public void uzduotis3() 
        {
            string[] labas1 = { "L", "a", "b", "a", "s" };
            Console.Write("Escape metodas \"");
            foreach (string laba1 in labas1)
            {
                Console.Write($"{laba1}");
            }
            Console.WriteLine("\"");
        }
        public void uzduotis4() 
        {
            DateTime dateValue = DateTime.Now;

            Console.WriteLine((int)dateValue.DayOfWeek);    // gaunu skaiciu
            Console.WriteLine(dateValue.DayOfWeek);         // gaunu savaites diena
        }

        public void uzduotis5() { }

    }
}
