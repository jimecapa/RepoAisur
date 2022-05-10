using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AirSur.EntidadesDeNegocio
{
    public class Marca
    {
        [Key]
        public int Id_Marca { get; set; }
        public string nombre { get; set; }
        [ForeignKey("Clasificacion")]
        public int IdClasificcion_Fk { get; set; }
    }
}
