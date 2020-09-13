using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ProductosYPlanes.Datos.Conexion;
using ProductosYPlanes.Datos.Dao.Implementacion;
using ProductosYPlanes.Datos.Dao.Interfaz;
using ProductosYPlanes.Negocio.Entidades;



namespace ProductosYPlanes.Datos.Dao.Implementacion
{
    class PlanDaoSqlImp
    {
        //Vamos a reutilizar este método para crear cada objeto Per:
        public Plan findById(int id)
        {
            string sql = "SELECT * FROM PlanesDePrueba plan WHERE borrado = '0' AND plan.id_plan_prueba = " + id.ToString();
            DataTable planPruebaDT = DBHelper.getDBHelper().ConsultaSQL(sql);
            DataTable PlanProyectoDT = null;

            if (planPruebaDT != null && planPruebaDT.Rows.Count > 0)
            {
                sql = "SELECT PL.* FROM PlanesDePrueba PL, Proyecto PR WHERE PL.id_proyecto = PR.id_proyecto AND PL.id_plan_prueba = " + id;
                PlanProyectoDT = DBHelper.getDBHelper().ConsultaSQL(sql);
                if (PlanProyectoDT.Rows.Count > 0)
                    return mapper(PlanProyectoDT.Rows[0]); //, PlanProyectoDT
            }
            return null;
        } //Creo que funciona 

        /*public List<OpcionMenu> getOpcionesMenuAll()
        {
            List<OpcionMenu> lst = new List<OpcionMenu>();

            string query = "SELECT OM.* FROM  OpcionMenu OM";
            DataTable t = DBHelper.getDBHelper().ConsultaSQL(query);

            foreach (DataRow row in t.Rows)
            {
                int id = int.Parse(row["id_opcion_menu"].ToString());
                OpcionMenu op = new OpcionMenu(id, row["n_opcion"].ToString());
                lst.Add(op);
            }
            return lst;
        }*/

        public bool delete(int id)
        {
            //IMPORTANTE: en vez de hacer un delete, hacemos UPDATE porque es BORRADO LÓGICO 
            String sql = "UPDATE PlanesDePrueba SET borrado = 'S' WHERE id_plan_prueba=" + id;
            return DBHelper.getDBHelper().ejecutarSQL(sql) != 0;

        } //LISTO 

        private Plan mapper(DataRow PlanRow)
        {
            Plan oPlan = new Plan();

            oPlan.Id_Plan_Prueba = Convert.ToInt32(PlanRow["id_plan_prueba"].ToString());
            oPlan.Id_Proyecto = Convert.ToInt32(PlanRow["id_proyecto"].ToString());
            oPlan.Nombre = PlanRow["nombre"].ToString();
            oPlan.Id_Responsable = Convert.ToInt32(PlanRow["id_responsable"].ToString());
            oPlan.Descripcion = PlanRow["descripcion"].ToString();

            //agregamos este atributo tanto en la tabla como en la entidad
            //para trabajar solo con  registros activos, no borrados.
            oPlan.Borrado = PlanRow["borrado"].ToString().Equals("S");
       
        } // LISTO 

        public IList<Plan> getAll()
        {
            List<Plan> listadoPlanes = new List<Plan>();

            String strSql = string.Concat(" SELECT P.* ",
                                          "   FROM PlanesDePrueba  P",
                                          "  WHERE u.borrado = 0 ");

            var resultadoConsulta = DBHelper.getDBHelper().ConsultaSQL(strSql);

            foreach (DataRow row in resultadoConsulta.Rows)
            {
                listadoPlanes.Add(mapper(row));
            }

            return listadoPlanes;
            return null;
        } //LISTO 

        public bool add(Plan obj) //LISTO pero dudoso
        {
          string query = "DECLARE @id_plan_prueba int, @id_proyecto int, @nombre string, @id_responsable string, @descripcion string, @borrado char";
          query += "Insert INTO PlanesDePrueba (id_plan_prueba, id_proyecto, nombre, id_responsable, descripcion, borrado)";
          query +=" VALUES ('" + obj.Id_Plan_Prueba + "', '" + obj.Id_Proyecto +"', '" + obj.Id_Proyecto + "', '" + obj.Id_Responsable + "', '" + obj.Descripcion + "', 'N')";

            // Si una fila es afectada por la inserción retorna TRUE. Caso contrario FALSE
            return DBHelper.getDBHelper().ejecutarSQL(query) > 0;
        }

        public IList<Plan> GetByFilters(Dictionary<string, object> parametros)
        {
            List<Plan> lst = new List<Plan>();
            String strSql = string.Concat(" SELECT P.id_plan_prueba, ",
                                          " FROM PlanesDePrueba P ",
                                              "  WHERE P.borrado = N");

            if (parametros.ContainsKey("id_plan_prueba")) 
                strSql += " AND (P.id_plan_prueba = @id_plan_prueba) ";

            if (parametros.ContainsKey("id_proyecto"))
                strSql += " AND (P.id_proyecto = @id_proyecto) ";

            if (parametros.ContainsKey("nombre"))
                strSql += " AND (P.nombre LIKE '%' + @nombre + '%') ";

            if (parametros.ContainsKey("descripcion"))
                strSql += " AND (P.descripcion LIKE '%' + @descripcion + '%') ";

            if (parametros.ContainsKey("id_responsable"))
                strSql += " AND (P.id_responsable = @id_responsable) ";


            var resultado = DBHelper.getDBHelper().ConsultarSQLConParametros(strSql, new Object[] { parametros });

            foreach (DataRow row in resultado.Rows)
                lst.Add(mapper(row));

            return lst;
        } //PUEDE QUE FUNCIONE
    }
}
