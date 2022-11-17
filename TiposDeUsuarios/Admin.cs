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

        /// <summary>
        /// instancia y agrega nuevo admin a la lista estatica de listaAdmins
        /// 
        /// </summary>
        /// <param name="user">usuario del admin</param>
        /// <param name="pass">contraseña del admin</param>
        /// <param name="nombre">nombre del admin</param>
        public override void AgregarUsuario(string user, string pass, string nombre)
        {
            Datos.listaAdmins.Add(new Admin(user.ToLower(), pass, Datos.HacerPrimerLetraMayus(nombre)));
        }
    }
}
