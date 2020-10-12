using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActualizarUsuarios.Negocio.Entidades
{
    public class Proyecto
    {
        public int Id_Proyecto { get; set; }
        public int Id_Producto { get; set; }
        public String Descripcion { get; set; }
        public int Version { get; set; }
        public int Alcance { get; set; }
        public int Id_Responsable { get; set; }
        public bool Borrado { get; set; }

        public Proyecto() { }

        public Proyecto(int id_proyecto, int id_producto, String descripcion, int version, int alcance, int id_responsable)
        {
            this.Id_Proyecto = id_producto;
            this.Id_Producto = id_producto;
            this.Descripcion = descripcion;
            this.Version = version;
            this.Alcance = alcance;
            this.Id_Responsable = id_responsable;

        }
    }
}