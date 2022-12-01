using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TiposDeUsuarios;

namespace Arrua.Matias.Nahuel.Tp1.AdminPages
{
    
    public partial class frm_AltaAlumno : Form
    {
        Alumno alumno = new Alumno("", "");
        Alumno_dao alum = new Alumno_dao();
        public frm_AltaAlumno()
        {
            InitializeComponent();            

            BindingSource bs = new BindingSource();
            bs.DataSource = alum.LeerListaCompleta();
            dgv_Usuarios.DataSource = bs;
        }

        private void btn_AceptarAltaAlumno_Click(object sender, EventArgs e)
        {            
            GuardarAlumno();
            BindingSource bs = new BindingSource();
            bs.DataSource = alum.LeerListaCompleta();
            dgv_Usuarios.DataSource = bs;
        }

        /// <summary>
        /// Busca el mismo usuario con BuscarMismoUser 
        /// si encuentra el mismo usuario muestra mensaje
        /// Si no lo encuentra agrega uno a la lista con AgregarUsuario
        /// </summary>
        private void GuardarAlumno()
        {
            if (Usuario.BuscarMismoUser(txt_UserAlumnoAlta.Text))
            {
                MessageBox.Show("El usuario/Mail ya existe");
            }
            else
            {

                Alumno_dao.CargarAlumno(new Alumno(txt_UserAlumnoAlta.Text, txt_PassAlumnoAlta.Text, txt_NombreAlumnoAlta.Text));
                

                MessageBox.Show($"El usuario {Usuario.HacerPrimerLetraMayus(txt_NombreAlumnoAlta.Text)} Fue dado de alta");
            }
        }

    }
}
