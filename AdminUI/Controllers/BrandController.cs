using BusinessLayer.Abstract;
using DataAccessLayer;
using EntitiesLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace AdminUI.Controllers
{
    public class BrandController : Controller
    {
        IBrandService _brandService;
        public BrandController(IBrandService brandService)
        {
            _brandService = brandService;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult ListBrand()
        {
            //Id li getiren list methodumuz.
            var result = _brandService.GetAll();
            return View(result);

        }
        [HttpGet]
        public IActionResult AddBrand()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddBrand(Brand brand)
        {
            _brandService.Add(brand);
            return RedirectToAction("ListBrand", "Brand");
        }

        [HttpGet]
        public IActionResult UpdateBrand(int id)
        {
            using (Context context = new Context())
            {
                var result = context.Brands.FirstOrDefault(x => x.BrandId == id);
                return View(result);
            }

        }
        [HttpPost]
        public IActionResult UpdateBrand(Brand brand)
        {
            _brandService.Update(brand);
            return RedirectToAction("ListBrand", "Brand");
        }
        [HttpGet]
        public IActionResult DeleteBrandById(int id)

        {
            var ent = _brandService.GetId(id);
            _brandService.Delete(ent);
            return RedirectToAction("ListBrand", "Brand");

        }
    }
}
