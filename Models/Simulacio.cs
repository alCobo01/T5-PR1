using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace T5_PR1.Models
{
    public class Simulacio
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public TipusSistema? Tipus { get; set; }
        public DateTime Data { get; set; }
        public double Dada { get; set; }
        public double Rati { get; set; }
        public double Cost { get; set; }
        public double Preu { get; set; }
        public double EnergiaGenerada { get; set; }
        public double Benefici { get; set; }
    }
}
