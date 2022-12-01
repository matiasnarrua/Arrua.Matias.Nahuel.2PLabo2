using System.Globalization;

namespace TiposDeUsuarios
{
    public abstract class Usuario 
    {
        private string _user;
        private string _pass;

        public Usuario()
        {

        }

        public Usuario(string user, string pass) : this ()
        {
            this._user = user;
            this._pass = pass;
        }

        public string User { get => _user; set => _user = value; }
        public string Pass { get => _pass; set => _pass = value; }

       public static bool BuscarMismoUser(string usuario)
        {
            Profesor_dao prof = new Profesor_dao();
            Alumno_dao alum=new Alumno_dao();
            Admin_dao adm = new Admin_dao();
            foreach (Admin admin in adm.LeerListaCompleta())
            {
                if (usuario == admin.User)
                {
                    return true;
                }
            }
            foreach (Alumno alumno in alum.LeerListaCompleta())
            {
                if(usuario == alumno.User)
                {
                    return true;
                }
            }
            foreach (Profesor profesor in prof.LeerListaCompleta())
            {
                if (usuario == profesor.User)
                {
                    return true;
                }
            }
            return false;
        }


        /// <summary>
        /// Se le pasa un string y devuelve el mismo con solo la primer letra en mayuscula
        /// </summary>
        /// <param name="value"> string a modificar</param>
        /// <returns></returns>
        public static string HacerPrimerLetraMayus(string value)
        {
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(value);
        }


    }
}