using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pamoka7_2
{
    public class CreateRandomNum
    {

        public static Random getrandom = new Random();

        public static int GetRandomNumber(int qnt)
        {
            return getrandom.Next(qnt);
        }
    }
}
