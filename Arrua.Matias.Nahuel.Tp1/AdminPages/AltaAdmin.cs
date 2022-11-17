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
            BindingSource bs = new BindingSource();
            bs.DataSource = Datos.listaAdmins;
            dgv_Usuarios.DataSource = bs;
        }

        private void btn_AceptarAltaAdmin_Click(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            CargarAdmin();
            bs.DataSource = Datos.listaAdmins;
            dgv_Usuarios.DataSource = bs;

        }
        /// <summary>
        /// Busca el mismo usuario con BuscarMismoUser 
        /// si encuentra el mismo usuario muestra mensaje
        /// Si no lo encuentra agrega uno a la lista con AgregarUsuario
        /// </summary>
        private void CargarAdmin()
        {
            if (Datos.BuscarMismoUser(txt_UserAdminAlta.Text, Datos.listaAdmins))
            {
                MessageBox.Show("El usuario/Mail ya existe");
            }
            else
            {
                admin.AgregarUsuario(txt_UserAdminAlta.Text, txt_PassAdminAlta.Text, txt_NombreAdminAlta.Text);

                MessageBox.Show($"El usuario {Datos.HacerPrimerLetraMayus(txt_NombreAdminAlta.Text)} Fue dado de alta");
            }
        }

      
        

        
    }
}   
