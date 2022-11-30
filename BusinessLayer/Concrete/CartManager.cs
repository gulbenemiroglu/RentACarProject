using BusinessLayer.Abstract;
using EntitiesLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CartManager:ICartService
    {
        public void AddToCart(Cart cart, Car car)
        {
            CartLine cartLine = cart.CartLines.FirstOrDefault(c => c.Car.CarId == car.CarId);
            if (cartLine != null)
            {
                cartLine.RentDate++;
                return;
            }
            else
            {
                cart.CartLines.Add(new CartLine { Car = car, RentDate = 1 });
            }
        }

        public List<CartLine> List(Cart cart)
        {
            return cart.CartLines;
        }

        public void RemoveFromCart(Cart cart, int carId)
        {
            cart.CartLines.Remove(cart.CartLines.FirstOrDefault(c => c.Car.CarId == carId));
        }
    }
}
