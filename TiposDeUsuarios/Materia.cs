using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposDeUsuarios
{
    public class Materia
    {
        private string _nombre = "";       
        private string _profesoruser = "";
        private string _materiaCorrelativa = "";


       
        public Materia()
        {

        }
        public Materia(string nombre):this()
        {
            this.Nombre = nombre;
        }
        public Materia(string nombre,string correlativa) : this(nombre)
        {
            this.MateriaCorrelativa = correlativa;
        }
        public Materia(string nombre,string correlativa, string profesoruser) :this(nombre,correlativa)
        {                    
            this.ProfesorUser = profesoruser;
            
        }

        public string Nombre { get => _nombre; set => _nombre = value; }             
        public string ProfesorUser { get => _profesoruser; set => _profesoruser = value; }
       
        public string MateriaCorrelativa { get => _materiaCorrelativa; set => _materiaCorrelativa = value; }



               


    }
}


