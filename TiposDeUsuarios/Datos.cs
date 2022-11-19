using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposDeUsuarios
{
    public static class Datos
    {
        public static List<Materia> listaMaterias = new List<Materia>();
        public static List<Alumno> listaAlumnos = new List<Alumno>();
        public static List<Admin> listaAdmins = new List<Admin>();
        public static List<Profesor> listaProfesores = new List<Profesor>();
        public static List<Examen> listaExamenes = new List<Examen>();
        public static List<string> listaPresentes = new List<string>();
        public static bool flag = true;

        #region Materias
        /// <summary>
        /// instancia y agrega nueva materia a la lista estatica de listaMaterias
        /// </summary>
        /// <param name="nombre"> nombre de la materia</param>
        /// <param name="profesor"> nombre del profesor que tiene asignada esa materia</param>
        /// <param name="correlativa">Nombre de la materia correlativa</param>
        public static void CargarListaMaterias(string nombre, string profesor, string correlativa)
        {
            listaMaterias.Add(new Materia(nombre, profesor, correlativa));
        }
        /// <summary>
        /// LLama al metodo CargarListaMaterias Y Hardcodea
        /// </summary>
        public static void HardcodearListaMaterias()
        {
           
            CargarListaMaterias("Matematica I", "-", "-");
            CargarListaMaterias("Laboratorio I", "Felipe", "-");
            CargarListaMaterias("Programacion I", "Mario", "-");
            CargarListaMaterias("Ingles I", "-", "-");
            CargarListaMaterias("Ingles II", "-", "Ingles I");
            CargarListaMaterias("Programacion II", "-", "Programacion I");
        }


        #endregion

       

       


        #region Admins
        /// <summary>
        /// instancia y agrega nuevo admin a la lista estatica de listaAdmins
        /// </summary>
        /// <param name="user">mail del admin</param>
        /// <param name="pass">contraseña del admin</param>
        /// <param name="nombre">nombre del admin</param>
        public static void CargarListaAdmin(string user, string pass, string nombre)
        {
            listaAdmins.Add(new Admin(user, pass, nombre));
        }
        /// <summary>
        /// LLama al metodo CargarListaAdmin Y Hardcodea
        /// </summary>
        public static void HardcodearListaAdmins()
        {
            CargarListaAdmin("admin@utn.com", "admin", "Julian");
            CargarListaAdmin("admin2@utn.com", "admin2", "Belen");

        }



        #endregion

       

        #region Examenes
        /// <summary>
        /// instancia y agrega nueva materia a la lista estatica de listaMaterias
        /// 
        /// </summary>
        /// <param name="nombre">nombre del examen</param>
        /// <param name="fecha">fecha del examen</param>
        /// <param name="materia">materia a la que pertenece el examen</param>
        public static void CargarListaExamenes(string nombre, DateTime fecha, string materia)
        {
            listaExamenes.Add(new Examen(nombre, fecha, materia));
        }
        /// <summary>
        /// Llama al metodo CargarListaExamenes y hardcodea
        /// </summary>
        public static void HardcodearListaExamenes()
        {
            DateTime fecha = new DateTime(2022, 04, 05);
            DateTime fecha2 = new DateTime(2022, 08, 25);
            CargarListaExamenes("Primer Parcial", fecha, "Programacion I");
            CargarListaExamenes("Segundo Parcial", fecha2, "Programacion I");

        }


        #endregion


      

        /// <summary>
        /// Se le pasa un string y devuelve el mismo con solo la primer letra en mayuscula
        /// </summary>
        /// <param name="value"> string a modificar</param>
        /// <returns></returns>
        public static string HacerPrimerLetraMayus(this string value)
        {
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(value);
        }

        /// <summary>
        /// Busca el mismo usuario de Tipo Admin en la lista estaitca
        /// </summary>
        /// <param name="user">Mail del usuario</param>
        /// <param name="lista">Lista en la que se va a buscar</param>
        /// <returns></returns>
        public static bool BuscarMismoUser(string user, List<Admin> lista)
        {

            foreach (Admin admin in lista)
            {
                if (admin.User == user)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Busca el mismo usuario de Tipo Alumno en la lista estaitca
        /// </summary>
        /// <param name="user">Mail del usuario</param>
        /// <param name="lista">Lista en la que se va a buscar</param>
        /// <returns></returns>
        public static bool BuscarMismoUser(string user, List<Alumno> lista)
        {

            foreach (Alumno alumno in lista)
            {
                if (alumno.User == user)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Busca el mismo usuario de Tipo Profesor en la lista estaitca
        /// </summary>
        /// <param name="user">Mail del usuario</param>
        /// <param name="lista">Lista en la que se va a buscar</param>
        /// <returns></returns>
        public static bool BuscarMismoUser(string user, List<Profesor> lista)
        {

            foreach (Profesor profesor in lista)
            {
                if (profesor.User == user)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Busca un Profesor a partir del usuario en la lista, y lo devuelve
        /// </summary>
        /// <param name="user">mail del usuario que se va a buscar</param>
        /// <param name="lista">Lista en la que se va a buscar</param>
        /// <returns></returns>
        public static Profesor DevolverProfesor(string user, List<Profesor> lista)
        {
            Profesor pf = new Profesor("", "");
            foreach (Profesor profesor in lista)
            {
                if (profesor.User == user)
                {
                    return profesor;
                }
            }
            return pf;
        }

        /// <summary>
        /// Busca un Alumno a partir del usuario, en la lista, y lo devuelve
        /// </summary>
        /// <param name="user">mail del usuario que se va a buscar</param>
        /// <param name="lista">Lista en la que se va a buscar</param>
        /// <returns></returns>
        public static Alumno DevolverAlumno(string user, List<Alumno> lista)
        {
            Alumno alum = new Alumno("", "");
            foreach (Alumno alumno in lista)
            {
                if (alumno.User == user)
                {
                    return alumno;
                }
            }
            return alum;
        }

        /// <summary>
        /// Busca y devuelve una lista de las materias que cursa un alumno
        /// </summary>
        /// <param name="alumno">alumno del que quiero las materias que cursa</param>
        /// <returns></returns>       
        public static List<MateriaCursada> DevolverMateriasCursadas(MateriaCursada materiaCursada)
        {
            List<MateriaCursada> listAux = new List<MateriaCursada>();

            foreach (MateriaCursada materiaAux in MateriaCursada_dao.LeerMateriasCursadas())
            {
                if (materiaCursada.Usuario == materiaAux.Usuario)
                {
                    listAux.Add(materiaAux);
                }

            }
            return listAux;
        }

        /// <summary>
        /// Busca y devuelve una lista de los examenes del profesor 
        /// </summary>
        /// <param name="profesor">Profesor del que quiero sus examenes</param>
        /// <returns></returns>
        public static List<Examen> TraerExamenDeSuMateria(Profesor profesor)
        {
            List<Examen> listaExamenes = new List<Examen>();

            foreach (Examen examen in Examen_dao.LeerExamen())
            {
                if (examen.Profesor == profesor.User)
                {
                    listaExamenes.Add(examen);

                }
            }

            return listaExamenes;
        }


    }
}
