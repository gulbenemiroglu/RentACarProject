using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntitiesLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ModelManager : IModelService
    {
        IModelDal _modelDal;

        public ModelManager(IModelDal modelDal)
        {
            _modelDal = modelDal;
        }
        public void Add(Model model)
        {
            _modelDal.Add(model);   
        }

        public void Delete(Model model)
        {
            _modelDal.Delete(model);
        }

        public List<Model> GetAll()
        {
            return _modelDal.GetAll();
        }

        public Model GetId(int modelId)
        {
            return _modelDal.GetId(modelId);
        }

        public void Update(Model model)
        {
            _modelDal.Update(model);
        }
    }
}
