using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PO_20222021_app.Modele
{
    internal class Kontrahent
    {
        [Column("Id")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int Id { get; set; }

        [Column("Nazwa")]
        [Required]
        public string Nazwa { get; set; }

        [Column("Adres")]
        [Required]
        public string Adres { get; set; }

        [Column("Telefon")]
        [Required]
        public int Telefon { get; set; }

        [Column("Email")]
        [Required]
        public string Email { get; set; }

        [Column("Pracownik_Id")]
        [Required]
        public int Pracownik_Id { get; set; }
    }
}