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
    class UsuarioDao
    {
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
            //Construimos la consulta sql para buscar el usuario en la base de datos.
            String strSql = string.Concat(" SELECT id_usuario, ",
                                          "        usuario, ",
                                          "        email, ",
                                          "        password, ",
                                          "        p.id_perfil, ",
                                          "        p.nombre perfil ",
                                          "   FROM Usuarios u",
                                          "  INNER JOIN Perfiles p ON u.id_perfil= p.id_perfil ",
                                          "  WHERE usuario = " + nombreUsuario);
            var resultado = DBHelper.getDBHelper().ConsultaSQL(strSql);

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
            Usuario oUsuario = new Usuario
            {
                IdUsuario = Convert.ToInt32(row["id_usuario"].ToString()),
                NombreUsuario = row["usuario"].ToString(),
                Email = row["email"].ToString(),
                Password = row.Table.Columns.Contains("password") ? row["password"].ToString() : null,
               id_Perfil = Convert.ToInt32(row["id_Perfil"].ToString()),
            };

            return oUsuario;
        }
    }


}
