using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuardarAlumnos
{
     class Alumno
    {
         public int identificador;
         public String nombre;
         public String apellido;
         public String dni;

        public Alumno(int id, String nombre, String apellido, String dni)
        {
            identificador = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
        }

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
