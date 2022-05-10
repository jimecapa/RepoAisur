using AirSur.AccesoADatos;
using AirSur.EntidadesDeNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airsur.LogicaDeNegocio
{
    public class SoldadoBL
    {
        SoldadoDAL _metodos = new SoldadoDAL();
        public bool guardar(Soldado pSoldado)
        {
            soldado _soldado = new soldado();
            _soldado.id_soldado = pSoldado.id_soldado;
            _soldado.edad = pSoldado.edad;
            _soldado.experiencia = pSoldado.experiencia;
            _soldado.capacidadCarga = pSoldado.capacidadCarga;
            _soldado.idPais_Fk = pSoldado.idPais_Fk;
            _soldado.idProfesion_Fk = pSoldado.idProfesion_Fk;
            _soldado.idRango_Fk = pSoldado.idRango_Fk;

            return _metodos.guardar(_soldado);
        }

        public List<soldado> obtenerListaSoldados()
        {
            return _metodos.mostrarSoldados();
        }
    }
}
