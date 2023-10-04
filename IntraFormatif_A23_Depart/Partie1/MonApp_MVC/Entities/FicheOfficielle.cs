using System.ComponentModel.DataAnnotations;

namespace MonApp_MVC.Entities
{
    public class FicheOfficielle
    {
        public int Id { get; set; }
        [MaxLength(int.MaxValue)]
        public string Biographie { get; set; }
        [MaxLength(30)]
        public string Photo { get; set; }

        public int JoueurId { get; set; }
        public Joueur joueur { get; set; }
    }
}
