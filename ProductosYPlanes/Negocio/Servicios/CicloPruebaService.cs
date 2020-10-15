using ProductosYPlanes.Datos.Dao.Implementacion;
using ProductosYPlanes.Negocio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        //public IList<CicloPrueba> ConsultarCicloPruebaConFiltros(Dictionary<string, object> parametros)
        //{
        //    return oCicloPruebaDao.GetByFilters(parametros);
        //}

        //public IList<CicloPrueba> ConsultarTodos()
        //{
        //    return oCicloPruebaDao.getAll();
        //}

        //public CicloPrueba ConsultarCicloPruebaPorId(int id)
        //{
        //    return oCicloPruebaDao.findById(id);
        //}

        //public bool ActualizarCicloPrueba(CicloPrueba OCicloPruebaSelected)
        //{
        //    return oCicloPruebaDao.Update(OCicloPruebaSelected);
        //}

        //internal bool crearCicloPrueba(CicloPrueba oCicloPrueba)
        //{
        //    return oCicloPruebaDao.CrearCicloPrueba(oCicloPrueba);
        //}

        //public bool EliminarCicloPrueba(int idCicloPrueba)
        //{
        //    return oCicloPruebaDao.delete(idCicloPrueba);
        //}


    }
}
