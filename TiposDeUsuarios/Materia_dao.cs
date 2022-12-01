using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposDeUsuarios
{
    public class Materia_dao
    {
        private static SqlCommand _sqlCommand;
        private static SqlConnection _sqlConnection;

        static Materia_dao()
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
        /// Lee una lista de materias de la base de datos
        /// </summary>
        /// <returns>La lista de materias completa</returns>
        /// <exception cref="Exception"></exception>
        public static List<Materia> LeerMateria()
        {
            List<Materia> materias = new List<Materia>();

            try
            {
                _sqlCommand.Parameters.Clear();
                _sqlConnection.Open();

                _sqlCommand.CommandText = "SELECT * FROM Materias";

                SqlDataReader reader = _sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    materias.Add(new Materia(reader["NombreMateria"].ToString(), reader["Correlativa"].ToString(), reader["usuario"].ToString()));

                }

                return materias;

            }
            catch (Exception)
            {

                throw new Exception("Error al importar datos");
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
        /// Inserta en la base de datos una nueva materia
        /// </summary>
        /// <param name="materia">Materia que va a ser insertada</param>
        /// <exception cref="Exception"></exception>
        public static void CrearMateria(Materia materia)
        {
            try
            {
                _sqlCommand.Parameters.Clear();
                _sqlConnection.Open();

                _sqlCommand.CommandText = $"INSERT INTO Materias (NombreMateria,Correlativa)  Values (@NombreMateria, @Correlativa)";
                _sqlCommand.Parameters.AddWithValue("@NombreMateria", materia.Nombre);
                _sqlCommand.Parameters.AddWithValue("@Correlativa", materia.MateriaCorrelativa);              
                
                _sqlCommand.ExecuteNonQuery();

            }
            catch (Exception)
            {

                throw new Exception("Error al cargar una nueva materia");
            }
            finally
            {
                _sqlConnection.Close();
            }


        }

        /// <summary>
        /// Lee la materia de un profesor
        /// </summary>
        /// <param name="profesor">Profesor del que se pide la materia</param>
        /// <returns>Devuelve la materia que tiene asignada el profesor</returns>
        /// <exception cref="Exception"></exception>
        public static string LeerMateriaProfesor(Profesor profesor)
        {
           string materia = "";

            try
            {
                _sqlCommand.Parameters.Clear();
                _sqlConnection.Open();

                _sqlCommand.CommandText = $"SELECT * FROM Materias WHERE usuario = '{profesor.User}'";

                SqlDataReader reader = _sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    materia = reader["NombreMateria"].ToString();
                }

                return materia;

            }
            catch (Exception)
            {

                throw new Exception($"Error al leer la materia del profesor {profesor.Nombre}");
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
        /// Hace un update en la base de datos de la materia que tiene asignada un profesor
        /// </summary>
        /// <param name="profesorUser">usuario del profesor que se quiere modificar</param>
        /// <param name="materia">Materia que se quiere asignar</param>
        /// <exception cref="Exception"></exception>
        public static void ModificarProfesorMateria(string profesorUser,string materia)
        {
            try
            {
                _sqlCommand.Parameters.Clear();
                _sqlConnection.Open();

                _sqlCommand.CommandText = $"UPDATE Materias SET usuario = @usuario WHERE NombreMateria = '{materia}' ";
                _sqlCommand.Parameters.AddWithValue("@usuario", profesorUser);

                _sqlCommand.ExecuteNonQuery();

            }
            catch (Exception)
            {

                throw new Exception($"Error al la materia del profesor {profesorUser}");
            }
            finally
            {
                _sqlConnection.Close();
            }

        }

    }
}
