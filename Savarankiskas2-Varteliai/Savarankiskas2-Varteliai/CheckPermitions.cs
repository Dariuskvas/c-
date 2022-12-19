using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Savarankiskas2_Varteliai
{
    /// <summary>
    /// Nuskanavus kortele surenkami duomenys:
    ///     * UserIdScaned - darbuotojo ID;
    ///     * gateNumber - vartu ID;
    ///     * userWorkGroup - kokei grupei priskirtas darbuotojas;
    ///     * acces - ar turi leidima praeiti pro duris;
    /// Surinkti duomenys perduodami i registra.
    /// 
    /// </summary>
    public class CheckPermitions
    {
        Boolean access { get; set; }

        public void colectDataFromUserCard(int UserIdScaned, int gateNumber)
        {
            var userWorkGroup = UserRespository.Retrieve(UserIdScaned).userWorkGroupe;

            if (PermitsRespository.Retrieve(gateNumber, userWorkGroup) == null)
                access = false;
            else
                access = PermitsRespository.Retrieve(gateNumber, userWorkGroup).permissioToOpen;

            RegisterUserScan registerUserScan = new RegisterUserScan();
            registerUserScan.registerUserScan(UserIdScaned, gateNumber, userWorkGroup, access);
        }

    }
}
