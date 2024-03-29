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
    public partial class frm_CrearMateria : Form
    {
        Materia materia = new Materia();
        public frm_CrearMateria()
        {
            InitializeComponent();
            BindingSource bs = new BindingSource();
            bs.DataSource = Materia_dao.LeerMateria();
            dgv_Materias.DataSource = bs;

        }

        private void btn_AltaMateria_Click(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            CargarMateria();
            bs.DataSource = Materia_dao.LeerMateria();
            dgv_Materias.DataSource = bs;

        }
        private void CargarMateria()
        {
            Materia_dao.CrearMateria(new Materia(txt_NombreMateria.Text, txt_Correlativa.Text));            

                MessageBox.Show($"La materia: {Usuario.HacerPrimerLetraMayus(txt_NombreMateria.Text)} Fue agregada");
            
        }

       
    }
}
