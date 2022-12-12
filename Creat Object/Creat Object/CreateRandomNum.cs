using Creat_Object;
using Creat_Object.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creat_Object
{
    public class CreateRandomNum
    {

        public static readonly Random getrandom = new Random();

        public static int GetRandomNumber(int x)
        {
          return getrandom.Next(x);
            Console.WriteLine("");

        }
    }
}

