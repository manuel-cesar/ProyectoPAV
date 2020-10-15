using System;
using System.Collections.Generic;

using ProductosYPlanes.Negocio.Entidades;
using ProductosYPlanes.Datos.Conexion;

using System.Data;



namespace ProductosYPlanes.Datos.Dao.Implementacion
{
    public class UsuarioDao { 
        public IList<Usuario> GetAll()
        {
            List<Usuario> listadoBugs = new List<Usuario>();

            String strSql = string.Concat("Select id_Usuario, ",
                                              "    usuario, ",
                                          "        email, ",
                                          "        password, ",
                                          "        p.id_perfil, ",
                                          "        p.nombre perfil ",
                                          "   FROM Usuarios u",
                                          "  INNER JOIN Perfiles p ON u.id_perfil= p.id_perfil ",
                                          "  WHERE u.borrado = 0 ");   
            var resultadoConsulta = DBHelper.getDBHelper().ConsultaSQL(strSql);

            foreach (DataRow row in resultadoConsulta.Rows)
            {
                listadoBugs.Add(ObjectMapping(row));

            }
            return listadoBugs;
        }
        public Usuario GetUser(string nombreUsuario)
        {
            //Construimos la consulta sql para buscar el usuario en la base de dato
            String strSql = string.Concat(" SELECT id_usuario, ",
                                          "        usuario, ",
                                          "        password ",
                                          "   FROM Usuarios ",
                                          "   WHERE usuario = @usuario",
                                          "   AND borrado = 0");
          
            var parametros = new Dictionary<string, object>();
            parametros.Add("usuario", nombreUsuario);
            var resultado = DBHelper.getDBHelper().ConsultaSQL(strSql, parametros);
            if (resultado.Rows.Count > 0)
            {
                return ObjectMapping(resultado.Rows[0]);
            }

            return null;
        }

        private Usuario ObjectMapping(DataRow row)
        {
            Usuario oUsuario = new Usuario();

            oUsuario.IdUsuario = Convert.ToInt32(row["id_usuario"].ToString());
            oUsuario.NombreUsuario = row["usuario"].ToString();
            oUsuario.Password = row.Table.Columns.Contains("password") ? row["password"].ToString() : null;

            return oUsuario;
        }
    }


}
