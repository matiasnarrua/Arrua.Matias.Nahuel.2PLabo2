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
                    materiasCursadas.Add(new MateriaCursada(reader["usuario"].ToString(), reader["MateriaCursada"].ToString(),  reader["EstadoMateria"].ToString() , Alumno.StringAEnum(reader["EstadoAlumno"].ToString())));

                }

                return materiasCursadas;

            }
            catch (Exception)
            {

                throw new Exception("Error al leer los datos");
            }
            finally
            {
                if (_sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    _sqlConnection.Close();
                }
            }
        }

        public static List<MateriaCursada> LeerAlumnosDeMateria(string materia)
        {
            List<MateriaCursada> materiasCursadas = new List<MateriaCursada>();


            try
            {
                _sqlCommand.Parameters.Clear();
                _sqlConnection.Open();

                _sqlCommand.CommandText = $"SELECT * FROM MateriasCursadas WHERE MateriaCursada = '{materia}' ";

                SqlDataReader reader = _sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    materiasCursadas.Add(new MateriaCursada(reader["usuario"].ToString(), reader["MateriaCursada"].ToString(), reader["EstadoMateria"].ToString(), Alumno.StringAEnum(reader["EstadoAlumno"].ToString())));

                }

                return materiasCursadas;

            }
            catch (Exception)
            {

                throw new Exception("Error al leer los datos");
            }
            finally
            {
                if (_sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    _sqlConnection.Close();
                }
            }
        }

        public static List<Examen> LeerExamenesDeLaMateria(string materia,string profesor)
        {
            List<Examen> materiasCursadas = new List<Examen>();


            try
            {
                _sqlCommand.Parameters.Clear();
                _sqlConnection.Open();

                _sqlCommand.CommandText = $"SELECT * FROM Examenes WHERE materia = '{materia}' AND profesor = '{profesor}'";

                SqlDataReader reader = _sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    materiasCursadas.Add(new Examen(reader["NombreExamen"].ToString(), Convert.ToDateTime(reader["Fecha"]), reader["Materia"].ToString(), Convert.ToInt32(reader["Nota"]), reader["alumno"].ToString(), reader["profesor"].ToString()));

                }

                return materiasCursadas;

            }
            catch (Exception)
            {

                throw new Exception("Error al leer los datos");
            }
            finally
            {
                if (_sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    _sqlConnection.Close();
                }
            }
        }

        public static List<MateriaCursada> LeerMateriasCursadas(Alumno alumno)
        {
            List<MateriaCursada> materiasCursadas = new List<MateriaCursada>();


            try
            {
                _sqlCommand.Parameters.Clear();
                _sqlConnection.Open();

                _sqlCommand.CommandText = $"SELECT * FROM MateriasCursadas WHERE usuario = '{alumno.User}' ";

                SqlDataReader reader = _sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    materiasCursadas.Add(new MateriaCursada(reader["usuario"].ToString(), reader["MateriaCursada"].ToString(), reader["EstadoMateria"].ToString(), Alumno.StringAEnum(reader["EstadoAlumno"].ToString())));

                }

                return materiasCursadas;

            }
            catch (Exception)
            {

                throw new Exception("Error al leer los datos");
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

                throw new Exception("Error al modificar los datos");
            }
            finally
            {
                _sqlConnection.Close();
            }


        }

        public static void ModificarEstadoMateria(MateriaCursada materia, Examen examen)
        {
            try
            {
                _sqlCommand.Parameters.Clear();
                _sqlConnection.Open();

                _sqlCommand.CommandText = $"UPDATE MateriasCursadas SET EstadoMateria = @estadoMateria WHERE usuario = '{materia.Usuario}' AND MateriaCursada = '{examen.Materia}' ";
                _sqlCommand.Parameters.AddWithValue("@estadoMateria", materia.EstadoMateria);

                _sqlCommand.ExecuteNonQuery();

            }
            catch (Exception)
            {

                throw new Exception("Error al modificar los datos");
            }
            finally
            {
                _sqlConnection.Close();
            }

        }


        public static void ModificarEstadoAlumno(string estado,MateriaCursada materia)
        {
            try
            {
                _sqlCommand.Parameters.Clear();
                _sqlConnection.Open();

                _sqlCommand.CommandText = $"UPDATE MateriasCursadas SET EstadoAlumno = @EstadoAlumno WHERE usuario = '{materia.Usuario}' AND MateriaCursada = '{materia.Materia}' ";
                _sqlCommand.Parameters.AddWithValue("@EstadoAlumno", estado);

                _sqlCommand.ExecuteNonQuery();

            }
            catch (Exception)
            {

                throw new Exception("Error al modificar los datos");
            }
            finally
            {
                _sqlConnection.Close();
            }

        }
    }
}
