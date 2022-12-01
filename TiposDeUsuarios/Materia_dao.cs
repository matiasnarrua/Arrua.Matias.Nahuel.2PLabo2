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
