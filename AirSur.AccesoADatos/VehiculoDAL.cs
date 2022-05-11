using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirSur.AccesoADatos
{
    public class VehiculoDAL
    {
        bdaisurEntities dbconexion = new bdaisurEntities();

        public bool guardar(vehiculo vehiculo)
        {
            dbconexion.vehiculo.Add(vehiculo);
            dbconexion.SaveChanges();
            return true;
        }

        public List<vehiculo> mostrarVehiculos()
        {
            var query = (from s in dbconexion.vehiculo select s);
            return query.ToList();
        }
    }
}
