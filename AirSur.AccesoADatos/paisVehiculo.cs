//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AirSur.AccesoADatos
{
    using System;
    using System.Collections.Generic;
    
    public partial class paisVehiculo
    {
        public long id_paisVehiculo { get; set; }
        public Nullable<long> idPais_Fk { get; set; }
        public Nullable<long> idVehiculo_Fk { get; set; }
    
        public virtual pais pais { get; set; }
        public virtual vehiculo vehiculo { get; set; }
    }
}
