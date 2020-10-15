using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace ProductosYPlanes.Datos.Conexion
{
    public class DBHelper : IDisposable
    {
        private SqlConnection dbConnection;
        private SqlTransaction dbTransaction;


        private static DBHelper instance;
        public DBHelper()
        {
            dbConnection = new SqlConnection();

            var string_conexion = "Data Source=MANUEL;Initial Catalog=BugTrackerExt;Integrated Security=True";

            dbConnection.ConnectionString = string_conexion;
        }

        public static DBHelper getDBHelper()
        {
            if (instance == null)
                instance = new DBHelper();

            instance.Open();

            return instance;
        }

        public void Open()
        {
            if (dbConnection.State != ConnectionState.Open)
                dbConnection.Open();
        }

        public void Close()
        {
            if (dbConnection.State != ConnectionState.Closed)
                dbConnection.Close();
        }


        ///      Se utiliza para sentencias SQL del tipo “Select” con parámetros recibidos desde la interfaz
        public DataTable ConsultaSQL(string strSql, Dictionary<string, object> prs = null)
        {
            SqlCommand cmd = new SqlCommand();
            DataTable tabla = new DataTable();
            try
            {
                cmd.Connection = dbConnection;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = strSql;

                //Agregamos a la colección de parámetros del comando los filtros recibidos
                if (prs != null)
                {
                    foreach (var item in prs)
                    {
                        cmd.Parameters.AddWithValue(item.Key, item.Value);
                    }
                }

                tabla.Load(cmd.ExecuteReader());
                return tabla;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }


        //Se utiliza para sentencias SQL del tipo “Insert/Update/Delete”. Recibe por valor una sentencia sql como string
        public int ejecutarSQL(string strSql, Dictionary<string, object> prs = null)
        {
            SqlCommand cmd = new SqlCommand();

            int rtdo;

            try
            {
                cmd.Connection = dbConnection;
                cmd.CommandType = CommandType.Text;
                // Establece la instrucción a ejecutar
                cmd.CommandText = strSql;

                //Agregamos a la colección de parámetros del comando los filtros recibidos
                if (prs != null)
                {
                    foreach (var item in prs)
                    {
                        cmd.Parameters.AddWithValue(item.Key, item.Value);
                    }
                }

                // Retorna el resultado de ejecutar el comando
                cmd.Transaction = dbTransaction;

                rtdo = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;

            }
            return rtdo;
        }



        ///     Se utiliza para sentencias SQL del tipo “Select”. Recibe por valor una sentencia sql como string
        public object ConsultaSQLScalar(string strSql)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                cmd.Connection = dbConnection;
                cmd.CommandType = CommandType.Text;
                // Establece la instrucción a ejecutar
                cmd.CommandText = strSql;
                return cmd.ExecuteScalar();
            }
            catch (SqlException ex)
            {
                throw (ex);
            }
        }

        public void BeginTransaction()
        {
            if (dbConnection.State == ConnectionState.Open)
                dbTransaction = dbConnection.BeginTransaction();
        }
        public void Commit()
        {
            if (dbTransaction != null)
                dbTransaction.Commit();
        }

        public void Rollback()
        {
            if (dbTransaction != null)
                dbTransaction.Rollback();
        }

        public void Dispose()
        {
            this.Close();
        }

        public DataTable ConsultarTabla(string tabla)
        {
            return this.ConsultaSQL("Select * FROM " + tabla);
        }


    }
}
