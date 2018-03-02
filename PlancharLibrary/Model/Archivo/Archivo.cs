using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlancharLibrary.Model.Archivo
{
    public class ArchivoExcel
    {
        public string Nombre { get; set; }
        public int ID { get; set; }
        public int NumHojaLeer { get; set; }
        public int FilaInicioLeer { get; set; }
        public bool RequiereValidar { get; set; }
    }
}
