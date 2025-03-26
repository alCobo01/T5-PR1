using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using T5_PR1.Models;
using T5_PR1.Data;

namespace T5_PR1.Pages
{
    public class EditarConsumAiguaModel : PageModel
    {
        private readonly AppDbContext _context;

        [BindProperty]
        public ConsumAigua ConsumAigua { get; set; }

        public EditarConsumAiguaModel(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet(int id)
        {
            ConsumAigua = _context.ConsumsAigua.Find(id);
            return Page();
        }

        public IActionResult OnPost()
        {
            _context.Update(ConsumAigua);
            _context.SaveChanges();
            return RedirectToPage("./VeureConsumAigua");
        }
    }
}
