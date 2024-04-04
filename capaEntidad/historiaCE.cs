using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaEntidad
{
    public class historiaCE
    {
        public int paciente_id { get; set; }
        public DateTime fecha_consulta { get; set; }
        public int edad { get; set; }
        public decimal peso { get; set; }
        public decimal talla { get; set; }
        public int frecuencia_respiratoria { get; set; }
        public int frecuencia_cardiaca { get; set; }
        public decimal temperatura { get; set; }
        public string presion_arterial { get; set; }
        public int tiempo { get; set; }
        public string signos_sintomas { get; set; }
        public string relato { get; set; }
        public string examen_fisico { get; set; }
        public string antecedentes { get; set; }
        public string diagnosticos { get; set; }
        public string prescripcion_medica { get; set; }
    }
}
