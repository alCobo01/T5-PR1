using Microsoft.AspNetCore.Mvc.RazorPages;
using CsvHelper;
using System.Globalization;
using T5_PR1.Models.ConsultesLINQ;
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
            GetDataFromDatabase();
        }

        public void OnPostDelete(int id)
        {
            IndicadorEnergetic indicador = _context.IndicadorsEnergetics.Find(id);
            _context.IndicadorsEnergetics.Remove(indicador);
            _context.SaveChanges();

            //Tornem a carregar les dades perquè es mostri la taula actualitzada
            GetDataFromDatabase();
        }

        /// <summary>
        /// Obté les dades de la base de dades i les assigna a les propietats corresponents.
        /// </summary>
        private void GetDataFromDatabase()
        {
            Indicadors = _context.IndicadorsEnergetics.ToList();
            if (Indicadors.Count() != 0)
            {
                ProduccionsNetesGrans = ConsultesIndicadors.GetProdNetaGran(Indicadors);
                ConsumsGasolinaGrans = ConsultesIndicadors.GetConsumGasolinaGran(Indicadors);
                ProduccionsMitjaPerAny = ConsultesIndicadors.GetProduccioMitjaPerAny(Indicadors);
                DemandesIproduccionsGrans = ConsultesIndicadors.GetDemandaIproduccioGran(Indicadors);
            }
        }
    }
}
