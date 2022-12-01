using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace TiposDeUsuarios
{
    public class Admin_dao : ITodaLaLista<Admin>
    {
        private static SqlCommand _sqlCommand;
        private static SqlConnection _sqlConnection;

        static Admin_dao()
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
        /// Lee todos los admins de la base de datos
        /// </summary>
        /// <returns> Devuelve una lista de esos admins </returns>        
        public List<Admin> LeerListaCompleta()
        {
            List<Admin> admins = new List<Admin>();


            try
            {
                _sqlCommand.Parameters.Clear();
                _sqlConnection.Open();

                _sqlCommand.CommandText = "SELECT * FROM Admin";

                SqlDataReader reader = _sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    admins.Add(new Admin(reader["usuario"].ToString(), reader["pass"].ToString(), reader["nombre"].ToString()));

                }

                return admins;

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
        /// Carga un nuevo admin a la base de datos
        /// </summary>
        /// <param name="admin"> parametros del nuevo admin</param>        
        public static void CargarAdmin(Admin admin)
        {
            try
            {
                _sqlCommand.Parameters.Clear();
                _sqlConnection.Open();

                _sqlCommand.CommandText = $"INSERT INTO Admin (usuario,pass,nombre)  Values (@usuario, @pass, @nombre)";
                _sqlCommand.Parameters.AddWithValue("@nombre", admin.Nombre);
                _sqlCommand.Parameters.AddWithValue("@usuario", admin.User);
                _sqlCommand.Parameters.AddWithValue("@pass", admin.Pass);
                _sqlCommand.ExecuteNonQuery();

            }
            catch (Exception)
            {

                throw new Exception("Error al cargar datos");
            }
            finally
            {
                _sqlConnection.Close();
            }


        }


       


    }
}
