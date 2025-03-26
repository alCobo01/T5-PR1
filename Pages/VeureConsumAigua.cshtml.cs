using Microsoft.AspNetCore.Mvc.RazorPages;
using T5_PR1.Models;
using T5_PR1.Data;

namespace T5_PR1.Pages
{
    public class VeureConsumAiguaModel : PageModel
    {
        private readonly AppDbContext _context;
        public List<ConsumAigua>? Consums { get; set; }
        public List<ConsumAigua>? DeuMunicipisMesConsumidors { get; set; }
        public List<ConsumAigua>? ConsumMitjaPerComarca { get; set; }
        public List<ConsumAigua>? ConsumsSospitosos { get; set; }
        public List<string>? MunicipisAmbTendenciaCreixent { get; set; }

        public VeureConsumAiguaModel(AppDbContext context) => _context = context;

        public void OnGet()
        {
            Consums = _context.ConsumsAigua.ToList();
        }

        public void OnPostDelete(int id)
        {
            ConsumAigua consum = _context.ConsumsAigua.Find(id);
            _context.ConsumsAigua.Remove(consum);
            _context.SaveChanges();

            //Tornem a carregar les dades perquè es mostri la taula actualitzada
            Consums = _context.ConsumsAigua.ToList();
        }
    }
}
