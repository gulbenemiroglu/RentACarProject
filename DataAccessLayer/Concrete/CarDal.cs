using DataAccessLayer.Abstract;
using EntitiesLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class CarDal : Repository<Car>, ICarDal
    {
        public List<Car> GetListWithBrand()
        {
            using (Context context = new Context())
            {
                return context.Cars.Include(c => c.Brand).ToList();
               
            }
        }

        
    }
}
