using FoodResturant.Data;
using FoodResturant.Models;
using Microsoft.AspNetCore.Mvc;

namespace FoodResturant.Controllers
{
    public class IngredientController : Controller
    {
        private Repository<Ingredient> ingredients;

        public IngredientController(ApplicationDbContext context)
        {
            ingredients = new Repository<Ingredient>(context);  // that ties the repository into the applicationDbContext 
        }
        public async Task <IActionResult>Index()
        {
            return View(await ingredients.GetAllAsync());
        }

        public async Task<IActionResult> Details(int id)
        {
            // ingredient needs to include all of the products that is associated with
            // where queryOptions comes in to play 
            return View(await ingredients.GetByIdAsync(id, new QueryOptions<Ingredient>() { Includes="ProductIngredients.Product"}));
        }

        //Ingredient/Create
        [HttpGet]
        public IActionResult Create() 
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IngredientId", "Name")] Ingredient ingredient)
        {
            if (ModelState.IsValid) 
            {
                await ingredients.AddAsync(ingredient);
                return RedirectToAction("Index");
            }
            return View(ingredient);

        } 

    }
}
