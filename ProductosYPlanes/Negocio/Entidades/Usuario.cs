using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

<<<<<<< HEAD
namespace ProductosYPlanes.Negocio.Entidades
=======
namespace ActualizarUsuarios.Negocio.Entidades
>>>>>>> 9ae76c8fa45c3d4efbce57b93ac0dab2dbb4b852
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string NombreUsuario { get; set; }
        public string Email { get; set; }
        public string Estado { get; set; }

        public string Password { get; set; }

        public int id_Perfil { get; set; }


        public override string ToString()
        {
            return NombreUsuario;
        }
    }
}
