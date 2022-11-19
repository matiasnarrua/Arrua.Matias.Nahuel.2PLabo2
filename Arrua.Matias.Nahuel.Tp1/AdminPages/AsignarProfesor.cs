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
    public partial class frm_AsignarProfesor : Form
    {
        public frm_AsignarProfesor()
        {
            InitializeComponent();
            
        }

        private void frm_AsignarProfesor_Load(object sender, EventArgs e)
        {
            CargarCmbs();

        }
        private void btn_Asignar_Click(object sender, EventArgs e)
        {
            AsignarProfesor(cmb_Materias.Text, cmb_Profesores.Text);
            MessageBox.Show($"Se asigno {cmb_Materias.Text} a : {cmb_Profesores.Text}");
            cmb_Materias.Items.Clear();
            cmb_Profesores.Items.Clear();
            CargarCmbs();

        }

        /// <summary>
        /// Carga los combo box de Materias y el otro de Profesores, cuando estos no tengan ninguno asignado
        /// </summary>
        private void CargarCmbs()
        {
            List<Materia> listMaterias = Materia_dao.LeerMateria();
            List<Profesor> listProfesores = Profesor_dao.LeerProfesor();

            foreach (Materia materia in listMaterias)
            {
                
                    cmb_Materias.Items.Add(materia.Nombre);
                
            }
            foreach (Profesor profesor in listProfesores)
            {
               
                    cmb_Profesores.Items.Add(profesor.Nombre);
                
            }
        }

        private void AsignarProfesor(string materiaSelec, string profesorSelec)
        {
            foreach (Materia materia in Materia_dao.LeerMateria())
            {
                if(materia.Nombre == materiaSelec)
                {
                    foreach (Profesor profesor in Profesor_dao.LeerProfesor())
                    {
                        if(profesor.Nombre == profesorSelec)
                        {
                            materia.ProfesorUser = profesor.Nombre;
                            
                        }
                        
                    }
                    
                }
            }
        }
       
        
    }
}
