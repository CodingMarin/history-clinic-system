
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using capaEntidad;
using MySql.Data.MySqlClient;

namespace capaDatos
{
    public class pacienteCD
    {
        public bool validarId(int paciente_id)
        {
            MySqlConnection cnx = conexionCD.cnx();
            cnx.Open();

            MySqlCommand cmd = cnx.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select count(*) from pacientes where paciente_id = @paciente_id;";
            cmd.Parameters.AddWithValue("@paciente_id", paciente_id);

            int count = (int)cmd.ExecuteScalar();

            if (count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public pacienteCE buscarById(int idBuscado)
        {
            MySqlConnection cnx = conexionCD.cnx();
            cnx.Open();

            MySqlCommand cmd = cnx.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from pacientes where paciente_id=@paciente_id;";
            cmd.Parameters.AddWithValue("@paciente_id", idBuscado);

            MySqlDataReader dr = cmd.ExecuteReader();
            bool exiteFila = dr.Read();

            pacienteCE paciente = new pacienteCE();

            if (exiteFila)
            {
                paciente.paciente_id = (int)dr["paciente_id"];
                paciente.nombre = (string)dr["nombre"];
                paciente.direccion = (string)dr["direccion"];
                paciente.telefono = (string)dr["telefono"];
                paciente.fecha_nacimiento = (DateTime)dr["fecha_nacimiento"];
                paciente.mami_nombre = (string)dr["mami_nombre"];
                paciente.papi_nombre = (string)dr["papi_nombre"];
            }
            else
            {
                paciente.paciente_id = 0;
                paciente.nombre = "Sin registrar";
                paciente.direccion = "sin valor";
                paciente.telefono = "000-000-000";
                paciente.fecha_nacimiento = DateTime.MinValue;
                paciente.mami_nombre = "sin valor";
                paciente.papi_nombre = "sin valor";
            }
            cnx.Close();
            return paciente;
        }

        public List<pacienteCE> buscarByNombre(string nombrePaciente)
        {
            List<pacienteCE> pacienteCE = new List<pacienteCE>();
            MySqlConnection cnx = conexionCD.cnx();

            try
            {
                cnx.Open();
                MySqlCommand cmd = cnx.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from pacientes where nombre like @nombre;";
                cmd.Parameters.AddWithValue("@nombre", "%" + nombrePaciente + "%");

                using (MySqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        int paciente_id = Convert.ToInt32(dr["paciente_id"]);
                        string nombre = (string)dr["nombre"];
                        string direccion = (string)dr["direccion"];
                        string telefono = (string)dr["telefono"];
                        DateTime fecha_nacimiento = (DateTime)dr["fecha_nacimiento"];
                        string mami_nombre = (string)dr["mami_nombre"];
                        string papi_nombre = (string)dr["papi_nombre"];

                        pacienteCE paciente = new pacienteCE();
                        paciente.paciente_id = paciente_id;
                        paciente.nombre = nombre;
                        paciente.direccion = direccion;
                        paciente.telefono = telefono;
                        paciente.fecha_nacimiento = fecha_nacimiento;
                        paciente.mami_nombre = mami_nombre;
                        paciente.papi_nombre = papi_nombre;

                        pacienteCE.Add(paciente);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                cnx.Close();
            }
            return pacienteCE;
        }

        public int insertar(pacienteCE paciente)
        {
            MySqlConnection cnx = conexionCD.cnx();
            cnx.Open();

            MySqlCommand cmd = cnx.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into pacientes (nombre, direccion, telefono, fecha_nacimiento, mami_nombre, papi_nombre, DNI) values (@nombre, @direccion, @telefono, @fecha_nacimiento, @mami_nombre, @papi_nombre, @DNI);";
            cmd.Parameters.AddWithValue("@nombre", paciente.nombre);
            cmd.Parameters.AddWithValue("@direccion", paciente.direccion);
            cmd.Parameters.AddWithValue("@telefono", paciente.telefono);
            cmd.Parameters.AddWithValue("@fecha_nacimiento", paciente.fecha_nacimiento);
            cmd.Parameters.AddWithValue("@mami_nombre", paciente.mami_nombre);
            cmd.Parameters.AddWithValue("@papi_nombre", paciente.papi_nombre);
            cmd.Parameters.AddWithValue("@dni", paciente.DNI);

            cmd.ExecuteNonQuery();
            cmd.CommandText = "select max(paciente_id) as nuevoId from pacientes where nombre=@nombre;";
            cmd.Parameters["@nombre"].Value = paciente.nombre;

            MySqlDataReader dr = cmd.ExecuteReader();

            int nuevoId;

            if (dr.Read())
            {
                nuevoId = Convert.ToInt32(dr["nuevoId"]);
            }
            else
            {
                nuevoId = 0;
            }
            cnx.Close();
            return nuevoId;
        }

        public bool actualizar(pacienteCE paciente)
        {
            bool estado = false;
            MySqlConnection cnx = conexionCD.cnx();
            cnx.Open();

            MySqlCommand cmd = cnx.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update paciente set nombre=@nombre, direccion=@direccion, telefono=@telefono, mami_nombre=@mami_nombre, papi_nombre=papi_nombre where paciente_id=@paciente_id;";
            cmd.Parameters.AddWithValue("@paciente_id", paciente.paciente_id);
            cmd.Parameters.AddWithValue("@nombre", paciente.nombre);
            cmd.Parameters.AddWithValue("@direccion", paciente.direccion);
            cmd.Parameters.AddWithValue("@telefono", paciente.telefono);
            cmd.Parameters.AddWithValue("@mami_nombre", paciente.mami_nombre);
            cmd.Parameters.AddWithValue("@papi_nombre", paciente.papi_nombre);

            cmd.ExecuteNonQuery();
            cnx.Close();
            estado = true;
            return estado;
        }

        public bool eliminar(int idEliminar)
        {
            bool estado = false;
            MySqlConnection cnx = conexionCD.cnx();
            cnx.Open();

            MySqlCommand cmd = cnx.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from pacientes where paciente_id=@paciente_id;";
            cmd.Parameters.AddWithValue("@paciente_id", idEliminar);

            cmd.ExecuteNonQuery();
            cnx.Close();
            estado = true;
            return estado;
        }

        public List<pacienteCE> LeerTodosLosPacientes()
        {
            MySqlConnection cnx = conexionCD.cnx();
            cnx.Open();

            MySqlCommand cmd = cnx.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "LeerTodosLosPacientes";

            MySqlDataReader dr = cmd.ExecuteReader();
            List<pacienteCE> pacientes = new List<pacienteCE>();

            while (dr.Read())
            {
                int paciente_id = Convert.ToInt32(dr["paciente_id"]);
                string nombre = dr["nombre"] == DBNull.Value ? "sin valor" : (string)dr["nombre"];
                string direccion = dr["direccion"] == DBNull.Value ? "sin valor" : (string)dr["direccion"];
                int dni = dr["DNI"] == DBNull.Value ? 0 : Convert.ToInt32(dr["DNI"]);
                string telefono = dr["telefono"] == DBNull.Value ? "sin valor" : (string)dr["telefono"];
                DateTime fecha_nacimiento = dr["fecha_nacimiento"] == DBNull.Value ? DateTime.MinValue : (DateTime)dr["fecha_nacimiento"];
                string mami_nombre = dr["mami_nombre"] == DBNull.Value ? "sin valor" : (string)dr["mami_nombre"];
                string papi_nombre = dr["papi_nombre"] == DBNull.Value ? "sin valor" : (string)dr["papi_nombre"];

                pacienteCE paciente = new pacienteCE();
                paciente.paciente_id = paciente_id;
                paciente.nombre = nombre;
                paciente.direccion = direccion;
                paciente.DNI = dni;
                paciente.telefono = telefono;
                paciente.fecha_nacimiento = fecha_nacimiento;
                paciente.mami_nombre = mami_nombre;
                paciente.papi_nombre = papi_nombre;
                pacientes.Add(paciente);
            }

            cnx.Close();

            return pacientes;
        }

        public int mostrarCantidadPacientes()
        {
            MySqlConnection cnx = conexionCD.cnx();
            cnx.Open();

            string sql = "SELECT COUNT(*) FROM Pacientes";
            MySqlCommand cmd = new MySqlCommand(sql, cnx);

            int totalPacientes = Convert.ToInt32(cmd.ExecuteScalar());
            cnx.Close();

            return totalPacientes;
        }

        public int mostrarCantidadHistorias()
        {
            MySqlConnection cnx = conexionCD.cnx();
            cnx.Open();

            string sql = "SELECT COUNT(*) FROM Consultas";
            MySqlCommand cmd = new MySqlCommand(sql, cnx);

            int totalPacientes = Convert.ToInt32(cmd.ExecuteScalar());
            cnx.Close();

            return totalPacientes;
        }
    }
}
