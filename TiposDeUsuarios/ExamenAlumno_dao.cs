using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposDeUsuarios
{
    public class ExamenAlumno_dao
    {
        private static SqlCommand _sqlCommand;
        private static SqlConnection _sqlConnection;

        static ExamenAlumno_dao()
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
                    examenes.Add(new Examen(reader["NombreExamen"].ToString(),Convert.ToDateTime( reader["Fecha"]), reader["Materia"].ToString(), Convert.ToInt32 (reader["Nota"]), reader["alumno"].ToString(), reader["profesor"].ToString()));
                    
                }

                return examenes;

            }
            catch (Exception)
            {

                throw new Exception("Error al importar datos de los examenes");
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

                _sqlCommand.CommandText = $"SELECT * FROM Examenes WHERE alumno = '{alumno.User}'";

                SqlDataReader reader = _sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    examenes.Add(new Examen(reader["NombreExamen"].ToString(), Convert.ToDateTime(reader["Fecha"]), reader["Materia"].ToString(), Convert.ToInt32(reader["Nota"]), reader["alumno"].ToString(), reader["profesor"].ToString()));

                }

                return examenes;

            }
            catch (Exception)
            {

                throw new Exception("Error al importar examenes del alumno");
            }
            finally
            {
                if (_sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    _sqlConnection.Close();
                }
            }
        }
        public static List<Examen> LeerMateriaYExamen(Alumno alumno)
        {
            List<Examen> examenes = new List<Examen>();

            try
            {
                _sqlCommand.Parameters.Clear();
                _sqlConnection.Open();

                _sqlCommand.CommandText = $"SELECT a.MateriaCursada, b.NombreExamen, b.Fecha,b.Nota,b.Alumno,b.Profesor, a.EstadoMateria, a.EstadoAlumno FROM MateriasCursadas a INNER JOIN Examenes b ON a.usuario = '{alumno.User}' AND a.MateriaCursada = b.Materia";

                SqlDataReader reader = _sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                        examenes.Add(new Examen(reader["NombreExamen"].ToString(), Convert.ToDateTime(reader["Fecha"]), reader["MateriaCursada"].ToString(), Convert.ToInt32(reader["Nota"]), reader["alumno"].ToString(), reader["profesor"].ToString(), reader["EstadoMateria"].ToString(), Alumno.StringAEnum(reader["EstadoAlumno"].ToString())));

                }

                return examenes;

            }
            catch (Exception)
            {

                throw new Exception("Error al importar el alumno y sus examenes");
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

                _sqlCommand.CommandText = $"SELECT * FROM ExamenesProfesor WHERE profesor = '{profesor.User}'";

                SqlDataReader reader = _sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    examenes.Add(new Examen(reader["NombreExamen"].ToString(), Convert.ToDateTime(reader["Fecha"]), reader["Materia"].ToString(), 0, "", reader["profesor"].ToString()));

                }

                return examenes;

            }
            catch (Exception)
            {

                throw new Exception($"Error al importar examenes del profesor{profesor.Nombre}");
            }
            finally
            {
                if (_sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    _sqlConnection.Close();
                }
            }
        }

        public static List<Examen> LeerExamenAlumnosDeLaMateria(Profesor profesor)
        {
            List<Examen> examenes = new List<Examen>();


            try
            {
                _sqlCommand.Parameters.Clear();
                _sqlConnection.Open();

                _sqlCommand.CommandText = $"SELECT * FROM Examenes WHERE  Profesor = '{profesor.User}';";

                SqlDataReader reader = _sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    examenes.Add(new Examen(reader["NombreExamen"].ToString(), Convert.ToDateTime(reader["Fecha"]), reader["Materia"].ToString(), Convert.ToInt32(reader["Nota"]), reader["alumno"].ToString(), reader["profesor"].ToString()));

                }

                return examenes;

            }
            catch (Exception)
            {

                throw new Exception($"Error al importar alumnos del profesor: {profesor.Nombre}");
            }
            finally
            {
                if (_sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    _sqlConnection.Close();
                }
            }
        }


        public static void ModificarNota(Examen examen)
        {
            /// TODO 11  Problema al agregar AND fecha = '{examen.fecha}'   syntax '00'
            try
            {                
                _sqlCommand.Parameters.Clear();
                _sqlConnection.Open();

                _sqlCommand.CommandText = $"UPDATE Examenes SET nota = @nota WHERE alumno = '{examen.Alumno}' AND NombreExamen = '{examen.Nombre}'" +
                    $" AND Materia = '{examen.Materia}' AND Profesor = '{examen.Profesor}' ";
                                   
                
                _sqlCommand.Parameters.AddWithValue("@Nota", examen.Nota);
                
                _sqlCommand.ExecuteNonQuery();

            }
            catch (Exception)
            {
                throw new Exception($"Error al Modificar la nota del examen: {examen.Nombre} del usuario: {examen.Alumno}");
            }
            finally
            {
                _sqlConnection.Close();
            }


        }
        public static void CargarNuevoExamen(Examen examen)
        {
            
            try
            {
                _sqlCommand.Parameters.Clear();
                _sqlConnection.Open();

                _sqlCommand.CommandText = $"INSERT INTO ExamenesProfesor  (NombreExamen,Fecha,Materia,Profesor) " +
                    $" Values (@NombreExamen, @Fecha, @Materia, @Profesor)";
                _sqlCommand.Parameters.AddWithValue("@NombreExamen", examen.Nombre);
                _sqlCommand.Parameters.AddWithValue("@Fecha", examen.Fecha);
                _sqlCommand.Parameters.AddWithValue("@Materia", examen.Materia);                
                _sqlCommand.Parameters.AddWithValue("@Profesor", examen.Profesor);

                _sqlCommand.ExecuteNonQuery();

            }
            catch (Exception)
            {

                throw new Exception($"Error al cargar datos del nuevo examen {examen.Nombre}");
            }
            finally
            {
                _sqlConnection.Close();
            }

        }

        public static void AsignarNuevoExamen(Examen examen)
        {

            try
            {
                _sqlCommand.Parameters.Clear();
                _sqlConnection.Open();

                _sqlCommand.CommandText = $"INSERT INTO Examenes  (NombreExamen,Fecha,Materia,Profesor,Alumno,Nota) " +
                    $" Values (@NombreExamen, @Fecha, @Materia, @Profesor, @Alumno, @Nota)";
                _sqlCommand.Parameters.AddWithValue("@NombreExamen", examen.Nombre);
                _sqlCommand.Parameters.AddWithValue("@Fecha", examen.Fecha);
                _sqlCommand.Parameters.AddWithValue("@Materia", examen.Materia);
                _sqlCommand.Parameters.AddWithValue("@Profesor", examen.Profesor);
                _sqlCommand.Parameters.AddWithValue("@Alumno", examen.Alumno);
                _sqlCommand.Parameters.AddWithValue("@Nota", examen.Nota);


                _sqlCommand.ExecuteNonQuery();

            }
            catch (Exception)
            {

                throw new Exception("Error al Cargar datos del nuevo examen");
            }
            finally
            {
                _sqlConnection.Close();
            }

        }

    }
}
