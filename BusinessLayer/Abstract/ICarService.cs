using EntitiesLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICarService
    {
        void Add(Car car);
        void Delete(Car car);
        void Update(Car car);
        //List<Car> GetAll();
        Car GetId(int id);
        Car GetById(int carId);
        List<Car> GetListWithBrand();
    }
}
