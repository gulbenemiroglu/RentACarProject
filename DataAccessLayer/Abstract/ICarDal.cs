using EntitiesLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface ICarDal:IRepository<Car>
    {
        List<Car> GetListWithBrand();
        //List<Car> GetListWithModel();
    }
}
