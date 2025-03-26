using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using T5_PR1.Models;
using System.Text.Json;
using T5_PR1.Data;

namespace T5_PR1.Pages
{
    public class AfegirIndicadorModel : PageModel
    {
        private readonly AppDbContext _context;

        [BindProperty]
        public IndicadorEnergetic? Indicador { get; set; }

        //Constuctor per injecció de dependències
        public AfegirIndicadorModel(AppDbContext context) => _context = context;

        public void OnGet()
        {
            Indicador = new IndicadorEnergetic();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid) return Page();

            _context.IndicadorsEnergetics.Add(Indicador);
            _context.SaveChanges();

            return RedirectToPage("VeureIndicadors");
            
        }
    }
}
