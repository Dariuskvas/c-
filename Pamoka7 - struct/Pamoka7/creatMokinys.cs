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
        


            Mokinys mokinys2 = new Mokinys();
            mokinys2 = mokinys1;                                            //naujai inicijuota klase su "struct" kintamaisiais nors ir prilyginama viena kitai negauna jos reiksmiu

            mokinys2.FirstName = name+name; ;
            mokinys2.LastName = surname+surname;


            /* MokinysRespository.allMokinys.Add(mokinys1);*/

            Console.WriteLine("");
        }
        
    }
}
