using Microsoft.AspNetCore.Mvc.RazorPages;
using T5_PR1.Models;
using T5_PR1.Models.ConsultesLINQ;
using T5_PR1.Data;

namespace T5_PR1.Pages
{
    public class VeureConsumAiguaModel : PageModel
    {
        private readonly AppDbContext _context;
        public List<ConsumAigua> Consums { get; set; }
        public List<ConsumAigua> DeuMunicipisMesConsumidors { get; set; }
        public List<ConsumAigua> ConsumMitjaPerComarca { get; set; }
        public List<ConsumAigua> ConsumsSospitosos { get; set; }
        public List<string> MunicipisAmbTendenciaCreixent { get; set; }

        public VeureConsumAiguaModel(AppDbContext context) => _context = context;

        public void OnGet()
        {
            Consums = _context.ConsumsAigua.ToList();

            //Consultes LINQ
            DeuMunicipisMesConsumidors = ConsultesAigua.GetDeuMunicipisMesConsumidors(Consums);
            ConsumMitjaPerComarca = ConsultesAigua.GetConsumMitjaPerComarca(Consums);
            ConsumsSospitosos = ConsultesAigua.GetConsumsSospitosos(Consums);
            MunicipisAmbTendenciaCreixent = ConsultesAigua.GetMunicipisAmbTendenciaCreixent(Consums);
        }
    }
}
