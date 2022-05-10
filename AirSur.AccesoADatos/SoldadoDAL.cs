using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirSur.EntidadesDeNegocio;

namespace AirSur.AccesoADatos
{
    public class SoldadoDAL
    {
        bdaisurEntities _db = new bdaisurEntities();

        public bool guardar(soldado soldado)
        {
            _db.soldado.Add(soldado);
            _db.SaveChanges();
            return true;
        }

        public List<soldado> mostrarSoldados()
        {
            var query = (from s in _db.soldado select s);
            return query.ToList();
        }
        
    }
}
