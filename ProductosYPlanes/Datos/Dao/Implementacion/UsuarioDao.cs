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
    //class UsuarioDao
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
                                          "  INNER JOIN Perfiles p ON u.id_perfil= p.id_perfil " +
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
                                          "   WHERE usuario = " + nombreUsuario,
                                          "   AND borrado = 0");
           
            DataTable resultado = DBHelper.getDBHelper().ConsultaSQL(strSql);

            if (resultado.Rows.Count > 0)
            {
                return ObjectMapping(resultado.Rows[0]);
            }

            return null;
        }
        //public IList<Usuario> GetByFilters(Dictionary<string, object> parametros)
        //internal bool Create(Usuario oUsuario)
        //internal bool Update(Usuario oUsuario)
        
        private Usuario ObjectMapping(DataRow row)
        {
            Usuario oUsuario = new Usuario();

            oUsuario.IdUsuario = Convert.ToInt32(row["id_usuario"].ToString());
            oUsuario.NombreUsuario = row["usuario"].ToString();
            //oUsuario.Email = row["email"].ToString();
            oUsuario.Password = row.Table.Columns.Contains("password") ? row["password"].ToString() : null;
              

            return oUsuario;
        }
    }


}
