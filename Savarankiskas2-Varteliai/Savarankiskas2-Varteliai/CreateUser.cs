using Savarankiskas2_Varteliai.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Savarankiskas2_Varteliai
{
    public class CreateUser
    {    
        public void createUser()
        {
            string file = @"C:\Users\Darius\Desktop\pr kursai\c#2\Savarankiskas2-Varteliai\Savarankiskas2-Varteliai\DataFiles\Users.txt";
            List<string> lineUser = File.ReadAllLines(file).ToList();

            foreach (var userData in lineUser)
            {
                User user = new User();
                string[] valueOfUser = userData.Split(',');

                user.userId = Convert.ToInt32(valueOfUser[0]);
                user.userName = valueOfUser[1];
                user.userWorkGroupe = valueOfUser[2];
                user.userWorkTipe = valueOfUser[3];
                user.userHourSalary = Convert.ToInt32(valueOfUser[4]);
                user.userEmployed = Convert.ToBoolean(valueOfUser[5]);
                UserRespository.allUseers.Add(user);
            }
        }
    }
}
