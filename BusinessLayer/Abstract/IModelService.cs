using EntitiesLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IModelService
    {
        void Add(Model model);
        void Delete(Model model);
        void Update(Model model);
        List<Model> GetAll();
        Model GetId(int modelId);
    }
}
