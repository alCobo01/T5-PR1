using T5_PR1.Models;
using CsvHelper;
using System.Globalization;
using CsvHelper.Configuration;

namespace T5_PR1.Data
{
    public class DbInitializer
    {
        private readonly AppDbContext _context;

        public DbInitializer(AppDbContext context) => _context = context;

        /// <summary>
        /// Inicialitza la base de dades amb dades de consum d'aigua i indicadors energètics si no existeixen.
        /// </summary>
        public void Seed()
        {
            if (!_context.ConsumsAigua.Any())
            {
                var consums = ReadCsv<ConsumAigua>(Path.GetFullPath(@"Files/consum_aigua_cat_per_comarques.csv"));
                _context.ConsumsAigua.AddRange(consums);
            }

            if (!_context.IndicadorsEnergetics.Any())
            {
                var indicadors = ReadCsv<IndicadorEnergetic>(Path.GetFullPath(@"Files/indicadors_energetics_cat.csv"));
                _context.IndicadorsEnergetics.AddRange(indicadors);
            }

            _context.SaveChanges();
        }

        /// <summary>
        /// Llegeix un fitxer CSV i retorna una llista d'objectes del tipus especificat.
        /// </summary>
        /// <typeparam name="T">El tipus d'objectes a retornar.</typeparam>
        /// <param name="path">El camí del fitxer CSV.</param>
        /// <returns>Una llista d'objectes del tipus especificat.</returns>
        private static List<T> ReadCsv<T>(string path)
        {
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                MissingFieldFound = null,
                HeaderValidated = null
            };

            using (var reader = new StreamReader(path))
            using (var csv = new CsvReader(reader, config))
            {
                return csv.GetRecords<T>().ToList();
            }
        }
    }
}
