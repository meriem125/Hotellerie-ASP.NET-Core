using System.ComponentModel.DataAnnotations;

namespace HotellerieMariem.Models.HotellerieModel
{
    public class Hotel
    {
        public int Id { get; set; }
        public string Tel { get; set; }
        
        public string Pays { get; set; } = "Tunisie";
        [Required(ErrorMessage = "Le nom est obligatoire")]
        [StringLength(20, MinimumLength = 3,
            ErrorMessage = "Le nom doit contenir entre 3 et 20 caractères")]
        public string Nom { get; set; }

        [Range(1, 5, ErrorMessage = "Le nombre d'étoiles doit être entre 1 et 5")]
        public int Etoiles { get; set; }

        [Required(ErrorMessage = "La ville est obligatoire")]
        public string Ville { get; set; }

        [Required(ErrorMessage = "Le site web est obligatoire")]
        [Url(ErrorMessage = "URL invalide")]
        [Display(Name = "Site Web")]
        public string SiteWeb { get; set; }
    }
}