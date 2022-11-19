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
            bs.DataSource = Examen_dao.LeerExamenProfesor(profesor);
            dgv_Alumnos.DataSource = bs;
        }




        private void btn_CargarNota_Click(object sender, EventArgs e)
        {
            CargarNota();
            BindingSource bs = new BindingSource();
            bs.DataSource = Examen_dao.LeerExamenProfesor(profesor);
            dgv_Alumnos.DataSource = bs;

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
            List<Examen> listaExamenes = Examen_dao.LeerExamenProfesor(profesor);
            
            foreach (Examen examen in listaExamenes)
            {
                cmb_Examen.Items.Add(examen.Nombre);
            }
            
        }
        public void CargarNota( )
        {
            int i= 0;
            Alumno alumnoAux = new Alumno("", "");
            Examen examenAux = new Examen();
            foreach (Examen examen in Examen_dao.LeerExamen())
            {
                if (txt_Usuario.Text == examen.Alumno && examen.Profesor == profesor.User)
                {

                    if (examen.Nota == 0 && examen.Nombre == "")
                    {
                        examen.Nota = (int)cmb_Nota.SelectedItem;
                        examen.Nombre = cmb_Examen.Text;

                        MessageBox.Show("Nota Asignada");
                        break;
                    }
                    else if (examen.Nombre != cmb_Examen.Text)
                    {
                        examenAux.Nombre = cmb_Examen.Text;
                        examenAux.Fecha = examen.Fecha;
                        examenAux.Materia= examen.Materia;
                        examenAux.Profesor = examen.Profesor;
                        examenAux.Nota = (int)cmb_Nota.SelectedItem;
                        examenAux.Alumno = examen.Alumno;

                        //agregar examen al base
                        Examen_dao.CargarExamen(examenAux);
                       // Datos.listaAlumnos.Add(alumnoAux);
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
