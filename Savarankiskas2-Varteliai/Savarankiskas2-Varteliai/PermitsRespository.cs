using Savarankiskas2_Varteliai.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Savarankiskas2_Varteliai
{
    public class PermitsRespository
    {
        public static List<Permit> allPermits = new List<Permit>();

        public static Permit Retrieve(int gateId, string workGroupe)
        {
            foreach (var permitInfo in allPermits)
            {
                if (permitInfo.gateId == gateId && permitInfo.userWorkGroupe== workGroupe)
                {
                    return permitInfo;
                }
            }
            return null;
        }
    }
} 