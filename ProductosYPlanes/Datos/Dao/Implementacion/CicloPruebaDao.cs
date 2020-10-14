using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductosYPlanes.Negocio.Entidades;

namespace ProductosYPlanes.Datos.Dao.Implementacion
{
    class CicloPruebaDao
    {
        private CicloPrueba mapper(DataRow CicloPruebaRow)
        {
            CicloPrueba oCicloPrueba = new CicloPrueba();

            oCicloPrueba.Id_Ciclo_Prueba = Convert.ToInt32(CicloPruebaRow["id_CicloPrueba_prueba"].ToString());
            oCicloPrueba.Fecha_Inicio = Convert.ToDateTime(CicloPruebaRow["fecha_inicio"].ToString());
            oCicloPrueba.Fecha_Fin = Convert.ToDateTime(CicloPruebaRow["fecha_fin"].ToString());
            oCicloPrueba.Id_Responsable = Convert.ToInt32(CicloPruebaRow["id_responsable"].ToString());
            oCicloPrueba.Aceptado = Convert.ToBoolean(CicloPruebaRow["aceptado"].ToString());
            //agregamos este atributo tanto en la tabla como en la entidad para trabajar solo con  registros activos, no borrados.
            oCicloPrueba.Borrado = CicloPruebaRow["borrado"].ToString().Equals("S");

            return oCicloPrueba;
        } // LISTO
    }
}
