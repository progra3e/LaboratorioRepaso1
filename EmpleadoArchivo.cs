﻿using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace LaboratorioRepaso1
{
    internal class EmpleadoArchivo
    {

        public void Guardar (string archivo, List<Empleado> empleados)
        {
            string json = JsonConvert.SerializeObject(empleados);                        
            System.IO.File.WriteAllText(archivo, json);
        }

        public List<Empleado> Leer (string archivo)
        {           
            List<Empleado> lista = new List<Empleado>();                        
            StreamReader jsonStream = File.OpenText(archivo);
            string json = jsonStream.ReadToEnd();            
            jsonStream.Close();
            
            lista = JsonConvert.DeserializeObject<List<Empleado>>(json);
            return lista;
        }
    }
}
