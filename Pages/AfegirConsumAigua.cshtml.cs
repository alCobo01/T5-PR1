using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Xml.Linq;
using T5_PR1.Data;
using T5_PR1.Models;

namespace T5_PR1.Pages
{
    public class AfegirConsumAiguaModel : PageModel
    {
        private readonly AppDbContext _context;

        [BindProperty]
        public ConsumAigua ConsumAigua { get; set; }

        readonly string filePath = Path.GetFullPath(@"Files/consum_aigua_cat_per_comarques.xml");

        //Constuctor per injecció de dependències
        public AfegirConsumAiguaModel(AppDbContext context) => _context = context;

        public void OnGet()
        {
            ConsumAigua = new ConsumAigua();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid) return Page();

            _context.ConsumsAigua.Add(ConsumAigua);
            _context.SaveChanges();

            //try
            //{
            //    XDocument doc;

            //    if (System.IO.File.Exists(filePath))
            //    {
            //        doc = XDocument.Load(filePath);
            //    }
            //    else
            //    {
            //        doc = new XDocument(
            //            new XDeclaration("1.0", "utf-8", "yes"),
            //            new XElement("Consums")
            //        );
            //    }

            //    XElement newConsum = new XElement("Consum",
            //        new XElement("Any", ConsumAigua.Any),
            //        new XElement("CodiComarca", ConsumAigua.CodiComarca),
            //        new XElement("Comarca", ConsumAigua.Comarca),
            //        new XElement("Poblacio", ConsumAigua.Poblacio),
            //        new XElement("DomesticXarxa", ConsumAigua.DomesticXarxa),
            //        new XElement("ActivitatsEconomiquesIFontsPropies", ConsumAigua.ActivitatsEconomiquesIFontsPropies),
            //        new XElement("Total", ConsumAigua.Total),
            //        new XElement("ConsumDomesticPerCapita", ConsumAigua.ConsumDomesticPerCapita)
            //    );

            //    doc.Root.Add(newConsum);

            //    doc.Save(filePath);


            //}
            //catch (Exception ex)
            //{
            //    ModelState.AddModelError(string.Empty, "Error al guardar l'arxiu XML: " + ex.Message);
            //    return Page();
            //}

            return RedirectToPage("VeureConsumAigua");
        }
    }
}
