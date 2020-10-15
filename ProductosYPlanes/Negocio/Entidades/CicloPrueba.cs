using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductosYPlanes.Negocio.Entidades
{
    public class CicloPrueba
    {

        public int Id_Ciclo_Prueba { get; set; }
        public DateTime Fecha_Inicio { get; set; }
        public DateTime Fecha_Fin { get; set; }
        public int Id_Responsable { get; set; }
        public IList<CicloPruebaDetalle> CicloDePruebasDetalle { get; set; }
        public int Id_Plan { get; set;}
        public bool Aceptado { get; set; }
        public bool Borrado { get; set; }


        public CicloPrueba() { }

        public CicloPrueba(int id_ciclo, DateTime inicio, DateTime fin, int id_responsable, int id_plan, bool aceptado)
        {
            this.Id_Ciclo_Prueba = id_ciclo;
            this.Fecha_Inicio = inicio;
            this.Fecha_Fin = fin;
            this.Id_Responsable = Id_Responsable;
            this.Id_Plan = id_plan;
            this.Aceptado = aceptado;
        }
    }
}
