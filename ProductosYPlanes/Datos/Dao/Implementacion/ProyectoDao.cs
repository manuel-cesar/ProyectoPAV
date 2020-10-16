using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductosYPlanes.Negocio.Entidades;
using ProductosYPlanes.Datos.Conexion;
using System.Data;


namespace ProductosYPlanes.Datos.Dao.Implementacion
{
    public class ProyectoDao
    {
        public Proyecto findById(int id)
        {
            string sql = "SELCT * FROM Proyectos WHERE borrado = '0' AND id_proyecto = " + id.ToString();
            DataTable PlanProyectoDT = DBHelper.getDBHelper().ConsultaSQL(sql);
            
            return mapper(PlanProyectoDT.Rows[0]);
        }

        public IList<Proyecto> getAll()
        {
            List<Proyecto> listadoProyecto = new List<Proyecto>();

            String strSql = string.Concat(" SELECT * ",
                                          "   FROM proyectos  ",
                                          "  WHERE borrado = 0 ");

            var resultadoConsulta = DBHelper.getDBHelper().ConsultaSQL(strSql);
            if (resultadoConsulta.Rows.Count > 0)
            {
                foreach (DataRow row in resultadoConsulta.Rows)
                {
                    listadoProyecto.Add(mapper(row));
                }
                return listadoProyecto;
            }

            return null;
        } 

        private Proyecto mapper(DataRow PlanRow)
        {
            Proyecto oProyecto = new Proyecto();

            oProyecto.Id_Proyecto = Convert.ToInt32(PlanRow["id_proyecto"].ToString());
            oProyecto.Id_Producto = Convert.ToInt32(PlanRow["id_producto"].ToString());
            oProyecto.Version = Convert.ToInt32(PlanRow["version"].ToString());
            //oProyecto.Alcance = Convert.ToInt32(PlanRow["alcance"].ToString()); //Arregar linea 
            oProyecto.Id_Responsable = Convert.ToInt32(PlanRow["id_responsable"].ToString());
            oProyecto.Descripcion = PlanRow["descripcion"].ToString();
            oProyecto.Borrado = PlanRow["borrado"].ToString().Equals("S");

            return oProyecto;
        }

        public bool Update(Proyecto oProyecto)
        {
            string str_sql = "UPDATE Proyectos " +
                             " SET  id_proyecto = @id_proyecto, " +
                             "     id_producto = @id_producto, " +
                             "     version = @version ," +
                             "     alcance = @alcance," +
                             "     id_responsable = @id_responsable, " +
                             "     descripcion  = @descripcion " +
                             " WHERE id_proyecto = @id_proyecto";

            var parametros = new Dictionary<string, object>();
            parametros.Add("id_proyecto", oProyecto.Id_Proyecto);
            parametros.Add("id_producto", oProyecto.Id_Producto);
            parametros.Add("descripcion", oProyecto.Descripcion);
            parametros.Add("version", oProyecto.Version);
            parametros.Add("alcance", oProyecto.Alcance);
            parametros.Add("id_responsable", oProyecto.Id_Responsable);

            if ((DBHelper.getDBHelper().ejecutarSQL(str_sql, parametros)) == 1)

            {
                return true;
            }

            return false;
        }

        public bool CrearProyecto(Proyecto oProyecto)
        {
            string str_sql = "INSERT INTO Proyectos(id_proyecto, id_producto, descripcion, version, alcance ,id_responsable, borrado)" +
                            " VALUES (@id_proyecto,@id_producto,@descripcion,@version,@alcance, @id_responsable, 0)";


            var parametros = new Dictionary<string, object>();
            parametros.Add("id_proyecto", oProyecto.Id_Proyecto);
            parametros.Add("id_producto", oProyecto.Id_Producto);
            parametros.Add("version", oProyecto.Version);
            parametros.Add("alcance", oProyecto.Alcance);
            parametros.Add("id_responsable", oProyecto.Id_Responsable);
            parametros.Add("descripcion", oProyecto.Descripcion);


            if ((DBHelper.getDBHelper().ejecutarSQL(str_sql, parametros)) == 1)

            {
                return true;
            }

            return false;
        }

        public IList<Proyecto> GetByFilters(Dictionary<string, object> parametros)
        {
            List<Proyecto> lista = new List<Proyecto>();
            String strSql = string.Concat(" SELECT P.* ",
                                          " FROM Proyectos P ",
                                              "  WHERE P.borrado = '0'");

            if (parametros.ContainsKey("id_proyecto"))
                strSql += " AND (P.id_proyecto = @id_proyecto) ";


            if (parametros.ContainsKey("id_producto"))
                strSql += " AND (P.id_producto = @id_producto) ";

            if (parametros.ContainsKey("descripcion"))
                strSql += " AND (P.descripcion LIKE '%' + @descripcion + '%') ";

            if (parametros.ContainsKey("version"))
                strSql += " AND (P.version = @version) ";


            if (parametros.ContainsKey("alcance"))
                strSql += " AND (P.alcance = @alcance) ";

            if (parametros.ContainsKey("id_responsable"))
                strSql += " AND (P.id_responsable = @id_responsable) ";

            var resultado = (DataRowCollection)DBHelper.getDBHelper().ConsultaSQL(strSql, parametros).Rows;


            foreach (DataRow row in resultado)
                lista.Add(mapper(row));

            return lista;
        }

        public bool delete(int id)
        {
            //IMPORTANTE: en vez de hacer un delete, hacemos UPDATE porque es BORRADO LÓGICO 
            String sql = "UPDATE Proyectos SET borrado = 1 WHERE id_proyecto=" + id;
            return DBHelper.getDBHelper().ejecutarSQL(sql) != 0;

        } 
    }
}

