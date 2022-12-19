using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Savarankiskas2_Varteliai.Models
{
    public class Permit
    {
        public int permitId { get; set; }
        public int gateId { get; set; }
        public string userWorkGroupe { get; set; }
        public Boolean permissioToOpen { get; set; }

    }

}
