using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaEntidad
{
    public class pacienteCE
    {
        public int paciente_id { get; set; }
        public string nombre { get; set; }
        public string direccion { get; set; }
        public int DNI { get; set; }
        public string telefono { get; set; }
        public DateTime fecha_nacimiento { get; set; }
        public string mami_nombre { get; set; }
        public string papi_nombre { get; set; }
    }
}
