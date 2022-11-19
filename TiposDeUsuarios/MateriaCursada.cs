using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposDeUsuarios
{
    public class MateriaCursada
    {
        private string _usuario = "";
        private string _materia = "";
        private string _estadoMateria = "";
        EstadoDelAlumno estadoDelAlumno = EstadoDelAlumno.SinEstado;

        public MateriaCursada(string usuario, string materia)
        {
            _usuario = usuario;
            _materia = materia;
        }

        public MateriaCursada(string usuario, string materia, string estadoMateria, EstadoDelAlumno estadoDelAlumno):this(usuario,materia)
        {            
            _estadoMateria = estadoMateria;
            this.estadoDelAlumno = estadoDelAlumno;
        }

        public string Usuario { get => _usuario; set => _usuario = value; }
        public string Materia { get => _materia; set => _materia = value; }
        public string EstadoMateria { get => _estadoMateria; set => _estadoMateria = value; }
        public EstadoDelAlumno EstadoDelAlumno { get => estadoDelAlumno; set => estadoDelAlumno = value; }
    }
}
