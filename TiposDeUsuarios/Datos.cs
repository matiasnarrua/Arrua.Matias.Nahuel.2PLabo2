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

        #region Alumnos
        /// <summary>
        ///  instancia y agrega nuevo alumno a la lista estatica de listaAlumnos
        /// </summary>
        /// <param name="user">mail del alumno</param>
        /// <param name="pass">contraseña del alumno</param>
        /// <param name="nombre">nombre del alumno</param>
        /// <param name="materiaCursada">mateira cursada del alumno</param>
        /// <param name="examenNombre">nombre del examen de la materia</param>
        /// <param name="examenNota">Nota del examen</param>
        /// <param name="estado">Estado, si es regular/libre/sin estado</param>
        /// <param name="estadoMateria">Estado de la materia aprobada o desaprobada</param>
        public static void CargarListaAlumnos(string user, string pass, string nombre, string materiaCursada, string examenNombre, int examenNota, EstadoDelAlumno estado,string estadoMateria)
        {
            listaAlumnos.Add(new Alumno(user, pass, nombre, materiaCursada, examenNombre, examenNota, estado,estadoMateria));
        }

        /// <summary>
        /// LLama al metodo CargarListaAlumnos Y Hardcodea
        /// </summary>
        public static void HardcodearListaAlumnos()
        {

            CargarListaAlumnos("alumno1@utn.com", "alumno1", "Pedro", "Programacion I", "Primer Parcial", 7, EstadoDelAlumno.Regular,"-");
            CargarListaAlumnos("alumno1@utn.com", "alumno1", "Pedro", "Programacion I", "Segundo Parcial", 7, EstadoDelAlumno.Regular, "-");
            CargarListaAlumnos("alumno1@utn.com", "alumno1", "Pedro", "Laboratorio I", "", 0, EstadoDelAlumno.Libre,"-");
            CargarListaAlumnos("alumno1@utn.com", "alumno1", "Pedro", "Matematica I", "", 0, EstadoDelAlumno.SinEstado,"-");
            CargarListaAlumnos("alumno2@utn.com", "alumno2", "Carlos", "Matematica I", "", 0, EstadoDelAlumno.SinEstado,"-");
            CargarListaAlumnos("alumno3@utn.com", "alumno3", "Camila", "-", "", 0, EstadoDelAlumno.SinEstado,"-");
            CargarListaAlumnos("alumno2@utn.com", "alumno2", "Carlos", "Programacion I", "", 0, EstadoDelAlumno.SinEstado,"-");

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

        #region Profesor
        /// <summary>
        /// instancia y agrega nuevo profesor a la lista estatica de listaProfesores
        /// </summary>
        /// <param name="user">usuario del profesor</param>
        /// <param name="pass">contraseña del profesor</param>
        /// <param name="nombre">nombre del profesor</param>
        /// <param name="materia">materia asignada del profesor</param>
        public static void CargarListaProfesor(string user, string pass, string nombre, string materia)
        {
            listaProfesores.Add(new Profesor(user, pass, nombre, materia));
        }
        /// <summary>
        /// Llama al metodo CargarListaProfesor y hardcodea
        /// </summary>
        public static void HardcodearListaProfesores()
        {
            Materia materia = new Materia(" ");
            materia.Nombre = "Programacion I";
            CargarListaProfesor("profesor@utn.com", "profesor", "Mario", "Programacion I");
            materia.Nombre = "-";
            CargarListaProfesor("profesor2@utn.com", "profesor2", "Felipe", "Laboratorio I");
            materia.Nombre = "-";
            CargarListaProfesor("profesor3@utn.com", "profesor3", "Daniel", "-");
            materia.Nombre = "-";
            CargarListaProfesor("profesor4@utn.com", "profesor4", "Nuria", "-");

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
        /// Llama a todos los Metodos que hardcodeen listas estaticas
        /// </summary>
        public static void HardcodearListas()
        {
            HardcodearListaMaterias();
            HardcodearListaAlumnos();
            HardcodearListaAdmins();
            HardcodearListaProfesores();
            HardcodearListaExamenes();

        }

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
        public static List<Alumno> DevolverMateriasCursadas(Alumno alumno)
        {
            List<Alumno> listAux = new List<Alumno>();

            foreach (Alumno alumno1 in Datos.listaAlumnos)
            {
                if (alumno.User == alumno1.User)
                {
                    listAux.Add(alumno1);
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

            foreach (Examen examen in Datos.listaExamenes)
            {
                if (examen.Materia == profesor.MateriaAsignada)
                {
                    listaExamenes.Add(examen);
                    
                }
            }

            return listaExamenes;
        }

        
    }
}
