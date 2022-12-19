using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Savarankiskas2_Varteliai.DataSimulation
{
    public class CreateRandomDataToProgram
    {
        public DateTime dayFrom { set; get; }
        public DateTime dayTo { set; get; }
        public int[] randUserId { set; get; }
        public int numberOfUser { set; get; }

        RandomNumber randomNumber = new RandomNumber();

        public CreateRandomDataToProgram()
        {
            dayFrom = new DateTime(2021, 01, 01);
            dayTo = new DateTime(2021, 01, 30);
            numberOfUser = UserRespository.allUseers.Count;
            randUserId = new int[numberOfUser];
        }

        public void createRandomDataToProgram()
        {
            do // sukasi kiek dienu ciklas
            {
                foreach (var cardId in UserRespository.allUseers) //Kiekvienam User ID
                {
                    do
                    {

                    } while (true);
                    
                    //Priskirti duruID kuriuos pasiimu is Listo
                    //ir laika random



                }
                dayFrom = dayFrom.AddDays(1);
            } while (dayFrom <= dayTo);

        }



    }
}
