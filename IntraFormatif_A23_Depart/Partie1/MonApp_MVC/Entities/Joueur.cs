using System.ComponentModel.DataAnnotations;

namespace MonApp_MVC.Entities
{
    public class Joueur
    {
        public int Id { get; set; }
        [StringLength(15, MinimumLength =5)]
        public string Prenom { get; set; }
        [StringLength(15, MinimumLength =5)]
        public string Nom { get; set; }
        [StringLength(10, MinimumLength =5)]
        public string Position { get; set; }

        public int? ficheOfficielleId { get; set; }
        public FicheOfficielle? ficheOfficielle { get; set; }

        public int equipeId { get; set; }
        public Equipe equipe { get; set; }
    }
}
