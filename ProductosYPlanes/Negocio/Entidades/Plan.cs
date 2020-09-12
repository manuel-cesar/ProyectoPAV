using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActualizarUsuarios.Negocio.Entidades
{
    public class Plan
    {
        public int Id_Plan_Prueba { get; set; }
        public int Id_Proyecto { get; set; }
        public String Nombre { get; set; }
        public int Id_Responsable{ get; set; }
        public String Descripcion { get; set; }
        public bool Borrado { get; set; }



        public Plan(int id_plan_prueba, int id_proyecto, String nombre, int id_responsable, String descripcion)
        {
            this.Id_Plan_Prueba = id_plan_prueba;
            this.Id_Proyecto = id_proyecto;
            this.Nombre = nombre;
            this.Id_Responsable = Id_Responsable;
            this.Descripcion = descripcion;
        }
    }
}
