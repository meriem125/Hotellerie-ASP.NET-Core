using System.ComponentModel.DataAnnotations;

namespace HotellerieMariem.Models.HotellerieModel
{
    public class Appreciation
    {
        [Required(ErrorMessage = "La note est obligatoire")]
        [Range(1, 5, ErrorMessage = "La note doit être entre 1 et 5")]
        public int Note { get; set; }
        public int Id { get; set; }

        [Required(ErrorMessage = "Le nom est obligatoire")]
        [Display(Name = "Nom Personne")]
        public string NomPers { get; set; }

        [Required(ErrorMessage = "Le commentaire est obligatoire")]
        [DataType(DataType.MultilineText)]
        public string Commentaire { get; set; }

        public int HotelId { get; set; }
        public Hotel Hotel { get; set; }
    }
}