using ProductosYPlanes.Datos.Dao.Implementacion;
using ProductosYPlanes.Negocio.Entidades;

using System;
using System.Collections.Generic;


namespace ProductosYPlanes.Negocio.Servicios
{
    public class CicloPruebaService
    {
        private CicloPruebaDao oCicloPruebaDao;
        public CicloPruebaService()
        {
            oCicloPruebaDao = new CicloPruebaDao();
        }

        internal bool ValidarDatos(CicloPrueba cicloPrueba)
        {
            if (cicloPrueba.CicloPruebaDetalle.Count == 0)
            {
                throw new Exception("Debe ingresar al menos un ciclo de Prueba.");
            }
            return true;
        }

        internal bool Crear(CicloPrueba ciclo)
        {
            return oCicloPruebaDao.Create(ciclo);
        }

        public IList<CicloPrueba> ConsultarTodos()
        {
            return oCicloPruebaDao.getAll();
        }

        public int consultarMaxId()
        {
            return oCicloPruebaDao.consultarMaxId();
        }
    }
}
