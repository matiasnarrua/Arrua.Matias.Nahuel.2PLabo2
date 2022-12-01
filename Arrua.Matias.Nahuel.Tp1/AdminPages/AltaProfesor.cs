﻿using System;
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
    public partial class frm_AltaProfesor : Form
    {
        Profesor_dao prof = new Profesor_dao();
        public frm_AltaProfesor()
        {
            InitializeComponent();
            BindingSource bs = new BindingSource();
            bs.DataSource = prof.LeerListaCompleta();
            dgv_Usuarios.DataSource = bs;
        }

        private void btn_AceptarAltaProfesor_Click(object sender, EventArgs e)
        {
            GuardarProfesor();
            BindingSource bs = new BindingSource();
            bs.DataSource = prof.LeerListaCompleta();
            dgv_Usuarios.DataSource = bs;
        }

        /// <summary>
        /// Busca el mismo usuario con BuscarMismoUser 
        /// si encuentra el mismo usuario muestra mensaje
        /// Si no lo encuentra agrega uno a la lista con AgregarUsuario
        /// </summary>
        private void GuardarProfesor()
        {
            if (Usuario.BuscarMismoUser(txt_UserProfesorAlta.Text))
            {
                MessageBox.Show("El usuario/Mail ya existe");
            }
            else
            {
                Profesor_dao.CargarProfesor(new Profesor (txt_UserProfesorAlta.Text, txt_PassProfesorAlta.Text, txt_NombreProfesorAlta.Text));

                MessageBox.Show($"El usuario {Usuario.HacerPrimerLetraMayus(txt_NombreProfesorAlta.Text)} Fue dado de alta");
            }
        }
    }
}
