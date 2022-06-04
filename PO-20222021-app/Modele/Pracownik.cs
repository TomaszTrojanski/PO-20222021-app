using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PO_20222021_app.Modele
{
    internal class Pracownik
    {
        [Column("Id")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int Id { get; set; }

        [Column("Imie")]
        [Required]
        public string Imie { get; set; }

        [Column("Nazwisko")]
        [Required]
        public string Nazwisko { get; set; }

        [Column("Stanowisko")]
        [Required]
        public string Stanowisko { get; set; }
    }
}