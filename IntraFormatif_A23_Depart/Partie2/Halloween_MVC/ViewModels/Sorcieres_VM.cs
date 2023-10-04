using Halloween.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Security.Policy;

namespace Halloween.ViewModels
{
    public class Sorcieres_VM
    {
        public Sorciere Sorciere { get; set; }
        [DisplayName("Nombre de potions créées")]
        public int nbrPotion { get; set; }
        [DisplayName("Moyenne du volume des potions créées")]
        public decimal volumeMoyenPotion { get; set; }
    }
}
