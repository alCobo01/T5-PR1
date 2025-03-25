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
        public List<IndicadorEnergetic>? Indicadors { get; set; }

        //Constuctor per injecció de dependències
        public AfegirIndicadorModel(AppDbContext context) => _context = context;

        public void OnGet()
        {
            Indicador = new IndicadorEnergetic();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid) return Page();

            //Per no inserir valor nulls al JSON, introdueixo valors per defecte als camps amb valor null depenent del tipus de dada que són
            foreach (var propietat in typeof(IndicadorEnergetic).GetProperties())
            {
                var valorActual = propietat.GetValue(Indicador);
                if (valorActual == null)
                {
                    if (propietat.PropertyType == typeof(string))
                        propietat.SetValue(Indicador, "0.0%");
                    else if (propietat.PropertyType == typeof(int))
                        propietat.SetValue(Indicador, 0);
                    else if (propietat.PropertyType == typeof(double))
                        propietat.SetValue(Indicador, 0.0);
                    else if (propietat.PropertyType == typeof(double?))
                        propietat.SetValue(Indicador, 0.0);
                    else if (propietat.PropertyType == typeof(DateTime))
                        propietat.SetValue(Indicador, DateTime.Now);
                }
            }

            _context.IndicadorsEnergetics.Add(Indicador);
            _context.SaveChanges();

            return RedirectToPage("VeureIndicadors");
            
        }
    }
}
