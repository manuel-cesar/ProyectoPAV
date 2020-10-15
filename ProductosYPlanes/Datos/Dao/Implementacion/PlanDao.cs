using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ProductosYPlanes.Datos.Conexion;
using ProductosYPlanes.Negocio.Entidades;

namespace ProductosYPlanes.Datos.Dao.Implementacion

{
    public class PlanDao
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
            String sql = "UPDATE PlanesDePrueba SET borrado = 1 WHERE id_plan_prueba=" + id;
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
            //agregamos este atributo tanto en la tabla como en la entidad para trabajar solo con  registros activos, no borrados.
            oPlan.Borrado = PlanRow["borrado"].ToString().Equals("S"); 
            
            return oPlan;
        } // LISTO 

        public IList<Plan> getAll()
        {
            List<Plan> listadoPlanes = new List<Plan>();

            String strSql = string.Concat(" SELECT P.* ",
                                          "   FROM PlanesDePrueba  P",
                                          "  WHERE P.borrado = 0 ");

            var resultadoConsulta = DBHelper.getDBHelper().ConsultaSQL(strSql);
            if (resultadoConsulta.Rows.Count > 0)
            {
                foreach (DataRow row in resultadoConsulta.Rows)
                {
                    listadoPlanes.Add(mapper(row));
                }
                return listadoPlanes;
            }

                return null;
        } //LISTO 

        public bool CrearPlan(Plan oPlan) 
        {
            string str_sql ="SET IDENTITY_INSERT PlanesDePrueba ON INSERT INTO PlanesDePrueba (id_plan_prueba, id_proyecto, nombre, id_responsable, descripcion, borrado)" +
                            " VALUES (@id_plan_prueba, @id_proyecto, @nombre, @id_responsable, @descripcion, 0) SET IDENTITY_INSERT PlanesDePrueba OFF";


            var parametros = new Dictionary<string, object>();
            parametros.Add("id_plan_prueba", oPlan.Id_Plan_Prueba);
            parametros.Add("id_proyecto", oPlan.Id_Proyecto);
            parametros.Add("nombre", oPlan.Nombre);
            parametros.Add("id_responsable", oPlan.Id_Responsable);
            parametros.Add("descripcion", oPlan.Descripcion);
            

            if ((DBHelper.getDBHelper().ejecutarSQL(str_sql, parametros)) == 1)

            {
                return true;
            }

            return false;



        }

        public IList<Plan> GetByFilters(Dictionary<string, object> parametros)
        {       
            List<Plan> lista = new List<Plan>();
            String strSql = string.Concat(" SELECT P.* ",
                                          " FROM PlanesDePrueba P ",
                                              "  WHERE P.borrado = 'False'");

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


            //var resultado = DBHelper.getDBHelper().ConsultaSQL(strSql, parametros );

            var resultado = (DataRowCollection)DBHelper.getDBHelper().ConsultaSQL(strSql, parametros).Rows;


            foreach (DataRow row in resultado)
                lista.Add(mapper(row));

            return lista;
        } //PUEDE QUE FUNCIONE

        public bool Update(Plan oPlan)
        {
            string str_sql = "UPDATE PlanesDePrueba " +
                             " SET id_proyecto = @id_proyecto, " +
                             "     nombre = @nombre ," +
                             "     id_responsable = @id_responsable, " +
                             "     descripcion  = @descripcion " +
                             " WHERE id_plan_prueba = @id_plan_prueba";
           
            var parametros = new Dictionary<string, object>();
            parametros.Add("id_plan_prueba", oPlan.Id_Plan_Prueba);
            parametros.Add("id_proyecto", oPlan.Id_Proyecto);
            parametros.Add("nombre", oPlan .Nombre);
            parametros.Add("id_responsable", oPlan.Id_Responsable);
            parametros.Add("descripcion", oPlan.Descripcion);

           if( (DBHelper.getDBHelper().ejecutarSQL(str_sql, parametros) )== 1)

            {
                return true;
            }

            return false;

        }

    }
}
