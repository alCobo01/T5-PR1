using Microsoft.AspNetCore.Mvc.RazorPages;
using T5_PR1.Data;
using T5_PR1.Models;

namespace T5_PR1.Pages
{
    public class VeureSimulacionsModel : PageModel
    {
        private readonly AppDbContext _context;
        public List<Simulacio>? Simulacions { get; set; }

        public VeureSimulacionsModel(AppDbContext context) => _context = context;

        public void OnGet()
        {
            Simulacions = _context.Simulacions.ToList();
        }

        public void OnPostDelete(int id)
        {
            Simulacio simulacio = _context.Simulacions.Find(id);
            _context.Simulacions.Remove(simulacio);
            _context.SaveChanges();

            //Tornem a carregar les dades perquè es mostri la taula actualitzada
            Simulacions = _context.Simulacions.ToList();
        }

    }
}
