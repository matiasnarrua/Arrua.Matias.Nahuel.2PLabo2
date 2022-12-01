using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposDeUsuarios
{
    public class Alumno_dao : ITodaLaLista<Alumno>
    {
        private static SqlCommand _sqlCommand;
        private static SqlConnection _sqlConnection;

        static Alumno_dao()
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

               

        public List<Alumno> LeerListaCompleta()
        {
            List<Alumno> alumnos = new List<Alumno>();


            try
            {
                _sqlCommand.Parameters.Clear();
                _sqlConnection.Open();

                _sqlCommand.CommandText = "SELECT * FROM Alumnos";

                SqlDataReader reader = _sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    alumnos.Add(new Alumno(reader["usuario"].ToString(), reader["pass"].ToString(), reader["nombre"].ToString()));

                }

                return alumnos;

            }
            catch (Exception)
            {

                throw new Exception("Error al importar datos del alumno");
            }
            finally
            {
                if (_sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    _sqlConnection.Close();
                }
            }
        }

        public static Alumno DevolverAlumno(string user, string pass)
        {
            Alumno alumno = new Alumno("","");

            try
            {
                _sqlCommand.Parameters.Clear();
                _sqlConnection.Open();

                _sqlCommand.CommandText = $"SELECT * FROM Alumnos WHERE usuario = '{user}' AND pass = '{pass}'";

                SqlDataReader reader = _sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    alumno.User = reader["usuario"].ToString();
                    alumno.Pass = reader["pass"].ToString();
                    alumno.Nombre = reader["nombre"].ToString();


                }

                return alumno;

            }
            catch (Exception)
            {

                throw new Exception("Error al importar datos del alumno");
            }
            finally
            {
                if (_sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    _sqlConnection.Close();
                }
            }
        }

        public static void CargarAlumno(Alumno alumno)
        {
            try
            {
                _sqlCommand.Parameters.Clear();
                _sqlConnection.Open();

                _sqlCommand.CommandText = $"INSERT INTO Alumnos (usuario,pass,nombre)  Values (@usuario, @pass, @nombre)";
                _sqlCommand.Parameters.AddWithValue("@nombre", alumno.Nombre);
                _sqlCommand.Parameters.AddWithValue("@usuario", alumno.User);
                _sqlCommand.Parameters.AddWithValue("@pass", alumno.Pass);

                _sqlCommand.ExecuteNonQuery();

            }
            catch (Exception)
            {

                throw new Exception("Error al cargar datos del alumno");
            }
            finally
            {
                _sqlConnection.Close();
            }


        }
    }
}
