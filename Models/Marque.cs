namespace EMGBACAR.Models
{
    public class Marque
    {
        public int Id { get; set; } // Identifiant unique
        public string? Nom { get; set; } // Nom de la marque

        public ICollection<Voiture>? Voitures { get; set; } // Liste des voitures associées
    }
}
