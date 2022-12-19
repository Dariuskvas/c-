using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Savarankiskas2_Varteliai.Models
{
    public class RegisterOfEntrance
    {
        public int userId { set; get; }
        public int gateId { set; get; }
        public Boolean access { set; get; }
        public DateTime scanTime { set; get; }
        public Boolean walkIN { set; get; }
    }
}
