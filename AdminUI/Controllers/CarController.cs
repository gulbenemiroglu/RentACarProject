using BusinessLayer.Abstract;
using DataAccessLayer;
using EntitiesLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace AdminUI.Controllers
{
    public class CarController : Controller
    {
        ICarService _carService;
        public CarController(ICarService carService)
        {
            _carService = carService;
        }
        public IActionResult Index()
        {
            return View();
        }
        //[HttpGet]
        //public IActionResult ListCarWithBrandName()
        //{
        //    //İstediğimiz veriyi cekebildiğimiz hali.
        //    var result = _carService.GetCarDetails();
        //    return View(result);

        //}

        [HttpGet]
        public IActionResult ListCar()
        {
            //Id li getiren list methodumuz.
            var result = _carService.GetListWithBrand();
            return View(result);

        }
        [HttpGet]
        public IActionResult AddCar()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddCar(Car car)
        {
            _carService.Add(car);
            return RedirectToAction("ListCar", "Car");
        }
       
        [HttpGet]
        public IActionResult UpdateCar(int id)
        {
            using (Context context = new Context())
            {
                var result = context.Cars.FirstOrDefault(x => x.CarId == id);
                return View(result);
            }

        }
        [HttpPost]
        public IActionResult UpdateCar(Car car)
        {
            _carService.Update(car);
            return RedirectToAction("ListCar", "Car");
        }
        [HttpGet]
        public IActionResult DeleteCarById(int id)

        {
            var ent = _carService.GetId(id);
            _carService.Delete(ent);
            return RedirectToAction("ListCar", "Car");

        }
    }
}

