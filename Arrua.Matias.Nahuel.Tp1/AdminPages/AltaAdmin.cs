using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TiposDeUsuarios;

namespace Arrua.Matias.Nahuel.Tp1.AdminPages
{
    public partial class frm_AltaAdmin : Form
    {
        Admin admin = new Admin("", "");
        
        public frm_AltaAdmin()
        {
            InitializeComponent();
            
            RefrescarDGV(dgv_Usuarios);

        }

        private void btn_AceptarAltaAdmin_Click(object sender, EventArgs e)
        {
            CargarAdmin();
            RefrescarDGV(dgv_Usuarios);

        }


        /// <summary>
        /// Busca el mismo usuario con BuscarMismoUser 
        /// si encuentra el mismo usuario muestra mensaje
        /// Si no lo encuentra agrega uno a la base de datos con CargarAdmin
        /// </summary>
        private void CargarAdmin()
        {
            
            List<Admin> listaAdmins = new List<Admin>();
            listaAdmins = Admin_dao.LeerAdmins();

            if (Usuario.BuscarMismoUser(txt_UserAdminAlta.Text))
            {
                MessageBox.Show("El usuario/Mail ya existe");
            }
            else
            {                
                admin.User = txt_UserAdminAlta.Text;
                admin.Pass= txt_PassAdminAlta.Text;
                admin.Nombre = Datos.HacerPrimerLetraMayus(txt_NombreAdminAlta.Text);
                Admin_dao.CargarAdmin(admin);

                MessageBox.Show($"El usuario {Datos.HacerPrimerLetraMayus(txt_NombreAdminAlta.Text)} Fue dado de alta");
            }
        }


        private void RefrescarDGV(DataGridView dgv_Usuarios)
        {
            dgv_Usuarios.DataSource = Admin_dao.LeerAdmins();
            dgv_Usuarios.Update();
            dgv_Usuarios.Refresh();
        }


    }
}   
