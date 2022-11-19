using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposDeUsuarios
{
    public class MateriaCursada_dao
    {

        private static SqlCommand _sqlCommand;
        private static SqlConnection _sqlConnection;

        static MateriaCursada_dao()
        {
            _sqlConnection = new SqlConnection(@"
             Data Source = .;
             Database = parcial_dos;
             Trusted_Connection = true;
             
             ");

            _sqlCommand = new SqlCommand();
            _sqlCommand.Connection = _sqlConnection;
            _sqlCommand.CommandType = System.Data.CommandType.Text;
        }

        public static List<MateriaCursada> LeerMateriasCursadas()
        {
            List<MateriaCursada > materiasCursadas = new List<MateriaCursada>();


            try
            {
                _sqlCommand.Parameters.Clear();
                _sqlConnection.Open();

                _sqlCommand.CommandText = "SELECT * FROM MateriasCursadas";

                SqlDataReader reader = _sqlCommand.ExecuteReader();

                while (reader.Read())
                {                    
                    materiasCursadas.Add(new MateriaCursada(reader["usuario"].ToString(), reader["MateriaCursada"].ToString(),  reader["EstadoMateria"].ToString() , Enum.Parse<EstadoDelAlumno>(reader["EstadoAlumno"].ToString())));

                }

                return materiasCursadas;

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (_sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    _sqlConnection.Close();
                }
            }
        }


        public static void CargarMateriaCursada(MateriaCursada materiasCursadas)
        {
            try
            {
                _sqlCommand.Parameters.Clear();
                _sqlConnection.Open();

                _sqlCommand.CommandText = $"INSERT INTO MateriasCursadas (usuario,MateriaCursada,EstadoMateria,EstadoAlumno)  Values (@usuario, @MateriaCursada, @EstadoMateria, @EstadoAlumno)";
                _sqlCommand.Parameters.AddWithValue("@usuario", materiasCursadas.Usuario);
                _sqlCommand.Parameters.AddWithValue("@MateriaCursada", materiasCursadas.Materia);
                _sqlCommand.Parameters.AddWithValue("@EstadoMateria", materiasCursadas.EstadoMateria);
                _sqlCommand.Parameters.AddWithValue("@EstadoAlumno", materiasCursadas.EstadoDelAlumno);

                _sqlCommand.ExecuteNonQuery();

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                _sqlConnection.Close();
            }


        }
    }
}
