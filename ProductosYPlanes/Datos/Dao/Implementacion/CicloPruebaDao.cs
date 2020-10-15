﻿using System;
using System.Collections.Generic;
using System.Data;
using ProductosYPlanes.Negocio.Entidades;
using ProductosYPlanes.Datos.Conexion;

namespace ProductosYPlanes.Datos.Dao.Implementacion
{
    class CicloPruebaDao
    {
        internal bool Create(CicloPrueba cicloPrueba)
        {
            DBHelper dm = new DBHelper();
            try
            {
                dm.Open();
                dm.BeginTransaction();
  

                string sql = string.Concat("INSERT INTO [dbo].[CiclosPrueba] ",
                                            "           ([id_ciclo_prueba]   ",
                                            "           ,[fecha_inicio_ejecucion]         ",
                                            "           ,[fecha_fin_ejecucion]       ",
                                            "           ,[id_responsable]   ",
                                            "           ,[id_plan_prueba]    ",
                                            "           ,[aceptado]    ",
                                            "           ,[borrado])      ",
                                            "     VALUES                 ",
                                            "           (@id_ciclo_prueba   ",
                                            "           ,@fecha_inicio_ejecucion         ",
                                            "           ,@fecha_fin_ejecucion        ",
                                            "           ,@id_responsable    ",
                                            "           ,@id_plan_prueba    ",
                                            "           ,@aceptado     ",
                                            "           ,@borrado)       ");


                var parametros = new Dictionary<string, object>();
                parametros.Add("id_ciclo_prueba", cicloPrueba.Id_Ciclo_Prueba);
                parametros.Add("fecha_inicio_ejecucion", cicloPrueba.Fecha_Inicio);
                parametros.Add("fecha_fin_ejecucion", cicloPrueba.Fecha_Fin);
                parametros.Add("id_responsable", cicloPrueba.Id_Responsable);
                parametros.Add("id_plan_prueba", cicloPrueba.Id_Plan_Prueba);
                parametros.Add("aceptado", cicloPrueba.Aceptado);
                parametros.Add("borrado", 0);
                dm.ejecutarSQL(sql, parametros);//PRUEBA

                var newId = dm.ConsultaSQLScalar(" SELECT @@IDENTITY");
                cicloPrueba.Id_Ciclo_Prueba = Convert.ToInt32(newId);


                foreach (var itemCicloDePrueba in cicloPrueba.CicloPruebaDetalle)
                {
                    string sqlDetalle = string.Concat(" INSERT INTO [dbo].[CiclosPruebaDetalle] ",
                                                        "           ([id_ciclo_prueba_detalle]           ",
                                                        "           ,[id_ciclo_prueba]          ",
                                                        "           ,[id_caso_prueba]      ",
                                                        "           ,[id_usuario_tester]             ",
                                                        "           ,[cantidad_horas]             ",
                                                        "           ,[fecha_ejecucion]             ",
                                                        "           ,[aceptado]     ",
                                                        "           ,[borrado])             ",
                                                        "     VALUES                        ",
                                                        "           (@id_ciclo_prueba_detalle           ",
                                                        "           ,@id_ciclo_prueba          ",
                                                        "           ,@id_caso_prueba      ",
                                                        "           ,@id_usuario_tester             ",
                                                        "           ,@cantidad_horas             ",
                                                        "           ,@fecha_ejecucion              ",
                                                         "           ,@aceptado               ",
                                                        "           ,@borrado)               ");

                    var paramDetalle = new Dictionary<string, object>();
                    paramDetalle.Add("id_ciclo_prueba_detalle", itemCicloDePrueba.Id_Ciclo_Detalle);
                    paramDetalle.Add("id_ciclo_prueba", itemCicloDePrueba.Id_Ciclo_Detalle);
                    paramDetalle.Add("id_caso_prueba", itemCicloDePrueba.CasoPrueba.Id_Caso_Prueba);
                    paramDetalle.Add("id_usuario_tester", itemCicloDePrueba.Tester.IdUsuario);
                    paramDetalle.Add("cantidad_horas", itemCicloDePrueba.Horas);
                    paramDetalle.Add("fecha_ejecucion", itemCicloDePrueba.Fecha);
                    paramDetalle.Add("aceptado", 1);
                    paramDetalle.Add("borrado", 0);

                    dm.ejecutarSQL(sqlDetalle, paramDetalle); //PRUEBA
                }

                dm.Commit();

            }
            catch (Exception ex)
            {
                dm.Rollback();
                throw ex;
            }
            finally
            { 
                dm.Close();
            }
            return true;
        }

        public IList<CicloPrueba> getAll()
        {
            List<CicloPrueba> listadoCiclos = new List<CicloPrueba>();

            String strSql = string.Concat(" SELECT C.* ",
                                          "   FROM CiclosPrueba  C",
                                          "  WHERE C.borrado = 0 ");

            var resultadoConsulta = DBHelper.getDBHelper().ConsultaSQL(strSql);
            if (resultadoConsulta.Rows.Count > 0)
            {
                foreach (DataRow row in resultadoConsulta.Rows)
                {
                    listadoCiclos.Add(mapper(row));
                }
                return listadoCiclos;
            }

            return null;
        }


        private CicloPrueba mapper(DataRow CicloPruebaRow)
        {
            CicloPrueba oCicloPrueba = new CicloPrueba();

            oCicloPrueba.Id_Ciclo_Prueba = Convert.ToInt32(CicloPruebaRow["id_ciclo_prueba"].ToString());
            oCicloPrueba.Fecha_Inicio = Convert.ToDateTime(CicloPruebaRow["fecha_inicio_ejecucion"].ToString());
            oCicloPrueba.Fecha_Fin = Convert.ToDateTime(CicloPruebaRow["fecha_fin_ejecucion"].ToString());
            oCicloPrueba.Id_Responsable = Convert.ToInt32(CicloPruebaRow["id_responsable"].ToString());
            oCicloPrueba.Aceptado = Convert.ToBoolean(CicloPruebaRow["aceptado"].ToString());
            //agregamos este atributo tanto en la tabla como en la entidad para trabajar solo con  registros activos, no borrados.
            oCicloPrueba.Borrado = CicloPruebaRow["borrado"].ToString().Equals("S");

            return oCicloPrueba;
        }
    }
}
