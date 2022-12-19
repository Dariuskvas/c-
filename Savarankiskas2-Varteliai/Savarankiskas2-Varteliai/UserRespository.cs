using Savarankiskas2_Varteliai.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Savarankiskas2_Varteliai
{
    public class UserRespository
    {
        public static List<User> allUseers = new List<User>();

        public static User Retrieve(int id)
        {
            foreach (var worker in allUseers)
            {
                if (worker.userId == id)
                {
                    return worker;
                }
            }
            return null;
        }
    }
}