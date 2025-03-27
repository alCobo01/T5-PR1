using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using T5_PR1.Models;
using T5_PR1.Models.Sistemes;
using T5_PR1.Data;

namespace T5_PR1.Pages
{
    public class AfegirSimulacioModel : PageModel
    {
        private readonly AppDbContext _context;

        [BindProperty]
        public SistemaEnergia SistemaEnergia { get; set; }

        [BindProperty]
        public SistemaSolar SistemaSolar { get; set; }

        [BindProperty]
        public SistemaEolic SistemaEolic { get; set; }

        [BindProperty]
        public SistemaHidroelectric SistemaHidroelectric { get; set; }

        //Constuctor per injecció de dependències
        public AfegirSimulacioModel(AppDbContext context) => _context = context;

        public void OnGet()
        {
            SistemaSolar = new SistemaSolar();
            SistemaEolic = new SistemaEolic();
            SistemaHidroelectric = new SistemaHidroelectric();
            SistemaEnergia = new SistemaEnergia();
        }

        public IActionResult OnPost()
        {
            Simulacio simulacio;

            ModelState.Clear();
            switch (SistemaEnergia.Tipus)
            {
                case TipusSistema.Solar:
                    SistemaSolar.Data = SistemaEnergia.Data;
                    SistemaSolar.Rati = SistemaEnergia.Rati;
                    SistemaSolar.Cost = SistemaEnergia.Cost;
                    SistemaSolar.Preu = SistemaEnergia.Preu;

                    if (!TryValidateModel(SistemaSolar)) return Page();

                    simulacio = new Simulacio
                    {
                        Tipus = SistemaEnergia.Tipus,
                        Data = SistemaSolar.Data,
                        Dada = SistemaSolar.HoresSol,
                        Rati = SistemaSolar.Rati,
                        Cost = SistemaSolar.Cost,
                        Preu = SistemaSolar.Preu,
                        EnergiaGenerada = SistemaSolar.CalcularEnergiaGenerada(),
                        Benefici = SistemaSolar.CalcularBenefici()
                    };
                    break;
                case TipusSistema.Eòlic:
                    SistemaEolic.Data = SistemaEnergia.Data;
                    SistemaEolic.Rati = SistemaEnergia.Rati;
                    SistemaEolic.Cost = SistemaEnergia.Cost;
                    SistemaEolic.Preu = SistemaEnergia.Preu;

                    if (!TryValidateModel(SistemaEolic)) return Page();

                    simulacio = new Simulacio
                    {
                        Tipus = SistemaEnergia.Tipus,
                        Data = SistemaEolic.Data,
                        Dada = SistemaEolic.VelocitatVent,
                        Rati = SistemaEolic.Rati,
                        Cost = SistemaEolic.Cost,
                        Preu = SistemaEolic.Preu,
                        EnergiaGenerada = SistemaEolic.CalcularEnergiaGenerada(),
                        Benefici = SistemaEolic.CalcularBenefici()
                    };
                    break;
                case TipusSistema.Hidroelèctric:
                    SistemaHidroelectric.Data = SistemaEnergia.Data;
                    SistemaHidroelectric.Rati = SistemaEnergia.Rati;
                    SistemaHidroelectric.Cost = SistemaEnergia.Cost;
                    SistemaHidroelectric.Preu = SistemaEnergia.Preu;

                    if (!TryValidateModel(SistemaHidroelectric)) return Page();

                    simulacio = new Simulacio
                    {
                        Tipus = SistemaEnergia.Tipus,
                        Data = SistemaHidroelectric.Data,
                        Dada = SistemaHidroelectric.Cabal,
                        Rati = SistemaHidroelectric.Rati,
                        Cost = SistemaHidroelectric.Cost,
                        Preu = SistemaHidroelectric.Preu,
                        EnergiaGenerada = SistemaHidroelectric.CalcularEnergiaGenerada(),
                        Benefici = SistemaHidroelectric.CalcularBenefici()
                    };
                    break;
                default:
                    return Page();
            }

            _context.Simulacions.Add(simulacio);
            _context.SaveChanges();

            return RedirectToPage("VeureSimulacions");
        }

    }
}
