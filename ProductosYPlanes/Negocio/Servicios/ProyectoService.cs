using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductosYPlanes.Datos.Dao.Implementacion;
using ProductosYPlanes.Negocio.Entidades;

namespace ProductosYPlanes.Negocio.Servicios
{
    public class ProyectoService
    {
        private ProyectoDao oProyectoDao;

        public ProyectoService()
        {
            oProyectoDao = new ProyectoDao();
        }

        public bool ActualizarProyecto(Proyecto OProyectoSelected)
        {
            return oProyectoDao.Update(OProyectoSelected);
        }

        internal bool crearProyecto(Proyecto oProyecto)
        {
            return oProyectoDao.CrearProyecto(oProyecto);
        }

        public IList<Proyecto> ConsultarProyectoConFiltros(Dictionary<string, object> parametros)
        {
            return oProyectoDao.GetByFilters(parametros);
        }

        public bool EliminarProyecto(int idProyecto)
        {
            return oProyectoDao.delete(idProyecto);
        }
    }
}
