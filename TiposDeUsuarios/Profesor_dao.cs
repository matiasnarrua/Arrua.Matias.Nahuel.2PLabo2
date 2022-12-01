using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposDeUsuarios
{
    public class Profesor_dao : ITodaLaLista<Profesor>
    {
        private static SqlCommand _sqlCommand;
        private static SqlConnection _sqlConnection;

        static Profesor_dao()
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
        /// Lee la lista completa de profesores desde la base de datos
        /// </summary>
        /// <returns>Una lista de Profesores</returns>
        /// <exception cref="Exception"></exception>
        public List<Profesor> LeerListaCompleta()
        {
            List<Profesor> profesores = new List<Profesor>();


            try
            {
                _sqlCommand.Parameters.Clear();
                _sqlConnection.Open();

                _sqlCommand.CommandText = "SELECT * FROM Profesor";

                SqlDataReader reader = _sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    profesores.Add(new Profesor(reader["usuario"].ToString(), reader["pass"].ToString(), reader["nombre"].ToString()));

                }

                return profesores;

            }
            catch (Exception)
            {

                throw new Exception("Error al leer la lista de profesores");
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
        /// Devuelve un profesor segun su user y pass 
        /// </summary>
        /// <param name="user">usuario del profesor</param>
        /// <param name="pass">password del profesor</param>
        /// <returns>Profesor segun su usuario y password </returns>
        /// <exception cref="Exception"></exception>
        public  static Profesor DevolverProfesor(string user,string pass)
        {
            Profesor profesor = new Profesor("","");

            try
            {
                _sqlCommand.Parameters.Clear();
                _sqlConnection.Open();

                _sqlCommand.CommandText = $"SELECT * FROM Profesor WHERE usuario = '{user}' AND pass = '{pass}' ";

                SqlDataReader reader = _sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    profesor.User = reader["usuario"].ToString();
                    profesor.Pass = reader["pass"].ToString();
                    profesor.Nombre = reader["nombre"].ToString();

                }

                return profesor;

            }
            catch (Exception)
            {

                throw new Exception("Error al leer la lista de profesores");
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
        /// Inserta un nuevo profesor en la base de datos
        /// </summary>
        /// <param name="profesor">Profesor que se va a cargar</param>
        /// <exception cref="Exception"></exception>
        public static void CargarProfesor(Profesor profesor)
        {
            try
            {
                _sqlCommand.Parameters.Clear();
                _sqlConnection.Open();

                _sqlCommand.CommandText = $"INSERT INTO Profesor (usuario,pass,nombre)  Values (@usuario, @pass, @nombre)";
                _sqlCommand.Parameters.AddWithValue("@nombre", profesor.Nombre);
                _sqlCommand.Parameters.AddWithValue("@usuario", profesor.User);
                _sqlCommand.Parameters.AddWithValue("@pass", profesor.Pass);
                
                _sqlCommand.ExecuteNonQuery();

            }
            catch (Exception)
            {

                throw new Exception("Error al cargar en la lista de profesores");
            }
            finally
            {
                _sqlConnection.Close();
            }


        }
               
        /// <summary>
        /// Buscar en la base de datos si un profesor tiene asignada una materia
        /// </summary>
        /// <param name="profesor"></param>
        /// <returns>True si el profesor tiene materia asignada, False si no lo tiene </returns>
        /// <exception cref="Exception"></exception>
        public static bool TieneMateria(Profesor profesor)
        {
            string materia;
            try
            {
                _sqlCommand.Parameters.Clear();
                _sqlConnection.Open();

                _sqlCommand.CommandText = $"SELECT * FROM Materias WHERE usuario = '{profesor.User}' ";

                SqlDataReader reader = _sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    materia = reader["NombreMateria"].ToString();

                    if (materia != null )
                    {
                        return true;
                    }


                }

                return false;

            }
            catch (Exception)
            {

                throw new Exception("Error al ");
            }
            finally
            {
                if (_sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    _sqlConnection.Close();
                }
            }
        }
    }
}
