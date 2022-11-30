using BusinessLayer.Abstract;
using DataAccessLayer;
using EntitiesLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace AdminUI.Controllers
{
    public class ModelController : Controller
    {
        IModelService _modelService;
        public ModelController(IModelService modelService)
        {
            _modelService = modelService;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult ListModel()
        {
            //Id li getiren list methodumuz.
            var result = _modelService.GetAll();
            return View(result);

        }
        [HttpGet]
        public IActionResult AddModel()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddModel(Model model)
        {
            _modelService.Add(model);
            return RedirectToAction("ListModel", "Model");
        }
       
        [HttpGet]
        public IActionResult UpdateModel(int id)
        {
            using (Context context = new Context())
            {
                var result = context.Models.FirstOrDefault(x => x.ModelId == id);
                return View(result);
            }

        }
        [HttpPost]
        public IActionResult UpdateModel(Model model)
        {
            _modelService.Update(model);
            return RedirectToAction("ListModel", "Model");
        }
        [HttpGet]
        public IActionResult DeleteModelById(int id)

        {
            var ent = _modelService.GetId(id);
            _modelService.Delete(ent);
            return RedirectToAction("ListModel", "Model");

        }
    }
}
