using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PO_20222021_app.Modele
{
    internal class Licencja
    {
        [Column("Id")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int Id { get; set; }

        [Column("Nazwa")]
        [Required]
        public string Nazwa { get; set; }

        [Column("Data_wygasniecia")]
        [Required]
        public DateTime Data_wygasniecia { get; set; }

        [Column("Aplikacja_Id")]
        [Required]
        public int Aplikacja_Id { get; set; }
    }
}