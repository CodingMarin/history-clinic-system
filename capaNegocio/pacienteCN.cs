using capaDatos;
using capaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaNegocio
{
    public class pacienteCN
    {
        public bool validarId(int id)
        {
            pacienteCD pacienteCD = new pacienteCD();
            bool validado = pacienteCD.validarId(id);
            return validado;
        }
        public pacienteCE buscarById(int idBuscado)
        {
            pacienteCD pacienteCD = new pacienteCD();
            pacienteCE pacienteCE = pacienteCD.buscarById(idBuscado);
            return pacienteCE;
        }
        public List<pacienteCE> buscarByNombre(string nombrePaciente)
        {
            pacienteCD pacienteCD = new pacienteCD();
            List<pacienteCE> pacienteCE = pacienteCD.buscarByNombre(nombrePaciente);
            return pacienteCE;
        }
        public int insertar(pacienteCE pacienteCE)
        {
            pacienteCD pacienteCD = new pacienteCD();
            int idNuevo = pacienteCD.insertar(pacienteCE);
            return idNuevo;
        }
        public bool actualizar(pacienteCE pacienteCE)
        {
            pacienteCD pacienteCD = new pacienteCD();
            bool estado = pacienteCD.actualizar(pacienteCE);
            return estado;
        }
        public bool eliminar(int idEliminar)
        {
            pacienteCD pacienteCD = new pacienteCD();
            bool estado = pacienteCD.eliminar(idEliminar);
            return estado;
        }
        public List<pacienteCE> mostrarPacientes()
        {
            pacienteCD pacienteCD = new pacienteCD();
            List<pacienteCE> pacientes = pacienteCD.LeerTodosLosPacientes();
            return pacientes;
        }
        public int mostrarCantidadPacientes()
        {
            pacienteCD paciente = new pacienteCD();
            int totalPacientes = paciente.mostrarCantidadPacientes();
            return totalPacientes;
        }
        public int mostrarCantidadHistorias()
        {
            pacienteCD paciente = new pacienteCD();
            int totalHistorias = paciente.mostrarCantidadHistorias();
            return totalHistorias;
        }
        public bool validarCampos(pacienteCE paciente)
        {
            bool result = false;

            if (paciente.nombre == string.Empty)
            {
                result = true;
            }
            else if (paciente.direccion == string.Empty)
            {
                result = true;
            }
            else if (paciente.DNI == 0)
            {
                result = true;
            }
            else if (paciente.telefono == string.Empty)
            {
                result = true;
            }
            else if (paciente.fecha_nacimiento == DateTime.MinValue)
            {
                result = true;
            }

            return result;
        }
    }
}
