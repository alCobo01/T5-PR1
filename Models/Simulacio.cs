using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using T5_PR1.Models.Missatges;

namespace T5_PR1.Models
{
    public class Simulacio
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = MissatgesSistemes.TipusObligatori)]
        public TipusSistema? Tipus { get; set; }

        [Required(ErrorMessage = MissatgesIndicador.RequiredData)]
        public DateTime Data { get; set; }

        [Required(ErrorMessage = MissatgesSistemes.RatiObligatori)]
        public double Dada { get; set; }

        [Required(ErrorMessage = MissatgesSistemes.RatiObligatori)]
        [Range(0.1d, 0.3d, ErrorMessage = MissatgesSistemes.RatiForaRang)]
        public double Rati { get; set; }

        [Required(ErrorMessage = MissatgesSistemes.CostObligatori)]
        public double Cost { get; set; }

        [Required(ErrorMessage = MissatgesSistemes.PreuObligatori)]
        public double Preu { get; set; }

        [Required(ErrorMessage = MissatgesSistemes.RatiObligatori)]
        public double EnergiaGenerada { get; set; }

        [Required(ErrorMessage = MissatgesSistemes.RatiObligatori)]
        public double Benefici { get; set; }
    }
}
