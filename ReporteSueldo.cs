using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratorioRepaso1
{
    internal class ReporteSueldo
    {
        //Se obtiene desde la clase Empleado
        public string Nombre;
        //Se calcula: SueldoxHora * HorasMes
        public decimal SueldoTotal;
        //Hay que convertir Mes de Asistencia
        //en su nombre
        public string Mes;
    }
}
