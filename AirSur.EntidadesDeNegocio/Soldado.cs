using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AirSur.EntidadesDeNegocio
{
    public class Soldado
    {
        [Key]
        public long id_soldado { get; set; }

        [Display(Name = "Edad del Soldado")]
        public int? edad { get; set; }

        [Display(Name = "Experiencia del Soldado")]
        public int? experiencia { get; set; }

        [Display(Name = "CapacidadCarga del Soldado")]
        public int? capacidadCarga { get; set; }

        public long idPais_Fk { get; set; }

        public long idProfesion_Fk { get; set; }

        public long idRango_Fk { get; set; }

        
    }
}
