using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace controlleParc.Models
{
    public class EntretienVehicule
    {

        public int EntretienVehiculeId { get; set; }
        [ForeignKey("Vehicule")]
        public virtual int ImmatriculationId { get; set; }
        
        public virtual Vehicule Vehicule { get; set; }
       
        
       

        [ForeignKey("Entretien")]
        public virtual int EntretienId { get; set; }
        public virtual Entretien Entretien  { get; set; }
        
        public DateTime DateEntretien { get; set; }

        public int KilometreVehicule { get; set; }
    }
}
    
   
