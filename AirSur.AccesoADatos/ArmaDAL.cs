using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirSur.AccesoADatos
{
    public class ArmaDAL
    {
        bdaisurEntities bdconexion = new bdaisurEntities();
        public bool guardar(arma arma)
        {
            bdconexion.arma.Add(arma);
            bdconexion.SaveChanges();
            return true;
        }

        public List<arma> listarArma()
        {
            var query = (from a in bdconexion.arma select a);
            return query.ToList();
        }
    }
}
