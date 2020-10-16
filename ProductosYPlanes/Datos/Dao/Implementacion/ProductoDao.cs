using ProductosYPlanes.Datos.Conexion;
using ProductosYPlanes.Negocio.Entidades;

using System;
using System.Collections.Generic;
using System.Data;


namespace ProductosYPlanes.Datos.Dao.Implementacion
{
    class ProductoDao
    {
        public Producto findById(int id)
        {
            string sql = "SELECT * FROM Productos producto WHERE borrado = '0' AND producto.id_producto = " + id.ToString();
            DataTable productoPruebaDT = DBHelper.getDBHelper().ConsultaSQL(sql);

            DataTable ProductoProyectoDT = null;

            if (productoPruebaDT != null && productoPruebaDT.Rows.Count > 0)
            {
                sql = "SELECT PL.* FROM PlanesDePrueba PL, Proyecto PR WHERE PL.id_proyecto = PR.id_proyecto AND PL.id_plan_prueba = " + id;
                ProductoProyectoDT = DBHelper.getDBHelper().ConsultaSQL(sql);
                if (ProductoProyectoDT.Rows.Count > 0)
                    return mapper(ProductoProyectoDT.Rows[0]);
            }
            return null;
        }

        public bool delete(int id)
        {
            //IMPORTANTE: en vez de hacer un delete, hacemos UPDATE porque es BORRADO LÓGICO 
            String sql = "UPDATE Productos SET borrado = 1 WHERE id_producto =" + id;
            return DBHelper.getDBHelper().ejecutarSQL(sql) != 0;
        } 

        private Producto mapper(DataRow ProductoRow)
        {
            Producto oProducto = new Producto();

            oProducto.Id_Producto = Convert.ToInt32(ProductoRow["id_producto"].ToString());
            oProducto.Nombre = ProductoRow["nombre"].ToString();
            //agregamos este atributo tanto en la tabla como en la entidad para trabajar solo con  registros activos, no borrados.
            oProducto.Borrado = ProductoRow["borrado"].ToString().Equals("S");

            return oProducto;
        } 

        public IList<Producto> getAll()
        {
            List<Producto> listadoProductos = new List<Producto>();

            String strSql = string.Concat(" SELECT P.* ",
                                          "   FROM Productos  P",
                                          "  WHERE P.borrado = 0 ");

            var resultadoConsulta = DBHelper.getDBHelper().ConsultaSQL(strSql);
            if (resultadoConsulta.Rows.Count > 0)
            {
                foreach (DataRow row in resultadoConsulta.Rows)
                {
                    listadoProductos.Add(mapper(row));
                }
                return listadoProductos;
            }

            return null;
        } 

        public bool CrearProducto(Producto oProducto)
        {
            string str_sql = "SET IDENTITY_INSERT Productos ON INSERT INTO Productos (id_producto, nombre, borrado)" +
                            " VALUES (@id_producto, @nombre, 0) SET IDENTITY_INSERT Productos OFF";

            var parametros = new Dictionary<string, object>();
            parametros.Add("id_producto", oProducto.Id_Producto);
            parametros.Add("nombre", oProducto.Nombre);     
            
            if ((DBHelper.getDBHelper().ejecutarSQL(str_sql, parametros)) == 1)
            {
                return true;
            }
            return false;
        }

        public IList<Producto> GetByFilters(Dictionary<string, object> parametros)
        {
            List<Producto> lista = new List<Producto>();
            String strSql = string.Concat(" SELECT P.* ",
                                          " FROM Productos P ",
                                              "  WHERE P.borrado = 'False'");

            if (parametros.ContainsKey("id_producto"))
                strSql += " AND (P.id_producto = @id_producto) ";

            if (parametros.ContainsKey("nombre"))
                strSql += " AND (P.nombre LIKE '%' + @nombre + '%') ";

            var resultado = (DataRowCollection)DBHelper.getDBHelper().ConsultaSQL(strSql, parametros).Rows;

            foreach (DataRow row in resultado)
                lista.Add(mapper(row));

            return lista;
        }

        public bool Update(Producto oProducto)
        {
            string str_sql = "UPDATE Productos " +
                             " SET nombre =  @nombre " +
                             " WHERE id_producto = @id_producto";

            var parametros = new Dictionary<string, object>();
            parametros.Add("id_producto", oProducto.Id_Producto);
            parametros.Add("nombre", oProducto.Nombre);


            if ((DBHelper.getDBHelper().ejecutarSQL(str_sql, parametros)) == 1)

            {
                return true;
            }
            return false;
        }
    }
}
