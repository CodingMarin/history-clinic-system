using capaEntidad;
using capaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaNegocio
{
    public class historiaCN
    {
        public int insertar(historiaCE historiaCE)
        {
            historiaCD historiaCD = new historiaCD();
            int idNuevo = historiaCD.insertar(historiaCE);
            return idNuevo;
        }
    }
}
