using Microsoft.AspNetCore.Mvc.RazorPages;
using T5_PR1.Models;
using T5_PR1.Data;

namespace T5_PR1.Pages
{
    public class VeureIndicadorsModel : PageModel
    {
        private readonly AppDbContext _context;

        public List<IndicadorEnergetic>? Indicadors { get; set; }
        public List<IndicadorEnergetic>? ProduccionsNetesGrans { get; set; }
        public List<IndicadorEnergetic>? ConsumsGasolinaGrans { get; set; }
        public List<IndicadorEnergetic>? ProduccionsMitjaPerAny { get; set; }
        public List<IndicadorEnergetic>? DemandesIproduccionsGrans { get; set; }

        public VeureIndicadorsModel(AppDbContext context) => _context = context;

        public void OnGet()
        {
            Indicadors = _context.IndicadorsEnergetics.ToList();
        }

        public void OnPostDelete(int id)
        {
            IndicadorEnergetic indicador = _context.IndicadorsEnergetics.Find(id);
            _context.IndicadorsEnergetics.Remove(indicador);
            _context.SaveChanges();

            //Tornem a carregar les dades perquè es mostri la taula actualitzada
            Indicadors = _context.IndicadorsEnergetics.ToList();
        }
    }
}
