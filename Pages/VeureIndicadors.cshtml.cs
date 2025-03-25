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

        public bool HasData { get; set; }
        public List<IndicadorEnergetic>? Indicadors { get; set; }
        public List<IndicadorEnergetic>? ProduccionsNetesGrans { get; set; }
        public List<IndicadorEnergetic>? ConsumsGasolinaGrans { get; set; }
        public List<IndicadorEnergetic>? ProduccionsMitjaPerAny { get; set; }
        public List<IndicadorEnergetic>? DemandesIproduccionsGrans { get; set; }

        public VeureIndicadorsModel(AppDbContext context) => _context = context;

        public void OnGet()
        {
            Indicadors = new List<IndicadorEnergetic>();

            Indicadors.AddRange(_context.IndicadorsEnergetics);

            if (Indicadors == null) { HasData = false; } 
            else { 
                HasData = true;
                ProduccionsNetesGrans = ConsultesIndicadors.GetProdNetaGran(Indicadors);
                ConsumsGasolinaGrans = ConsultesIndicadors.GetConsumGasolinaGran(Indicadors);
                ProduccionsMitjaPerAny = ConsultesIndicadors.GetProduccioMitjaPerAny(Indicadors);
                DemandesIproduccionsGrans = ConsultesIndicadors.GetDemandaIproduccioGran(Indicadors);
            }

                // Llegir el fitxer CSV
                //string filePathCSV = Path.GetFullPath(@"Files/indicadors_energetics_cat.csv");
                //try
                //{
                //    if (System.IO.File.Exists(filePathCSV))
                //    {
                //        HasData = true;

                //        using var reader = new StreamReader(filePathCSV);
                //        using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);

                //        var records = csv.GetRecords<IndicadorEnergetic>().ToList();
                //        Indicadors.AddRange(records);
                //    }
                //    else { HasData = false; }
                //}
                //catch (Exception ex) {
                //    Console.WriteLine(ex.Message);
                //    HasData = false; }

                //// Llegir el fitxer JSON
                //string filePathJSON = Path.GetFullPath(@"Files/indicadors_energetics_cat.json");
                //try
                //{
                //    if (System.IO.File.Exists(filePathJSON))
                //    {
                //        HasData = true;

                //        string jsonFromFile = System.IO.File.ReadAllText(filePathJSON);
                //        var records = System.Text.Json.JsonSerializer.Deserialize<List<IndicadorEnergetic>>(jsonFromFile);
                //        Indicadors.AddRange(records);
                //    }
                //}
                //catch (Exception) { HasData = false; }

                // Consultes LINQ
            

        }




    }
}
