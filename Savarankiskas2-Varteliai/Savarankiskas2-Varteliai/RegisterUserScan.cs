using Savarankiskas2_Varteliai.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Savarankiskas2_Varteliai
{
    /// <summary>
    /// Sukuriam praeinanciu zmoniu duombaze.
    /// 
    /// </summary>
    public class RegisterUserScan
    {
        RegisterOfEntranceRespository registerOfEntranceRespository = new RegisterOfEntranceRespository();

        public void registerUserScan(int UserIdScaned, int gateNumber, string userWorkGroup, Boolean permissionHave)
        {

            RegisterOfEntrance registerOfEntrance = new RegisterOfEntrance()
            {
                userId = UserIdScaned,
                gateId = gateNumber,
                access = permissionHave,
                scanTime = DateTime.Now,
                walkIN = userWalkInOrOut(permissionHave, UserIdScaned),
            };

            RegisterOfEntranceRespository.allRegisterOfEntrances.Add(registerOfEntrance);
        }

        // Tikrinu ar darbuotojas jau iejas i pastata ar isejas, Visul Studio automatiskai pakeite pavadinima, kad ne pirmas veiksmazodis
        public bool userWalkInOrOut(Boolean permisioIn, int UserIdScanedFromList)
        {
            if (permisioIn == false)
            {
                if (RegisterOfEntranceRespository.allRegisterOfEntrances.FindLast(x => x.userId == UserIdScanedFromList) == null)
                {
                    return false;
                }
                else
                {
                    return RegisterOfEntranceRespository.allRegisterOfEntrances.FindLast(x => x.userId == UserIdScanedFromList).walkIN;
                }
            }
            else if (RegisterOfEntranceRespository.allRegisterOfEntrances.FindLast(x => x.userId == UserIdScanedFromList) != null)
            {
                return !RegisterOfEntranceRespository.allRegisterOfEntrances.FindLast(x => x.userId == UserIdScanedFromList).walkIN;
            }
            else
            {
                return true;
            }
        }

        public void printList()
        {
            foreach (var i in RegisterOfEntranceRespository.allRegisterOfEntrances)
            {
                Console.WriteLine("*************************************************");
                Console.WriteLine("User ID: " + i.userId);
                Console.WriteLine("GateID: " + i.gateId);
                Console.WriteLine("Access: " + i.access);
                Console.WriteLine("ScanTime: " + i.scanTime);
                Console.WriteLine("walkIn: " + i.walkIN);
            }
        }
    }
}
