using capaEntidad;
using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace capaDatos
{
    public class historiaCD
    {
        public int insertar(historiaCE historia)
        {
            MySqlConnection cnx = conexionCD.cnx();
            cnx.Open();

            MySqlCommand cmd = cnx.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "RegistrarConsulta";

            cmd.Parameters.AddWithValue("@p_paciente_id", historia.paciente_id);
            cmd.Parameters.AddWithValue("@p_fecha_consulta", historia.fecha_consulta);
            cmd.Parameters.AddWithValue("@p_edad", historia.edad);
            cmd.Parameters.AddWithValue("@p_peso", historia.peso);
            cmd.Parameters.AddWithValue("@p_talla", historia.talla);
            cmd.Parameters.AddWithValue("@p_frecuencia_respiratoria", historia.frecuencia_respiratoria);
            cmd.Parameters.AddWithValue("@p_frecuencia_cardiaca", historia.frecuencia_cardiaca);
            cmd.Parameters.AddWithValue("@p_temperatura", historia.temperatura);
            cmd.Parameters.AddWithValue("@p_presion_arterial", historia.presion_arterial);
            cmd.Parameters.AddWithValue("@p_tiempo", historia.tiempo);
            cmd.Parameters.AddWithValue("@p_signos_sintomas", historia.signos_sintomas);
            cmd.Parameters.AddWithValue("@p_relato", historia.relato);
            cmd.Parameters.AddWithValue("@p_examen_fisico", historia.examen_fisico);
            cmd.Parameters.AddWithValue("@p_antecedentes", historia.antecedentes);
            cmd.Parameters.AddWithValue("@p_diagnosticos", historia.diagnosticos);
            cmd.Parameters.AddWithValue("@p_prescripcion_medica", historia.prescripcion_medica);

            // Parámetro de salida para el nuevo ID
            MySqlParameter nuevoIdParam = new MySqlParameter("@nuevoId", MySqlDbType.Int32);
            nuevoIdParam.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(nuevoIdParam);

            cmd.ExecuteNonQuery();

            int nuevoId = Convert.ToInt32(cmd.Parameters["@nuevoId"].Value);

            cnx.Close();
            return nuevoId;
        }
    }
}
