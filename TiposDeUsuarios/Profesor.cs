using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposDeUsuarios
{
    public class Profesor : Usuario
    {
        private string _nombre= " ";       
      
        
        public Profesor(string user, string pass) : base(user, pass)
        {

        }
        public Profesor(string user, string pass, string nombre) : base(user, pass)
        {
            this.Nombre = nombre;
          
        }

        public string Nombre { get => _nombre; set => _nombre = value; }
        

        
    }
}
