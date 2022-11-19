namespace TiposDeUsuarios
{
    public class Usuario
    {
        private string _user;
        private string _pass;

        public Usuario(string user, string pass)
        {
            this._user = user;
            this._pass = pass;
        }

        public string User { get => _user; set => _user = value; }
        public string Pass { get => _pass; set => _pass = value; }

       public static bool BuscarMismoUser(string usuario)
        {
            foreach (Admin admin in Admin_dao.LeerAdmins())
            {
                if (usuario == admin.User)
                {
                    return true;
                }
            }
            foreach (Alumno alumno in Alumno_dao.LeerAlumnos())
            {
                if(usuario == alumno.User)
                {
                    return true;
                }
            }
            foreach (Profesor profesor in Profesor_dao.LeerProfesor())
            {
                if (usuario == profesor.User)
                {
                    return true;
                }
            }
            return false;
        }
        
    }
}