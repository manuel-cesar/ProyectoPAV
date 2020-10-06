using ProductosYPlanes.Datos.Dao.Implementacion;
using ProductosYPlanes.Datos.Dao.Interfaz;
using ProductosYPlanes.Negocio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProductosYPlanes.Negocio.Servicios
{
    public class ProductoService
    {
        private ProductoDao oProductoDao;
        public ProductoService()
        {
            oProductoDao = new ProductoDao();
        }
        public IList<Producto> ConsultarProductoConFiltros(Dictionary<string, object> parametros)
        {
            return oProductoDao.GetByFilters(parametros);
        }

        public IList<Producto> ConsultarTodos()
        {
            return oProductoDao.getAll();
        }

        public Producto ConsultarProductoPorId(int id)
        {
            return oProductoDao.findById(id);
        }

        public bool ActualizarProducto(Producto OProductoSelected)
        {
            return oProductoDao.Update(OProductoSelected);
        }

        internal bool crearProducto(Producto oProducto)
        {
            return oProductoDao.CrearProducto(oProducto);
        }

        public bool EliminarProducto(int idProducto)
        {
            return oProductoDao.delete(idProducto);
        }


    }
}