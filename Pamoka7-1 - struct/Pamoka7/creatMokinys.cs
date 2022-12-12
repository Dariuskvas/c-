using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pamoka7.Models;

namespace Pamoka7
{
    public class creatMokinys
    {
        public void createMokiniai(string name, string surname)
        {
                 
            Mokinys mokinys1 = new Mokinys();

            mokinys1.FirstName = name;
            mokinys1.LastName = surname;


            MokinysRespository.allMokinys.Add(mokinys1);

            Console.WriteLine("");
        }
        
    }
}
