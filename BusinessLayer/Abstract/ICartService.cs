using EntitiesLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICartService
    {
        void AddToCart(Cart cart, Car car);
        void RemoveFromCart(Cart cart, int carId);
        List<CartLine> List(Cart cart);
    }
}
