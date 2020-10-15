﻿using System;

namespace ProductosYPlanes.Negocio.Entidades

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
