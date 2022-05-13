using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AirSur.EntidadesDeNegocio
{
    public class TipoVehiculo
    {
        [Key]
        public long idTipoVehiculo { get; set; }
        public string nombre { get; set; }
    }
}
