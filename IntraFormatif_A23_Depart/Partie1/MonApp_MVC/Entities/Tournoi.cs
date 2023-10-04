using System.ComponentModel.DataAnnotations;

namespace MonApp_MVC.Entities
{
    public class Tournoi
    {
        public int Id { get; set; }

        [StringLength(15, MinimumLength = 5)]
        public string Titre { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime DateDebut { get; set; }

        public List<Equipe>? equipes { get; set; }
    }
}
