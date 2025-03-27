using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using T5_PR1.Data;
using T5_PR1.Models;
using T5_PR1.Models.Sistemes;

namespace T5_PR1.Pages
{
    public class EditarSimulacioModel : PageModel
    {
        private readonly AppDbContext _context;

        [BindProperty]
        public Simulacio Simulacio { get; set; }

        [BindProperty]
        public SistemaEnergia SistemaEnergia { get; set; }

        [BindProperty]
        public SistemaSolar SistemaSolar { get; set; }

        [BindProperty]
        public SistemaEolic SistemaEolic { get; set; }

        [BindProperty]
        public SistemaHidroelectric SistemaHidroelectric { get; set; }

        //Constructor per injecció de dependències
        public EditarSimulacioModel(AppDbContext context) { _context = context; }


        public void OnGet(int id)
        {
            Simulacio = _context.Simulacions.Find(id);

            SistemaEnergia = new SistemaEnergia();
            SistemaEnergia.Tipus = Simulacio.Tipus;

            SistemaSolar = new SistemaSolar();
            SistemaEolic = new SistemaEolic();
            SistemaHidroelectric = new SistemaHidroelectric();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid) { return Page(); }

            Simulacio.Tipus = SistemaEnergia.Tipus;
            switch (Simulacio.Tipus)
            {
                case TipusSistema.Solar:
                    Simulacio.Dada = SistemaSolar.HoresSol;
                    break;
                case TipusSistema.Eòlic:
                    Simulacio.Dada = SistemaEolic.VelocitatVent;
                    break;
                case TipusSistema.Hidroelèctric:
                    Simulacio.Dada = SistemaHidroelectric.Cabal;
                    break;
            }

            _context.Update(Simulacio);
            _context.SaveChanges();
            return RedirectToPage("./VeureSimulacions");
        }

    }
}
