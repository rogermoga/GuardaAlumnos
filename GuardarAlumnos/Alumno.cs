using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuardarAlumnos
{
    class Alumno
    {
        int identificador;
        String nombre;
        String apellido;
        String dni;

        public Alumno(int id, String nombre, String apellido, String dni)
        {
            identificador = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
        } 

        public int GetId(){return this.identificador;}
        public String GetNombre() { return this.nombre; }
        public String GetApellid() { return this.apellido; }
        public String Getdni() { return this.dni; }

    }
}
