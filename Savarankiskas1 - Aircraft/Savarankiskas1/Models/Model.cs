using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Savarankiskas1.Models
{
    public class Model
    {
        public int modelId { set; get; }
        public string planeModel { set; get; }
        public int flightDistance { set; get; }
        public string condition { set; get; }

        public Model()
        {
            modelId= ModelRespository.allModels.Count+1;
            planeModel = string.Empty;
            flightDistance = 0;
            condition = string.Empty;
        }
    }
}
