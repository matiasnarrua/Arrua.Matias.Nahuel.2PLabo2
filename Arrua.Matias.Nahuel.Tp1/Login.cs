using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using TiposDeUsuarios;


namespace Arrua.Matias.Nahuel.Tp1
{
    
    public partial class frm_Login : Form
    {             
        public frm_Login()
        {              
        InitializeComponent();
            
        }           
        private void Login_Load(object sender, EventArgs e)
        {

        }

        #region Mover ventana
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wrsg, int wparam, int lparam);


        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #endregion


        #region Buttons
        private void btn_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }
               
        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            List<Usuario> list = new List<Usuario>();

            list.AddRange(Alumno_dao.LeerAlumnos());
            list.AddRange(Admin_dao.LeerAdmins());
            list.AddRange(Profesor_dao.LeerProfesor());           

            LoginUsuario(list);                      
                    
        }

        #endregion

        #region CargarUsuarios TextBox
        private void btn_PreAdmin_Click(object sender, EventArgs e)
        {                   
             txt_Usuario.Text = "admin@utn.com";
            txt_Pass.Text = "admin";                      
            
        }

        private void btn_PreAlumno_Click(object sender, EventArgs e)
        {
            txt_Usuario.Text = "alumno1@utn.com";
            txt_Pass.Text = "alumno1";
          
         }

        private void btn_PreProfesor_Click(object sender, EventArgs e)
        {
            txt_Usuario.Text = "profesor@utn.com";
            txt_Pass.Text = "profesor";
          
        }
        #endregion

        public void MensajeDeErrorContaseña()
        {
            if ((txt_Usuario.Text == "") && (txt_Pass.Text == ""))
            {
                MessageBox.Show("Ingrese Usuario y Contraseña");

            }
            else if (txt_Usuario.Text == "")
            {
                MessageBox.Show("Ingrese Usuario");

            }
            else if (txt_Pass.Text == "")
            {
                MessageBox.Show("Ingrese Contraseña");
            }
            else 
            { 
                MessageBox.Show("Usuario y/o Contraseña incorrecto");
            }
            
        }
        public void LoginUsuario(List<Usuario> list) 
        {
            int i = 0;
            foreach (Usuario usuario in list)
            {
                ///TODO 07 Borrar estos 3? 
                Admin admin = new Admin("", "");
                Alumno alumno = new Alumno("", "");
                Profesor profesor = new Profesor("", "");

                if ((usuario.User == txt_Usuario.Text) && (usuario.Pass == txt_Pass.Text) && (usuario.GetType().ToString() == admin.GetType().ToString()))
                {
                    this.Hide();
                    frm_Admin frm_admin = new frm_Admin();
                    frm_admin.Show();
                    i = 1;
                    break;
                }
                else if ((usuario.User == txt_Usuario.Text) && (usuario.Pass == txt_Pass.Text) && (usuario.GetType().ToString() == alumno.GetType().ToString()))
                {
                    alumno = Alumno_dao.DevolverAlumno(usuario.User, usuario.Pass);
                    this.Hide();
                    frm_Alumno frm_alumno = new frm_Alumno(alumno);
                    frm_alumno.Show();
                    i = 1;
                    break;
                }
                else if ((usuario.User == txt_Usuario.Text) && (usuario.Pass == txt_Pass.Text) && (usuario.GetType().ToString() == profesor.GetType().ToString()))
                {
                    profesor = Profesor_dao.DevolverProfesor(usuario.User,usuario.Pass);
                    this.Hide();
                    frm_Profesor frm_profesor = new frm_Profesor(profesor);
                    frm_profesor.Show();
                    i = 1;
                    break;
                }       

            }
            if (i == 0)
            {
                    MensajeDeErrorContaseña();
            }
        }
        
    }
}