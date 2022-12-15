using Microsoft.AspNetCore.Mvc;
using FirstMVCApp.Models;
namespace FirstMVCApp.Controllers
{
    public class HelloWorldController : Controller
    {
        private static List<DogViewModel> dogs = new List<DogViewModel>();
        public IActionResult Index()
        {
           
            return View(dogs);
        }

        //GET
        //Databinding
        public IActionResult Create()
        {
            var dogVm = new DogViewModel();
            return View(dogVm);
        }
         
        //dataBinding
        //POST Create
        public IActionResult CreateDog(DogViewModel dogViewModel)
        {
            dogs.Add(dogViewModel);
            //return View("Index");
            return RedirectToAction(nameof(Index));
        }
        public string Hello()
        {
            return "Who's there";
        }
    }
}
