using System;
using System.Collections.Generic;
using System.Data;
using ProductosYPlanes.Datos.Conexion;
using ProductosYPlanes.Negocio.Entidades;

namespace ProductosYPlanes.Datos.Dao.Implementacion
{
    public class CasoPruebaDao
    {
        public bool delete(int id)
        {
            //IMPORTANTE: en vez de hacer un delete, hacemos UPDATE porque es BORRADO LÓGICO 
            String sql = "UPDATE CasosDePrueba SET borrado = 1 WHERE id_caso_prueba=" + id;
            return DBHelper.getDBHelper().ejecutarSQL(sql) != 0;

        }

        private CasoPrueba mapper(DataRow PlanRow)
        {
            CasoPrueba oCasoPrueba = new CasoPrueba();

            oCasoPrueba.Id_Caso_Prueba = Convert.ToInt32(PlanRow["id_caso_prueba"].ToString());
            oCasoPrueba.Id_Plan_Prueba = Convert.ToInt32(PlanRow["id_plan_prueba"].ToString());
            oCasoPrueba.Titulo = PlanRow["titulo"].ToString();
            oCasoPrueba.Descripcion = PlanRow["descripcion"].ToString();
            oCasoPrueba.Id_Responsable = Convert.ToInt32(PlanRow["id_responsable"].ToString());
             // para trabajar solo con  registros activos, no borrados.
            oCasoPrueba.Borrado = PlanRow["borrado"].ToString().Equals("S");

            return oCasoPrueba;
        }

        public IList<CasoPrueba> getAll()
        {
            List<CasoPrueba> listadoCasoPruebas = new List<CasoPrueba>();

            String strSql = string.Concat(" SELECT * ",
                                          "   FROM CasosDePrueba",
                                          "  WHERE borrado = 0 ");

            var resultadoConsulta = DBHelper.getDBHelper().ConsultaSQL(strSql);
            if (resultadoConsulta.Rows.Count > 0)
            {
                foreach (DataRow row in resultadoConsulta.Rows)
                {
                    listadoCasoPruebas.Add(mapper(row));
                }
                return listadoCasoPruebas;
            }

            return null;
        }

        public bool CrearCasoPrueba(CasoPrueba oCasoPrueba)
        {
            string str_sql = "SET IDENTITY_INSERT CasosDePrueba ON INSERT INTO CasosDePrueba (id_caso_prueba, id_plan_prueba, titulo, descripcion, id_responsable, borrado)" +
                            " VALUES (@id_caso_prueba, @id_plan_prueba, @titulo, @descripcion, @id_responsable, 0) SET IDENTITY_INSERT CasosDePrueba OFF";

            var parametros = new Dictionary<string, object>();
            parametros.Add("id_caso_prueba", oCasoPrueba.Id_Caso_Prueba);
            parametros.Add("id_plan_prueba", oCasoPrueba.Id_Plan_Prueba);
            parametros.Add("titulo", oCasoPrueba.Titulo);
            parametros.Add("descripcion", oCasoPrueba.Descripcion);
            parametros.Add("id_responsable", oCasoPrueba.Id_Responsable);

            if ((DBHelper.getDBHelper().ejecutarSQL(str_sql, parametros)) == 1)

            {
                return true;
            }

            return false;
        }

        public IList<CasoPrueba> GetByFilters(Dictionary<string, object> parametros)
        {
            List<CasoPrueba> lista = new List<CasoPrueba>();
            String strSql = string.Concat(" SELECT C.* ",
                                          " FROM CasosDePrueba C ",
                                              "  WHERE C.borrado = 'False'");

            if (parametros.ContainsKey("id_caso_prueba"))
                strSql += " AND (C.id_caso_prueba = @id_caso_prueba) ";

            if (parametros.ContainsKey("id_plan_prueba"))
                strSql += " AND (C.id_plan_prueba = @id_plan_prueba) ";

            if (parametros.ContainsKey("titulo"))
                strSql += " AND (C.titulo LIKE '%' + @titulo + '%') ";

            if (parametros.ContainsKey("descripcion"))
                strSql += " AND (C.descripcion LIKE '%' + @descripcion + '%') ";

            if (parametros.ContainsKey("id_responsable"))
                strSql += " AND (C.id_responsable = @id_responsable) ";

            var resultado = (DataRowCollection)DBHelper.getDBHelper().ConsultaSQL(strSql, parametros).Rows;

            foreach (DataRow row in resultado)
                lista.Add(mapper(row));

            return lista;
        } 

        public bool Update(CasoPrueba oCasoPrueba)
        {
            string str_sql = "UPDATE CasosDePrueba " +
                             "SET id_plan_prueba = @id_plan_prueba," +
                             " titulo = @titulo, " +
                             "descripcion  = @descripcion," +
                             "id_responsable = @id_responsable" +
                             " WHERE id_caso_prueba = @id_caso_prueba";

            var parametros = new Dictionary<string, object>();
            parametros.Add("id_caso_prueba", oCasoPrueba.Id_Caso_Prueba);
            parametros.Add("id_plan_prueba", oCasoPrueba.Id_Plan_Prueba);
            parametros.Add("titulo", oCasoPrueba.Titulo);
            parametros.Add("descripcion", oCasoPrueba.Descripcion);
            parametros.Add("id_responsable", oCasoPrueba.Id_Responsable);

            if ((DBHelper.getDBHelper().ejecutarSQL(str_sql, parametros)) == 1)

            {
                return true;
            }

            return false;

        }
        public int consultarMaxId()
        {
            var max = DBHelper.getDBHelper().ConsultaSQL("SELECT MAX(id_caso_prueba) as MAX FROM CasosDePrueba");
            int res = Convert.ToInt32(max.Rows[0]["MAX"]);//.ToString();
            if (res == 0)
                return 0;
            else
                return res;
        }
    }
}
