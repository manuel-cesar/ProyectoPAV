using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductosYPlanes.Datos.Dao.Interfaz
{
    interface IDao
    {
        T findById(int id);
        IList<T> getAll();
        bool add(T obj);
        bool delete(int id);
    }
}
