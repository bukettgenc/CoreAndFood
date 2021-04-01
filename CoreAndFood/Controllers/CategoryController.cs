using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreAndFood.Data.Models;
using CoreAndFood.Repositories;

namespace CoreAndFood.Controllers
{
    public class CategoryController : Controller
    {
        CategoryRepository categoryRepository = new CategoryRepository();

        public IActionResult Index()
        {
            return View(categoryRepository.tList());
        }
        public IActionResult AddCategory()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddCategory(Category c)
        {
            if (!ModelState.IsValid)
            {
                return View("AddCategory");
            }
            categoryRepository.TAdd(c);
            return View();
        }
        public IActionResult GetCategory(int id)
        {
            var x = categoryRepository.TGet(id);
            Category ct = new Category()
            {
                CategoryName = @x.CategoryName,
                CategoryDescription = @x.CategoryDescription,
                CategoryId = @x.CategoryId
            };
            return View(ct);
        }
        [HttpPost]
        public IActionResult CategoryUpdate(Category c)
        {
            var x = categoryRepository.TGet(c.CategoryId);
            x.CategoryName = c.CategoryName;
            x.CategoryDescription = c.CategoryDescription;
            x.Status = true;
            categoryRepository.TUpdate(x);
            return RedirectToAction("Index");
        }
        public IActionResult CategoryDelete(int id)
        {
            var x = categoryRepository.TGet(id);
            x.Status = false;
            categoryRepository.TUpdate(x);
            return RedirectToAction("Index");
        }
    }
}
