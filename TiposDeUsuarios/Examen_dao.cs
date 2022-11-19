using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposDeUsuarios
{
    public class Examen_dao
    {
        private static SqlCommand _sqlCommand;
        private static SqlConnection _sqlConnection;

        static Examen_dao()
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

        public static List<Examen> LeerExamen()
        {
            List<Examen> examenes = new List<Examen>();


            try
            {
                _sqlCommand.Parameters.Clear();
                _sqlConnection.Open();

                _sqlCommand.CommandText = "SELECT * FROM Examenes";

                SqlDataReader reader = _sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    examenes.Add(new Examen(reader["NombreExamen"].ToString(),Convert.ToDateTime( reader["Fecha"]), reader["Materia"].ToString(), Convert.ToInt32 (reader["Nota"]), reader["alumno"].ToString()  ));
                    
                }

                return examenes;

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

        public static List<Examen> LeerExamenAlumno(Alumno alumno)
        {
            List<Examen> examenes = new List<Examen>();


            try
            {
                _sqlCommand.Parameters.Clear();
                _sqlConnection.Open();

                _sqlCommand.CommandText = $"SELECT * FROM Examenes WHERE alumno = {alumno.User}";

                SqlDataReader reader = _sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    examenes.Add(new Examen(reader["NombreExamen"].ToString(), Convert.ToDateTime(reader["Fecha"]), reader["Materia"].ToString(), Convert.ToInt32(reader["Nota"]), reader["alumno"].ToString()));

                }

                return examenes;

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

        public static List<Examen> LeerExamenProfesor(Profesor profesor)
        {
            List<Examen> examenes = new List<Examen>();


            try
            {
                _sqlCommand.Parameters.Clear();
                _sqlConnection.Open();

                _sqlCommand.CommandText = $"SELECT * FROM Examenes WHERE profesor = '{profesor.User}'";

                SqlDataReader reader = _sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    examenes.Add(new Examen(reader["NombreExamen"].ToString(), Convert.ToDateTime(reader["Fecha"]), reader["Materia"].ToString(), Convert.ToInt32(reader["Nota"]), reader["alumno"].ToString()));

                }

                return examenes;

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

        public static void CargarExamen(Examen examen)
        {
            try
            {
                _sqlCommand.Parameters.Clear();
                _sqlConnection.Open();

                _sqlCommand.CommandText = $"INSERT INTO Examenes (NombreExamen,Fecha,Materia,Nota,alumno,Profesor)  Values (@NombreExamen, @Fecha, @Materia, @Nota, @alumno, @Profesor)";
                _sqlCommand.Parameters.AddWithValue("@NombreExamen", examen.Nombre);
                _sqlCommand.Parameters.AddWithValue("@Fecha", examen.Fecha);
                _sqlCommand.Parameters.AddWithValue("@Materia", examen.Materia);
                _sqlCommand.Parameters.AddWithValue("@Nota", examen.Nota);
                _sqlCommand.Parameters.AddWithValue("@alumno", examen.Alumno);
                _sqlCommand.Parameters.AddWithValue("@Profesor", examen.Profesor);

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
