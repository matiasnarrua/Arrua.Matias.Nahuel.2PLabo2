using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposDeUsuarios
{
    public class Alumno : Usuario
    {
        private string _nombre = " ";
        public Alumno() { }
        public Alumno(string user, string pass) : base(user, pass)
        {

        }
        public Alumno(string user, string pass, string nombre) : base(user, pass)
        {
            this.Nombre = nombre;
        }        
        public string Nombre { get => _nombre; set => _nombre = value; }

        public static EstadoDelAlumno StringAEnum(string estado)
        {
            EstadoDelAlumno retorno = EstadoDelAlumno.SinEstado;
            if (estado == "Libre")
            {
                retorno = EstadoDelAlumno.Libre;
            }
            else if (estado == "Regular")
            {
                retorno = EstadoDelAlumno.Regular;
            }
            return retorno;
        }

        public List<Examen> CargarDgvAlumno(Alumno alumno)
        {
            List<Examen> examenes = new List<Examen>();
            foreach (Examen examen in ExamenAlumno_dao.LeerMateriaYExamen(alumno))
            {
                if (examen.Alumno == alumno.User)
                {
                    examenes.Add(examen);
                }
            }
            return examenes;
        }


    }
}
