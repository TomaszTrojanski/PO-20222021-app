using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PO_20222021_app.Modele
{
    internal class Aplikacja
    {
        [Column("Id")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int Id { get; set; }

        [Column("Nazwa")]
        [Required]
        public string Nazwa { get; set; }

        [Column("Wersja")]
        [Required]
        public float Wersja { get; set; }

        [Column("Cena")]
        [Required]
        public int Cena { get; set; }
    }
}