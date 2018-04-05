using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vueling.Business.Logic;
using Vueling.Common.Logic.Model;

namespace Vueling.Presentation.WinSite
{
    public partial class AlumnoForm : Form
        

    {

        private Alumno alumno;
        private IAlumnoBL<Alumno> alumnoBL;

        public AlumnoForm()
        {
            alumno = new Alumno();
            alumnoBL = new AlumnoBl();
            InitializeComponent();
        }

        public void GenerarAlumno()
        {
            alumno.dni = textDni.Text;
            alumno.nombre = textNombre.Text;
            alumno.apellido = textApellidos.Text;
            alumno.identificador = Decimal.ToInt32(upId.Value);
            alumno.fechaNacimiento = dpFechaNacimiento.Value;

        }


        private void btnTxt_Click(object sender, EventArgs e)
        {
            GenerarAlumno();
            alumnoBL.Formatear(TipoFichero.TXT);
            alumnoBL.add(alumno);
        }

        private void btnJson_Click(object sender, EventArgs e)
        {
            GenerarAlumno();
            alumnoBL.Formatear(TipoFichero.JSON);
            alumnoBL.add(alumno);
        }

        private void btnXml_Click(object sender, EventArgs e)
        {
            GenerarAlumno();
            alumnoBL.Formatear(TipoFichero.XML);
            alumnoBL.add(alumno);
        }
    }
}
