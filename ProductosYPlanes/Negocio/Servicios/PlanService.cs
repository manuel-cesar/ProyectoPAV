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

        public Plan ConsultarPlanPorId(int id)
        {
            return oPlanDao.findById(id);
        }
    }
}
