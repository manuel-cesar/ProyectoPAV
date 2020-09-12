using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActualizarUsuarios.Datos.Dao.Implementacion
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
                    return mapper(perfileDT.Rows[0], opcionesMenuDT);
            }
            return null;
        }

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

        public List<Perfil> FindByNombre(string filter)
        {
            string sql = "SELECT id_perfil FROM Perfiles WHERE borrado = 'N' AND n_perfil LIKE '%' + @param1 + '%'";
            DataTable data = DBHelper.getDBHelper().ConsultarSQLConParametros(sql, new Object[] { filter });
            List<Perfil> list = new List<Perfil>();
            foreach (DataRow row in data.Rows)
            {
                int id = Convert.ToInt32(row[0].ToString());
                list.Add(findById(id));
            }

            return list;
        }

        public List<OpcionMenu> getOpcionesByPerfil(int id)
        {
            return findById(id).OpcionesMenu;
        }


        public bool delete(int id)
        {
            //IMPORTANTE: en vez de hacer un delete, hacemos UPDATE porque es BORRADO LÓGICO 
            String sql = "UPDATE Perfiles SET borrado = 'S' WHERE id_perfil=" + id;
            return DBHelper.getDBHelper().ejecutarSQL(sql) != 0;

        }

        private Plan mapper(DataRow PlanRow)
        {
          Plan oPlan = new Plan();

            oPlan.Id = Convert.ToInt32(PlanRow["id_plan_prueba"].ToString());
            oPlan.Id_Proyecto = PlanRow["id_proyecto"].ToString();
            oPlan.Nombre = PlanRow["nombre"].toString();
            oPlan.Id_Responsable = = Convert.ToInt32(PlanRow["id_responsable"].ToString());
            oPlan.Descripcion = PlanRow["descripcion"].toString();

            //agregamos este atributo tanto en la tabla como en la entidad
            //para trabajar solo con  registros activos, no borrados.
            oPlan.Borrado = planRow["borrado"].ToString().Equals("S");
       
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
                listadoPlanes.Add(ObjectMapping(row));
            }

            return listadoPlanes;
            return null;
        } //LISTO 

        public bool add(Perfil obj)
        {
            string query = "DECLARE @idPerfil int;";
            query += "Insert INTO Perfiles (n_perfil, borrado) VALUES ('" + obj.Nombre + "', 'N');";
            query += "SELECT @idPerfil = @@IDENTITY;";
            foreach (OpcionMenu om in obj.OpcionesMenu)
            {
                query += "Insert INTO Opciones_perfil(id_opcion_menu, id_perfil) VALUES(" + om.Id.ToString() + ", @idPerfil);";
            }

            return DBHelper.getDBHelper().ejecutarSQL(query) > 0;
        }
    }
}
