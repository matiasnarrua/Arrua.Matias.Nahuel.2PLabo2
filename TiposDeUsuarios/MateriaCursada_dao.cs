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

        /// <summary>
        /// Lee de la base de datos las materias cursadas
        /// </summary>
        /// <returns>Devuelve todas las materias cursadas</returns>
        /// <exception cref="Exception"></exception>
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

        /// <summary>
        /// Lee los alumnos de una materia en especifico 
        /// </summary>
        /// <param name="materia">Materia de la que se quieren los alumnos</param>
        /// <returns>Lista de los alumnos que cursan esa materia</returns>
        /// <exception cref="Exception"></exception>
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

        /// <summary>
        /// Lee las materias de un alumno en especifico desde la base de datos
        /// </summary>
        /// <param name="alumno">alumno de que se piden las materias</param>
        /// <returns>Una lista de materiasCursadas del alumno</returns>
        /// <exception cref="Exception"></exception>
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

        /// <summary>
        /// Inserta en la base de datos una nueva MateriaCursada
        /// </summary>
        /// <param name="materiasCursadas">MateriaCursada que se quiere cargar</param>
        /// <exception cref="Exception"></exception>
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

        /// <summary>
        /// Modifica en la base de datos el estado de una materia
        /// </summary>
        /// <param name="materia">Materia que se quiere modificar</param>
        /// <param name="examen"></param>
        /// <exception cref="Exception"></exception>
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

        /// <summary>
        /// Modifica en la base de datos el estado de un alumno
        /// </summary>
        /// <param name="estado">estado que se va a asignar</param>
        /// <param name="materia"> MateriaCursada que se va a modificar</param>
        /// <exception cref="Exception"></exception>
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
