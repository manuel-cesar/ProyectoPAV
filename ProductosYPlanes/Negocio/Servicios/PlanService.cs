using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ProductosYPlanes.Datos.Dao.Implementacion;
using ProductosYPlanes.Negocio.Entidades;

namespace ProductosYPlanes.Negocio.Servicios
{
    public class PlanService
    {
        private PlanDao oPlanDao;
        public PlanService()
        {
            oPlanDao = new PlanDao();
        }
        public IList<Plan> ConsultarPlanConFiltros(Dictionary<string, object> parametros)
        {
            return oPlanDao.GetByFilters(parametros);
        }

        public IList<Plan> ConsultarTodos()
        {
            return oPlanDao.getAll();
        }

        public Plan ConsultarPlanPorId(int id)
        {
            return oPlanDao.findById(id);
        }

        public bool ActualizarPlan(Plan OplanSelected)
        {
            return oPlanDao.Update(OplanSelected);
        }

        internal bool crearPlan(Plan oPlan)
        {
            return oPlanDao.CrearPlan(oPlan);
        }

        public bool EliminarPlan(int idPlan)
        {
            return oPlanDao.delete(idPlan);
        }


    }
}
