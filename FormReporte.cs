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
    public partial class FormReporte : Form
    {
        List<Empleado> empleados = new List<Empleado>();    
        List<Asistencia> asistencias = new List<Asistencia>();  
        List<ReporteSueldo> reporteSueldos = new List<ReporteSueldo>();

        public FormReporte()
        {
            InitializeComponent();
        }

        private void CargarEmpleados ()
        {
            EmpleadoArchivo empleadoArchivo = new EmpleadoArchivo();
            empleados = empleadoArchivo.Leer("../../Empleados.json");

        }
        private void CargarAsistencia()
        {
            //Leer las asistencias
        }

        private void FormReporte_Load(object sender, EventArgs e)
        {

        }

        private void buttonMostrar_Click(object sender, EventArgs e)
        {
            //Recorrer cada empleado
            foreach (var empleado in empleados)
            {
                //Recorrer cada asistencia
                foreach (var asistencia in asistencias)
                {
                    //Si el No de empleado del Empleado es el mismo de la Asistencia
                    //generar un reporte.
                    if (empleado.NoEmpleado == asistencia.NoEmpleado)
                    { 
                        //Crear un reporte nuevo
                        ReporteSueldo reporteSueldo = new ReporteSueldo();
                        //El nombre para el reporte lo obtenemos del Empleado
                        reporteSueldo.Nombre = empleado.Nombre;
                        //El mes para el reporte lo obtenemos de la Asistencia
                        reporteSueldo.Mes = asistencia.Mes.ToString();
                        //El sueldo lo calculamos multiplicando sueldo por hora por las
                        //horas trabajadas en el mes
                        reporteSueldo.SueldoTotal = empleado.SueldoHora * asistencia.HorasMes;
                        //Agreamos el reporte a la lista de Reportes.
                        reporteSueldos.Add(reporteSueldo);
                    }                    
                }
            }
        }
    }
}
