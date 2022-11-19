using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposDeUsuarios
{
    public class Admin : Usuario
    {
        private string _nombre= "";
        public Admin(string user, string pass) : base(user, pass)
        {

        }
        public Admin(string user,string pass, string nombre) : base(user, pass)
        {
            this.Nombre = nombre;
        }

        public string Nombre { get => _nombre; set => _nombre = value; }

        
    }
}
