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
        //public CicloPrueba CicloPrueba { get; set; }
        public CasoPrueba CasoPrueba { get; set; }
        public Usuario Tester { get; set; }
        public int Horas { get; set; }
        public DateTime Fecha { get; set; }
        public bool Aceptado { get; set; }
        public bool Borrado { get; set; }


        //public int IdCicloPrueba
        //{
        //    get
        //    {
        //        return CicloPrueba.Id_Ciclo_Prueba;
        //    }
        //}
        public int IdCasoPrueba
        {
            get
            {
                return CasoPrueba.Id_Caso_Prueba;
            }
        }

        public int IdTester
        {
            get
            {
                return Tester.IdUsuario;
            }
        }
    }
}
