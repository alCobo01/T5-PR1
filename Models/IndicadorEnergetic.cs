using CsvHelper.Configuration.Attributes;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using T5_PR1.Models.Missatges;

namespace T5_PR1.Models
{
    public class IndicadorEnergetic
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = MissatgesIndicador.RequiredData)]
        public DateTime Data { get; set; }
        
        [Required(ErrorMessage = MissatgesIndicador.RequiredCDEEBC_ProdNeta)]
        public double CDEEBC_ProdNeta { get; set; }

        [Required(ErrorMessage = MissatgesIndicador.RequiredCDEEBC_ProdDisp)]
        public double CDEEBC_ProdDisp { get; set; }

        [Required(ErrorMessage = MissatgesIndicador.RequiredCDEEBC_DemandaElectr)]
        public double CDEEBC_DemandaElectr { get; set; }

        [Required(ErrorMessage = MissatgesIndicador.RequiredCCAC_GasolinaAuto)]
        public double CCAC_GasolinaAuto { get; set; }
    }
}

