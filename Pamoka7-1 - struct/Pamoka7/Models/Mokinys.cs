using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pamoka7.Models
{
    public struct Mokinys                                   //"struct" skirtingai nei "class" turi atskira atminties vieta, todel klases kopija nepasiima reiksmiu. 
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime StartLearnDate { get; set; }
        public DateTime EndLearnDate { get; set; }

        public Mokinys()
        {
            FirstName = string.Empty;
            LastName = string.Empty;
            StartLearnDate = Convert.ToDateTime("11/20/2022");
            EndLearnDate = DateTime.Now;
        }
    }



}
