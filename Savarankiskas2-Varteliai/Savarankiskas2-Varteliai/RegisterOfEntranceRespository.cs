using Savarankiskas2_Varteliai.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Savarankiskas2_Varteliai
{
    public class RegisterOfEntranceRespository
    {
        public static List<RegisterOfEntrance> allRegisterOfEntrances = new List<RegisterOfEntrance>();
        public List<RegisterOfEntrance> accessFalse = new List<RegisterOfEntrance>();
        public List<RegisterOfEntrance> accessTrue = new List<RegisterOfEntrance>();
    }
}
