using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Savarankiskas2_Varteliai.DataSimulation
{
    public class RandomNumber
    {
        public int randomNumber(int numberfrom, int numberTo) 
        {
            Random r = new Random();
            int rInt = r.Next(numberfrom, numberTo);
            return rInt;
        }
    }
}
