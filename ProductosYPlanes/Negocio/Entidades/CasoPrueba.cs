using System;

namespace ProductosYPlanes.Negocio.Entidades
{
    public class CasoPrueba
    {
        public int Id_Caso_Prueba { get; set; }
        public int Id_Plan_Prueba { get; set; }
        public String Titulo { get; set; }
        public String Descripcion { get; set; }
        public int Id_Responsable{ get; set; }
        public bool Borrado { get; set; }

        public CasoPrueba() { }

        public CasoPrueba(int id_caso_prueba, int id_plan_prueba, String titulo, String descripcion, int id_responsable)
        {
            this.Id_Caso_Prueba = id_caso_prueba;
            this.Id_Plan_Prueba = id_plan_prueba;
            this.Titulo = titulo; ;
            this.Descripcion = descripcion;
            this.Id_Responsable = id_responsable;
        }
    }
}
