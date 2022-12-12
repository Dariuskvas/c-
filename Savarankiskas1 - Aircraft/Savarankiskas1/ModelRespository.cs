using Savarankiskas1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Savarankiskas1
{
    public class ModelRespository
    {
        public static List<Model> allModels = new List<Model>();

        public static List<Model> Retrieve()
        {
            return allModels;
        }

        public static Model Retrieve(int id)
        {
            foreach (Model model in allModels)
            {
                if (model.modelId == id)
                    return model;
            }
            return null;
        }
    }
}
