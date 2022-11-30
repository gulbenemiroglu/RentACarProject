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
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }
        public void Add(Car car)
        {
            _carDal.Add(car);
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);    
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();    
        }

        public Car GetById(int carId)
        {
            return _carDal.GetById(x => x.CarId == carId);
        }

        public Car GetId(int id)
        {
            return _carDal.GetId(id);
        }

        public List<Car> GetListWithBrand()
        {
            return _carDal.GetListWithBrand();
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
        }
    }
}
