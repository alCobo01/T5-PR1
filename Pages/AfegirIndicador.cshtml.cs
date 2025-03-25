﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using T5_PR1.Models;
using System.Text.Json;
using T5_PR1.Data;

namespace T5_PR1.Pages
{
    public class AfegirIndicadorModel : PageModel
    {
        private readonly AppDbContext _context;

        [BindProperty]
        public IndicadorEnergetic Indicador { get; set; }
        public List<IndicadorEnergetic>? Indicadors { get; set; }
        readonly string filePath = Path.GetFullPath(@"Files/indicadors_energetics_cat.json");

        //Constuctor per injecció de dependències
        public AfegirIndicadorModel(AppDbContext context) => _context = context;

        public void OnGet()
        {
            Indicador = new IndicadorEnergetic();
        }

        public IActionResult OnPost()
        {
            
            if (!ModelState.IsValid) return Page();

            _context.IndicadorsEnergetics.Add(Indicador);
            _context.SaveChanges();

            return RedirectToPage("VeureIndicadors");
            //try
            //{
            //    if (System.IO.File.Exists(filePath))
            //    {
            //        string jsonFromFile = System.IO.File.ReadAllText(filePath);
            //        var deserializedIndicadors = JsonSerializer.Deserialize<List<IndicadorEnergetic>>(jsonFromFile);
            //        Indicadors = deserializedIndicadors.ToList();
            //    }
            //    else
            //    {
            //        Indicadors = new List<IndicadorEnergetic>();
            //    }

            //    //Per no inserir valor nulls al JSON, introdueixo valors per defecte als camps amb valor null depenent del tipus de dada que són
            //    foreach (var propietat in typeof(IndicadorEnergetic).GetProperties())
            //    {
            //        var valorActual = propietat.GetValue(Indicador);
            //        if (valorActual == null)
            //        {
            //            if (propietat.PropertyType == typeof(string))
            //                propietat.SetValue(Indicador, "0.0%");
            //            else if (propietat.PropertyType == typeof(int))
            //                propietat.SetValue(Indicador, 0);
            //            else if (propietat.PropertyType == typeof(double))
            //                propietat.SetValue(Indicador, 0.0);
            //            else if (propietat.PropertyType == typeof(double?))
            //                propietat.SetValue(Indicador, 0.0);
            //            else if (propietat.PropertyType == typeof(DateTime))
            //                propietat.SetValue(Indicador, DateTime.Now);
            //        }
            //    }

            //    Indicadors.Add(Indicador);
            //    var jsonResult = JsonSerializer.Serialize(Indicadors, new JsonSerializerOptions { WriteIndented = true });
            //    System.IO.File.WriteAllText(filePath, jsonResult);

            //    return RedirectToPage("VeureIndicadors");
            //}
            //catch (Exception ex)
            //{
            //    ModelState.AddModelError(string.Empty, "Error al guardar l'arxiu JSON: " + ex.Message);
            //    return Page();
            //}



        }
    }
}
