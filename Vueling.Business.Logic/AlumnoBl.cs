using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vueling.Common.Logic.Model;
using Vueling.DataAccess.Dao;

namespace Vueling.Business.Logic
{
    public class AlumnoBl : IAlumnoBL<Alumno>
    {

        
         public void Formatear(TipoFichero tipoFichero)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var value = (int)tipoFichero;
            config.AppSettings.Settings["tipoFichero"].Value = value.ToString();
            config.Save(ConfigurationSaveMode.Modified);

        }
        public Alumno add(Alumno entity)
        {
            entity.edad = CalcularEdad(entity.fechaNacimiento);
            entity.fechaRegistro = CalcularFechaRegistro();
            Idocument<Alumno> doc = DocumentFactory<Alumno>.getFormat(GetActualFormat());
            IalumnoDao alumnoDao = new AlumnoDao(doc);

            return alumnoDao.Add(entity);
        }

        private DateTime CalcularFechaRegistro()
        {
            return DateTime.Now;
        }

        public TipoFichero GetActualFormat()
        {           
                //Obtener Formato.
                ConfigurationManager.RefreshSection("appSettings");
                var tipo = Int32.Parse(ConfigurationManager.AppSettings["tipoFichero"]);
                return (TipoFichero)tipo;

        }

        public int CalcularEdad(DateTime fechaNacimiento) { 
        DateTime now = DateTime.Today;
        int age = now.Year - fechaNacimiento.Year;
                if (now<fechaNacimiento.AddYears(age))
                {
                    --age;
                }
                return age;
        }

        
    }
}
