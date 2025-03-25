﻿using CsvHelper.Configuration.Attributes;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using T5_PR1.Models.Missatges;

namespace T5_PR1.Models
{
    public class ConsumAigua
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Name("Any")]
        [Required(ErrorMessage = MissatgesAigua.RequiredAny)]
        public int Any { get; set; }

        [Name("Codi comarca")]
        [Required(ErrorMessage = MissatgesAigua.RequiredCodiComarca)]
        public string? CodiComarca { get; set; }

        [Name("Comarca")]
        [Required(ErrorMessage = MissatgesAigua.RequiredComarca)]
        public string? Comarca { get; set; }

        [Name("Població")]
        [Required(ErrorMessage = MissatgesAigua.RequiredPoblacio)]
        public string? Poblacio { get; set; }

        [Name("Domèstic xarxa")]
        [Required(ErrorMessage = MissatgesAigua.RequiredDomesticXarxa)]
        public double DomesticXarxa { get; set; }

        [Name("Activitats econòmiques i fonts pròpies")]
        [Required(ErrorMessage = MissatgesAigua.RequiredActivitatsEconomiquesIFontsPropies)]
        public double ActivitatsEconomiquesIFontsPropies { get; set; }

        [Name("Total")]
        [Required(ErrorMessage = MissatgesAigua.RequiredTotal)]
        public double Total { get; set; }

        [Name("Consum domèstic per càpita")]
        [Required(ErrorMessage = MissatgesAigua.RequiredConsumDomesticPerCapita)]
        public double ConsumDomesticPerCapita { get; set; }
    }
}
