using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaboratorioRepaso1
{
    public partial class FormAsistencia : Form
    {
        List<Asistencia> asistencias = new List<Asistencia>();
        List<Empleado> empleados = new List<Empleado>();    
        public FormAsistencia()
        {
            InitializeComponent();
        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarAsistencia ()
        {
            AsistenciaArchivo asistenciaArchivo = new AsistenciaArchivo();
            asistencias = asistenciaArchivo.Leer("../../Asistencias.json");
        }

        private void CargarEmpleados ()
        {
            EmpleadoArchivo empleadoArchivo = new EmpleadoArchivo();
            empleados = empleadoArchivo.Leer("../../Empleados.json");
        }

        private void MostrarEmpleados()
        {
            //Como el empleado tiene varios datos, hay que indicarle al 
            //combobox que dato de esos va a mostrar y que dato de esos
            //va a seleccionar al dar clic 
            //En este caso va a mostrar el nombre, y va a seleccionar el número de empleado
            comboBoxEmpleado.ValueMember = "NoEmpleado";
            comboBoxEmpleado.DisplayMember = "Nombre";
            comboBoxEmpleado.DataSource = empleados;
        }

        private void FormAsistencia_Load(object sender, EventArgs e)
        {
            CargarEmpleados();
            MostrarEmpleados ();
        }
    }
}
