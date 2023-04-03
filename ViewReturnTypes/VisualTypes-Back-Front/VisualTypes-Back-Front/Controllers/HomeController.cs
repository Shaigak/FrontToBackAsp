using Microsoft.AspNetCore.Mvc;
using VisualTypes_Back_Front.Models;
using VisualTypes_Back_Front.ViewModels.Home;
using VisualTypes_Back_Front.ViewModels.Product;

namespace VisualTypes_Back_Front.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {



            //ViewData["names"] = new string[] { "Elcan", "Pervin"};

            //ViewBag.numbers = new int[] { 10, 20, 30, 40 };

            //ViewBag.name = "Elcan";

            //TempData["surname"] = "qurbanov";
            //return RedirectToAction(nameof(Detail));

               Student stu1 = new Student
                {
                    Id = 1,
                   FullName = "Pervin Rehimli",
                 Age = 26
                };


               Student stu2 = new Student
                {
                    Id = 2,
                   FullName = "Ali Talibov",
                    Age = 21
                };


               Student stu3 = new Student
                {
                    Id = 3,
                    FullName = "Shaiq Kazimov",
                    Age = 25
                };

               List<Student> students = new List<Student> { stu1, stu2, stu3 };
           
            
            Product product = new()
            {
                Id = 1,
                Name = "Samsung 11",
                Count = 50,
                Price=250,
                Description="Description"

            };

            ProductVm productVm = new()
            {
                Name = product.Name,
                Price = product.Price,
            };




            HomeViewModel model = new()
            {
                Students = students,
                Product = productVm
            };


            
            
            return View(model);


            //    ViewBag.Address = "Sumqayit";
            //    return View(students);

            //}

            //public IActionResult Detail()
            //{
            //     return View();   
            //}





        }
            
    }
}
