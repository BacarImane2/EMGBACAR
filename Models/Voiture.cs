using System.ComponentModel.DataAnnotations;

namespace EMGBACAR.Models
{
    public class Voiture
    {
        public int Id { get; set; } 
        
        [Required]
        public string Nom { get; set; } 
        
        [Range(2010, 2100, ErrorMessage = "L'année doit être postérieure ou égale à 2010.")]
        public int Annee { get; set; } 

        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "Le prix doit être positif.")]
        public decimal Prix { get; set; } 
        [Required]
        public string Description { get; set; } 
        [Required]
        public bool EstVendue { get; set; } 
        [Required]
        public bool EstIndisponible { get; set; } 

        public int MarqueId { get; set; } 
        public Marque Marque { get; set; } 
    }
}
