using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using T5_PR1.Data;
using T5_PR1.Models;

namespace T5_PR1.Pages
{
    public class AfegirConsumAiguaModel : PageModel
    {
        private readonly AppDbContext _context;

        [BindProperty]
        public ConsumAigua ConsumAigua { get; set; }

        //Constuctor per injecció de dependències
        public AfegirConsumAiguaModel(AppDbContext context) => _context = context;

        public void OnGet()
        {
            ConsumAigua = new ConsumAigua();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid) return Page();

            _context.ConsumsAigua.Add(ConsumAigua);
            _context.SaveChanges();

            return RedirectToPage("VeureConsumAigua");
        }
    }
}
