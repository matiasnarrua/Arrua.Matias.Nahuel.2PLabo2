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

                _sqlCommand.CommandText = "SELECT * FROM Materia";

                SqlDataReader reader = _sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    materias.Add(new Materia(reader["NombreMateria"].ToString(), reader["Correlativa"].ToString(), reader["usuario"].ToString()));

                }

                return materias;

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


        public static void CargarMateria(Materia materia)
        {
            try
            {
                _sqlCommand.Parameters.Clear();
                _sqlConnection.Open();

                _sqlCommand.CommandText = $"INSERT INTO Materia (NombreMateria,Correlativa,usuario)  Values (@NombreMateria, @Correlativa, @usuario)";
                _sqlCommand.Parameters.AddWithValue("@NombreMateria", materia.Nombre);
                _sqlCommand.Parameters.AddWithValue("@Correlativa", materia.MateriaCorrelativa);
                _sqlCommand.Parameters.AddWithValue("@usuario", materia.ProfesorUser);
                
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
