using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using static WebApplication3.Services.PizzaService;
using WebApplication3.Models;

namespace WebApplication3.Pages
{
    public class pizzaModel : PageModel
    {
        [BindProperty]
        public MPizza NewPizza { get; set; }
        public List<MPizza> pizzas = new List<MPizza>();
        public void OnGet()
        {
            pizzas = GetAll();
        }
        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            Add(NewPizza);
            return RedirectToAction("Get");
        }
        public IActionResult OnPostDelete(int id)
        {
            Delete(id);
            return RedirectToAction("Get");
        }
    }
}
