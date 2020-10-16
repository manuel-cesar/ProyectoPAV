using System.Collections.Generic;

using ProductosYPlanes.Datos.Dao.Implementacion;
using ProductosYPlanes.Negocio.Entidades;

namespace ProductosYPlanes.Negocio.Servicios
{
    public class CasoPruebaService
    {
        private CasoPruebaDao oCasoPruebaDao;
        public CasoPruebaService()
        {
            oCasoPruebaDao = new CasoPruebaDao();
        }
        public IList<CasoPrueba> ConsultarCasoPruebaConFiltros(Dictionary<string, object> parametros)
        {
            return oCasoPruebaDao.GetByFilters(parametros);
        }

        public IList<CasoPrueba> ConsultarTodos()
        {
            return oCasoPruebaDao.getAll();
        }

          public bool ActualizarCasoPrueba(CasoPrueba OCasoPruebaSelected)
        {
            return oCasoPruebaDao.Update(OCasoPruebaSelected);
        }

        internal bool crearCasoPrueba(CasoPrueba oCasoPrueba)
        {
            return oCasoPruebaDao.CrearCasoPrueba(oCasoPrueba);
        }

        public bool EliminarCasoPrueba(int idCasoPrueba)
        {
            return oCasoPruebaDao.delete(idCasoPrueba);
        }

        public int consultarMaxId()
        {
            return oCasoPruebaDao.consultarMaxId();
        }


    }
}
