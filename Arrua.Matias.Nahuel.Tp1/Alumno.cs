﻿using Arrua.Matias.Nahuel.Tp1.AdminPages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Arrua.Matias.Nahuel.Tp1.AlumnoPages;
using TiposDeUsuarios;
using System.Globalization;

namespace Arrua.Matias.Nahuel.Tp1
{
    public partial class frm_Alumno : Form
    {
        Alumno alumno = new Alumno("", "");
        public frm_Alumno()
        {            
            InitializeComponent();
        }
        public frm_Alumno(Alumno alum) : this()
        {
            this.alumno = alum;            
            lbl_Nombre.Text = alum.Nombre;
            lbl_User.Text = alum.User;
                                   
            dgv_MateriasCursadas.DataSource = Datos.DevolverMateriasCursadas(alum);


        }

            
        #region Mover ventana
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wrsg, int wparam, int lparam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        
        private void AbrirFormHijo(Form formHijo)
        {
            if (this.pnl_Contenedor.Controls.Count > 0)
            {
                this.pnl_Contenedor.Controls.RemoveAt(0);
            }
            Form fh = formHijo;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.pnl_Contenedor.Controls.Add(fh);
            this.pnl_Contenedor.Tag = fh;
            fh.Show();

        }

        private void btn_MinimizeAlumno_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_CloseAlumno_Click(object sender, EventArgs e)
        {
            
            Application.Exit();
        }

        private void btn_CerrarUserAlumno_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_Login log = new frm_Login();
            log.ShowDialog();
        }
        private void btn_Inscripcion_Click(object sender, EventArgs e)
        {
            ///TODO -5 Sacar lo comentado
            //if (Datos.VerificarCantidadMaterias(Datos.DevolverMateriasCursadas(this.alumno))){

            AbrirFormHijo(new frm_InscripcionMaterias(this.alumno));
            //}
            //else
            //{
            //    MessageBox.Show("Solo podes estar inscripto a dos materias");
            //}
        }

        private void btn_DarPresente_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new frm_DarPresente(this.alumno));
        }


        private void btn_inicioAlumno_Click(object sender, EventArgs e)
        {

            AbrirFormHijo(new frm_AlumnoInicio(this.alumno));

        }
    }
}
