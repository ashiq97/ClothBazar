using ClothBazar.Entities;
using ClothBazar.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClothBazar.Web.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        CategoriesService _categoryService = new CategoriesService();

        [HttpGet]
        public ActionResult Index()
        {
            var categories = _categoryService.GetCategories();
            return View(categories);
        }


        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Category category)
        {
            _categoryService.SaveCategory(category);
            return RedirectToAction("Index");
        }


        [HttpGet]
        public ActionResult Edit(int id)
        {
            var category = _categoryService.GetCategory(id);
            return View(category);
        }

        [HttpPost]
        public ActionResult Edit(Category category)
        {
            _categoryService.UpdateCategory(category);
            return RedirectToAction("Index");
        }


        [HttpGet]
        public ActionResult Delete(int id)
        {
            var category = _categoryService.GetCategory(id);
            return View(category);
        }

        [HttpPost]
        public ActionResult Delete(Category category)
        {
            _categoryService.DeleteCategory(category.ID);
            return RedirectToAction("Index");
        }

    }
}