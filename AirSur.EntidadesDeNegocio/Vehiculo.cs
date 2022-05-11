using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AirSur.EntidadesDeNegocio
{
    public class Vehiculo
    {
        [Key]
        public long Id_vehiculo { get; set; }
        public string Nombre { get; set; }
        public int Cilindraje { get; set; }
        public int CapacidadCargaMunicion { get; set; }
        //[ForeignKey("TipoVehiculo")]
        public long IdTipoVehiculo_Fk { get; set; }
        //[ForeignKey("Marca")]
        public long IdMarca_FK { get; set; }
    }
}
