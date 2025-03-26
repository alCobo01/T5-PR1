using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using T5_PR1.Data;
using T5_PR1.Models;

namespace T5_PR1.Pages
{
    public class EditarIndicadorEnergeticModel : PageModel
    {
        private readonly AppDbContext _context;

        [BindProperty]
        public IndicadorEnergetic Indicador { get; set; }

        public EditarIndicadorEnergeticModel(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet(int id)
        {
            Indicador = _context.IndicadorsEnergetics.Find(id);
            return Page();
        }

        public IActionResult OnPost()
        {
            _context.Update(Indicador);
            _context.SaveChanges();
            return RedirectToPage("./VeureIndicadors");
        }
    }
}
