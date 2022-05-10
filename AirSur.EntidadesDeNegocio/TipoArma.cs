using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AirSur.EntidadesDeNegocio
{
    public class TipoArma
    {
        [Key]
        public int Id_tipoArma { get; set; }
        public string Nombre { get; set; }
        public string Clasificacion { get; set; }
    }
}
