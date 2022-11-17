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
    public partial class frm_EstadoAlumno : Form
    {
        Alumno alumno = new Alumno("", "");
        public frm_EstadoAlumno()
        {
            InitializeComponent();
            CargarCmb();

            dgv_EstadoAlumno.DataSource = Datos.listaAlumnos;

        }
        
        private void btn_CambiarEstado_Click(object sender, EventArgs e)
        {
            foreach (Alumno alumno in Datos.listaAlumnos)
            {
                if (alumno.User == txt_Usuario.Text && alumno.MateriaCursada == cmb_Materias.Text)
                {
                    alumno.EstadoDelAlumno = CambiarEstado(alumno);
                }
            }                                    
            MessageBox.Show("Se cambio el estado del alumno");
            
            BindingSource bs = new BindingSource();
            bs.DataSource = Datos.listaAlumnos;
            dgv_EstadoAlumno.DataSource = bs;

        }

        private void btn_CargarMaterias_Click(object sender, EventArgs e)
        {
            cmb_Materias.Items.Clear();
            foreach (Alumno alumno in Datos.listaAlumnos)
            {
                if (alumno.User == txt_Usuario.Text)
                {
                    this.alumno =alumno;
                }
            }
            CargarCmb(alumno);
            MessageBox.Show("Materias del alumno cargadas");
        }

        private  void CargarCmb()
        {
            cmb_Estado.Items.Add("Libre");
            cmb_Estado.Items.Add("Regular");
            cmb_Estado.Items.Add("Sin Estado");
        }
        private void CargarCmb(Alumno alumno)
        {
            List<Alumno> listAux = new List<Alumno>();
            listAux = Datos.DevolverMateriasCursadas(alumno);

            foreach (Alumno alumno1 in listAux)
            {
                if (alumno1.User == alumno.User)
                {
                    cmb_Materias.Items.Add(alumno1.MateriaCursada);
                }
            }
        }

        /// <summary>
        /// Cambia el estado del alumno que se pasa por parametro, comparadolo con el item seleccionado del combo box
        /// </summary>
        /// <param name="alumno">alumno a modificar</param>
        /// <returns></returns>
        private EstadoDelAlumno CambiarEstado(Alumno alumno)
        {
            if (cmb_Estado.Text == "Regular")
            {
                alumno.EstadoDelAlumno = EstadoDelAlumno.Regular;
            }
            else if (cmb_Estado.Text == "Libre")
            {
                alumno.EstadoDelAlumno = EstadoDelAlumno.Libre;
            }
            else if (cmb_Estado.Text == "Sin Estado")
            {
                alumno.EstadoDelAlumno = EstadoDelAlumno.SinEstado;
            }

            return alumno.EstadoDelAlumno;
        }
    }
}
