using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vueling.Common.Logic.Model;

namespace Vueling.DataAccess.Dao
{
    public class AlumnoDao : IalumnoDao
    {
        private Idocument<Alumno> iDoc;

        public AlumnoDao(Idocument<Alumno> doc)
        {
            iDoc = doc;
        }

        public Alumno Add(Alumno alumno)
        {
            
            return iDoc.Add(alumno);
        }
    }
}
