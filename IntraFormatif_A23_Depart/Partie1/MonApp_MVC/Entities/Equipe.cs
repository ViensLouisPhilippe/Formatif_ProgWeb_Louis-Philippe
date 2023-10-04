using System.ComponentModel.DataAnnotations;

namespace MonApp_MVC.Entities
{
    public class Equipe
    {
        public int Id { get; set; }

        [StringLength(15, MinimumLength = 5)]
        public string Nom { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime DateCreation { get; set; }

        [StringLength(25, MinimumLength =5)]
        public string Proprietaire { get; set; }

        public List<Joueur>? joueurs { get; set; }

        public List<Tournoi>? tournois { get; set; }
    }
}
