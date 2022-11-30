using EntitiesLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IUserService
    {
        void Add(User user);
        void Delete(User user);
        void Update(User user);
        List<User> GetAll();
        User GetId(int userId);
    }
}
