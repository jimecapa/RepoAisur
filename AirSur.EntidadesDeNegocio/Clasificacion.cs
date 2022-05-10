using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AirSur.EntidadesDeNegocio
{
    public class Clasificacion
    {
        [Key]
        public int Id_clasificacion { get; set; }
        public string NombreClasificacion { get; set; }
    }
}
