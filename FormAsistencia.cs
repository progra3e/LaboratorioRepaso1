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

        public FormAsistencia()
        {
            InitializeComponent();
        }

        private void FormAsistencia_Load(object sender, EventArgs e)
        {
            //Cargar el archivo de Empleados a una lista
            List<Empleado> empleados = new List<Empleado>();
            EmpleadoArchivo empleadoArchivo = new EmpleadoArchivo();
            empleados = empleadoArchivo.Leer("../../Empleados.json");

            //Configurar el combobox
            //Que propiedad de Empleado va a mostrar en pantalla
            comboBoxEmpleados.DisplayMember = "Nombre";
            //Que propiedad de Empleado va a seleccionar al dar clic
            comboBoxEmpleados.ValueMember = "NoEmpleado";
            
            comboBoxEmpleados.DataSource = empleados;

            //Cargar el archivo de Asistencias a una lista
            AsistenciaArchivo asistenciaArchivo = new AsistenciaArchivo();
            asistencias = asistenciaArchivo.Leer("../../Asitencias.json");
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            //Crear una nueva asistencia y asignarle sus valores
            Asistencia asistencia = new Asistencia();
            asistencia.NoEmpleado = Convert.ToInt16(comboBoxEmpleados.SelectedValue);
            asistencia.HorasMes = Convert.ToInt16(numericHoras.Value);
            asistencia.Mes = Convert.ToInt16(numericMes.Value);
            
            //Insertar esa asistencia a la lista
            asistencias.Add(asistencia);

            //Mandar a guardar la lista al archivo
            AsistenciaArchivo asistenciaArchivo = new AsistenciaArchivo();
            asistenciaArchivo.Guardar("../../Asitencias.json", asistencias);
        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
