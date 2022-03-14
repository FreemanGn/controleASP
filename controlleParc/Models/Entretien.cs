using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace controlleParc.Models
{
    public class Entretien
    {
        public int EntretienId { get; set; }
        public string NomEntretien { get; set; }
        public int Frequence { get; set; }
        public string Periode { get; set; }
        public int Kilometrage { get; set; }
        public int Montant { get; set; }
    }
}
