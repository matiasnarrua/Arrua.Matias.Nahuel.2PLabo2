using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposDeUsuarios
{
    public class Profesor_dao
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

        public static List<Profesor> LeerProfesor()
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
                    profesores.Add(new Profesor(reader["usuario"].ToString(), reader["pass"].ToString(), reader["nombre"].ToString(), reader["materiaAsignada"].ToString()));

                }

                return profesores;

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


        public static void CargarProfesor(Profesor profesor)
        {
            try
            {
                _sqlCommand.Parameters.Clear();
                _sqlConnection.Open();

                _sqlCommand.CommandText = $"INSERT INTO Profesor (usuario,pass,nombre,materiaAsignada)  Values (@usuario, @pass, @nombre, @materiaAsignada)";
                _sqlCommand.Parameters.AddWithValue("@nombre", profesor.Nombre);
                _sqlCommand.Parameters.AddWithValue("@usuario", profesor.User);
                _sqlCommand.Parameters.AddWithValue("@pass", profesor.Pass);
                _sqlCommand.Parameters.AddWithValue("@materiaAsignada", profesor.MateriaAsignada);
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
