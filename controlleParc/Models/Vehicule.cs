using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace controlleParc.Models
{
    public class Vehicule
    {
        [Key]
        public int ImmatriculeId { get; set; }
        public string Marque { get; set; }
        public string Modele { get; set; }
        public int Puissance { get; set; }
        public int Carburant { get; set; }
        public DateTime DateAchat { get; set; }
        public Conducteur Conducteur { get; set; }


    }
}
