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
    public partial class FormEmpleado : Form
    {
        //3) Crear una lista Global
        List<Empleado> empleados = new List<Empleado>();
        public FormEmpleado()
        {
            InitializeComponent();
        }

        private void buttonAsistencia_Click(object sender, EventArgs e)
        {
            FormAsistencia formAsistencia = new FormAsistencia();

            formAsistencia.Show();
        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            //1) Crear el objeto Empleado
            Empleado empleado = new Empleado();
            //2) Ingresarle datos al objeto
            empleado.NoEmpleado = Convert.ToInt16(numericNoEmpleado.Value);
            empleado.Nombre = textBoxNombre.Text;
            empleado.SueldoHora = Convert.ToDecimal(maskedTextBoxSueldo.Text);
            //3) la lista se declaro global
            //4) Insertar el objeto a la lista
            empleados.Add(empleado);
            //5) Crear un objeto EmpleadoArchivo
            EmpleadoArchivo empleadoArchivo = new EmpleadoArchivo();
            //6) LLamar a el método grabar
            empleadoArchivo.Guardar("../../Empleados.json", empleados);
        }
    }
}
