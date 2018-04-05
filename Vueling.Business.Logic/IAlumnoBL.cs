using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vueling.Common.Logic.Model;

namespace Vueling.Business.Logic
{
    public interface IAlumnoBL<T> where T : VuelingObject
    {
        T add(T entity);
        void Formatear(TipoFichero tipoFichero);

    }
}
