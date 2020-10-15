using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductosYPlanes.Negocio.Entidades
{
    public class CicloPruebaDetalle
    {

        public int Id_Ciclo_Detalle { get; set; }
        public int Id_Ciclo_Prueba { get; set; }
        public int Id_Caso_Prueba { get; set; }
        public int Id_Tester { get; set; }
        public DateTime Fecha { get; set; }

        public int cantidad_horas { get; set; }
        public bool Aceptado { get; set; }
        public bool Borrado { get; set; }


        public CicloPruebaDetalle() { }

        public CicloPruebaDetalle(int id_detalle, int id_ciclo, int id_caso_prueba, int id_tester, DateTime fecha, int cantidad_horas, bool aceptado)
        {
            this.Id_Ciclo_Detalle = id_detalle;
            this.Id_Ciclo_Prueba = id_ciclo;
            this.Id_Caso_Prueba = id_caso_prueba;
            this.Id_Tester = id_tester;
            this.Fecha = fecha;
            this.cantidad_horas = cantidad_horas;
            this.Aceptado = aceptado;
        }
    }
}
