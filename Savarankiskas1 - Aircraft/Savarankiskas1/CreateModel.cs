using Savarankiskas1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Savarankiskas1
{
    public class CreateModel
    {
        public void createAircraftModels()
        {
            String file = @"C:\Users\Darius\Downloads\C--main (1)\C--main\Savarankiskas1\Savarankiskas1\DataFiles\Models.txt";
            List<string> lineModel = File.ReadAllLines(file).ToList();
            foreach (var modelInfo in lineModel)
            {
                string[] valueOfModel = modelInfo.Split(',');

                Model model = new Model()
                {
                    planeModel = valueOfModel[0],
                    flightDistance = Convert.ToInt16(valueOfModel[1]),
                    condition = valueOfModel[2],
                };
                ModelRespository.allModels.Add(model);
            }
        }
    }
}
