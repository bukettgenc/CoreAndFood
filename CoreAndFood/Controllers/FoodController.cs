using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreAndFood.Repositories;
using CoreAndFood.Data.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CoreAndFood.Controllers
{
    public class FoodController : Controller
    {
        Context db = new Context();

        FoodRepository foodRepository = new FoodRepository();
        public IActionResult Index()
        {
            FoodRepository foodRepository = new FoodRepository();
            return View(foodRepository.tList("Category"));
        }
        public IActionResult AddFood()
        {
            List<SelectListItem> values = (from x in db.Categories.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.CategoryName,
                                               Value = x.CategoryId.ToString()
                                           }).ToList();
            ViewBag.values = values;
            return View();
        }
        [HttpPost]
        public IActionResult AddFood(Food f)
        {
            foodRepository.TAdd(f);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteFood(int id)
        {
            foodRepository.TDelete(new Food { FoodId = id });
            return RedirectToAction("Index");
        }
        public IActionResult GetFood(int id)
        {
            var x = foodRepository.TGet(id);
            List<SelectListItem> values = (from y in db.Categories.ToList()
                select new SelectListItem
                {
                    Text = y.CategoryName,
                    Value = y.CategoryId.ToString()
                }).ToList();
            ViewBag.values = values;
            Food food = new Food()
            {
                CategoryId = @x.CategoryId,
                Name = @x.Name,
                Price = @x.Price,
                Stock = @x.Stock,
                Description = @x.Description,
                ImageUrl = @x.ImageUrl

            };
            return View(food);
        }

        [HttpPost]
        public IActionResult FoodUpdate(Food f)
        {
            var x = foodRepository.TGet(f.FoodId);
            x.Name = f.Name;
            x.Stock = f.Stock;
            x.Price = f.Price;
            x.ImageUrl = f.ImageUrl;
            x.Description = f.Description;
            x.CategoryId = f.CategoryId;
            foodRepository.TUpdate(x);
            return RedirectToAction("Index");
            //fdeki food id taşınmadı
        }
    }
}
