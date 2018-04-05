using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vueling.Common.Logic.Model
{
    public class Alumno : VuelingObject
    {
        #region Atributos
        private int idAlumno;
        public string nombre;
        public int identificador;        
        public String apellido;
        public String dni;
        public DateTime fechaNacimiento;
        public int edad;
        public DateTime fechaRegistro;

        #endregion

        public Alumno(int id, String nombre, String apellido, String dni)
        {
            identificador = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
        }

        public Alumno(string guid, string id, string nombre, string apellidos, string dni, string fechaDeNacimiento, string edad, string fechaDeRegistro)
        {
            Guid = Guid.Parse(guid);
            identificador = Convert.ToInt32(id);
            this.nombre = nombre;
            apellido = apellidos;
            this.dni = dni;
            fechaNacimiento = DateTime.Parse(fechaDeNacimiento);
            fechaRegistro = DateTime.Parse(fechaDeRegistro);
            this.edad = Convert.ToInt32(edad);
        }


        public override string ToString()
        {

            return Guid.ToString() + "," + idAlumno.ToString() + "," + nombre + "," + apellido + "," + dni + "," + fechaNacimiento.ToString() + "," + edad.ToString() + "," + fechaRegistro.ToString();
        }

        public Alumno(Guid guid, string nombre, int identificador, string apellido, string dni, DateTime fechaNacimiento)
        {
            Guid = guid;
            this.nombre = nombre;
            this.identificador = identificador;
            this.apellido = apellido;
            this.dni = dni;
            this.fechaNacimiento = fechaNacimiento;
        }

        public Alumno()
        {
            this.Guid = Guid.NewGuid();
        }

        public string getNombre { get; set; }

        public int GetId() { return identificador; }
        public String GetNombre() { return nombre; }
        public String GetApellid() { return apellido; }
        public String Getdni() { return dni; }

        public override bool Equals(object obj)
        {
            var alumno = obj as Alumno;
            return alumno != null &&
                   identificador == alumno.identificador &&
                   nombre == alumno.nombre &&
                   apellido == alumno.apellido &&
                   dni == alumno.dni;
        }

        public override int GetHashCode()
        {
            var hashCode = 1383989819;
            hashCode = hashCode * -1521134295 + identificador.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(nombre);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(apellido);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(dni);
            return hashCode;
        }
    }
}
