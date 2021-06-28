using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Random.Models;
using Microsoft.EntityFrameworkCore;

namespace Random.Controllers
{
    public class HomeController : Controller
    {
        private MyContext _context;

        public HomeController(MyContext context)
        {
            {_context = context;
            }
        }


         [HttpGet("AddDish")]
        public IActionResult AddDish()
        {
            return View();
        }

        [HttpPost("create")]
        public IActionResult Create(Recipe newRecipe)
        {
            if (ModelState.IsValid)
            {
                _context.Add(newRecipe);
                _context.SaveChanges();
                return RedirectToAction("Index");
            } else{
                return View("AddDish");
            }
        }
        public IActionResult Index()
        {
            List<Recipe> AllRecipes = _context.Recipes.ToList();
            ViewBag.AllRecipes = AllRecipes;
            return View();
        }

        [HttpGet("onerecipe/{RecipeId}")]
        public IActionResult OneRecipe(int RecipeId)
        {
            ViewBag.OneRecipe = _context.Recipes.FirstOrDefault(a => a.RecipeId == RecipeId);
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet("delete/{RecipeId}")]
        public IActionResult Delete(int RecipeId)
        {
            Recipe recipeToDelete = _context.Recipes.SingleOrDefault(a => a.RecipeId == RecipeId);
            _context.Recipes.Remove(recipeToDelete);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

         [HttpGet("edit/{RecipeId}")]
        public IActionResult Update(int RecipeId)
        {
           Recipe RecipeToEdit = _context.Recipes.FirstOrDefault(g => g.RecipeId == RecipeId);
           return View (RecipeToEdit);
        }

        
        [HttpPost("update/{RecipeId}")]
        public IActionResult PerformUpdate(int RecipeId, Recipe EditRecipe)
        {
            Recipe RecipeToEdit = _context.Recipes.FirstOrDefault(g => g.RecipeId == RecipeId);
            RecipeToEdit.Chef = EditRecipe.Chef;
            RecipeToEdit.Name = EditRecipe.Name;
            RecipeToEdit.Calories = EditRecipe.Calories;
            RecipeToEdit.Tastiness = EditRecipe.Tastiness;
            RecipeToEdit.Description = EditRecipe.Description;
            RecipeToEdit.UpdatedAt = DateTime.Now;
            _context.SaveChanges();
            return RedirectToAction ("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
