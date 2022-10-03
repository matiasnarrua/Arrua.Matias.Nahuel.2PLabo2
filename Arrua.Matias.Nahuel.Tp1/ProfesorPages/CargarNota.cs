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

namespace Arrua.Matias.Nahuel.Tp1.ProfesorPages
{
    public partial class frm_CargarNota : Form
    {
        Profesor profesor = new Profesor("", "");
        public frm_CargarNota()
        {
            InitializeComponent();
          

        }
        public frm_CargarNota(Profesor profesor) : this()
        {
            this.profesor = profesor;
            CargarCmbNotas();
            CargarCmbExamenes();
            BindingSource bs = new BindingSource();
            bs.DataSource = DevolverAlumnosDeLaMateria(profesor);
            dgv_Alumnos.DataSource = bs;
        }




        private void btn_CargarNota_Click(object sender, EventArgs e)
        {
            CargarNota();
            BindingSource bs = new BindingSource();
            bs.DataSource = DevolverAlumnosDeLaMateria(profesor);
            dgv_Alumnos.DataSource = bs;

        }



        public static List<Alumno> DevolverAlumnosDeLaMateria(Profesor profesor)
        {
            List<Alumno> listAux = new List<Alumno>();

            foreach (Alumno alumno in Datos.listaAlumnos)
            {
                if (alumno.MateriaCursada == profesor.MateriaAsignada)
                {
                    listAux.Add(alumno);
                }
            }
            return listAux;
        }

        public void CargarCmbNotas()
        {
            for (int i = 1; i <= 10; i++)
            {
                cmb_Nota.Items.Add(i);
            }
            
        }
       public void CargarCmbExamenes()
        {
            List<Examen> listaExamenes = Datos.TraerExamenDeSuMateria(profesor);
            
            foreach (Examen examen in listaExamenes)
            {
                cmb_Examen.Items.Add(examen.Nombre);
            }
            
        }
        public void CargarNota( )
        {
            int i= 0;
            Alumno alumnoAux = new Alumno("", "");
            foreach (Alumno alumno in Datos.listaAlumnos)
            {
                if (txt_Usuario.Text == alumno.User && alumno.MateriaCursada == profesor.MateriaAsignada)
                {

                    if (alumno.ExamenNota == 0 && alumno.ExamenNombre == "")
                    {
                        alumno.ExamenNota = (int)cmb_Nota.SelectedItem;
                        alumno.ExamenNombre = cmb_Examen.Text;

                        MessageBox.Show("Nota Asignada");
                        break;
                    }
                    else if (alumno.ExamenNombre != cmb_Examen.Text)
                    {
                        alumnoAux.Nombre = alumno.Nombre;
                        alumnoAux.User = alumno.User;
                        alumnoAux.Pass = alumno.Pass;
                        alumnoAux.MateriaCursada = alumno.MateriaCursada;
                        alumnoAux.EstadoDelAlumno = alumno.EstadoDelAlumno;
                        alumnoAux.ExamenNota = (int)cmb_Nota.SelectedItem;
                        alumnoAux.ExamenNombre = cmb_Examen.Text;
                        Datos.listaAlumnos.Add(alumnoAux);
                        MessageBox.Show("Nota Asignada");
                        break;
                    }
                    else
                    {
                        MessageBox.Show("La nota ya estaba asignada");
                        break;
                    }

                }
                else if(i != 1){
                    MessageBox.Show("Usuario incorrecto");
                    i = 1;
                }
                
            }
           
        }
    }





}
