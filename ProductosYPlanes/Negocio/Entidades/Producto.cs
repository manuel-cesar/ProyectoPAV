using System;

namespace ProductosYPlanes.Negocio.Entidades
{
    public class Producto
    {
        public int Id_Producto { get; set; }
        public String Nombre { get; set; }
        public bool Borrado { get; set; }

        public Producto() { }

        public Producto(int id_producto, String nombre)
        {
            this.Id_Producto = id_producto;
            this.Nombre = nombre;
        
        }
    }
}