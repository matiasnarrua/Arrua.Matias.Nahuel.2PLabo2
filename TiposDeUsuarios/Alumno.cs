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
       
        public Alumno(string user, string pass) : base(user, pass)
        {

        }
        public Alumno(string user, string pass, string nombre) : base(user, pass)
        {
            this.Nombre = nombre;
        }        
        public string Nombre { get => _nombre; set => _nombre = value; }

               
        

    }
}
