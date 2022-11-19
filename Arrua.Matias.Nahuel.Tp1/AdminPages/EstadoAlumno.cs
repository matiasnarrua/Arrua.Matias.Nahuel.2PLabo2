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
        
        public frm_EstadoAlumno()
        {
            InitializeComponent();
            CargarCmb();

            dgv_EstadoAlumno.DataSource = Alumno_dao.LeerAlumnos();

        }
        
        private void btn_CambiarEstado_Click(object sender, EventArgs e)
        {
            foreach (MateriaCursada materia in MateriaCursada_dao.LeerMateriasCursadas())
            {
                if (materia.Usuario == txt_Usuario.Text && materia.Materia == cmb_Materias.Text)
                {
                    materia.EstadoDelAlumno = CambiarEstado(materia);
                }
            }                                    
            MessageBox.Show("Se cambio el estado del alumno");
            

            ///TODO 01 Cambiar y fusionar tablas para mostrar cambiar la lista que muestro en el dgv
            BindingSource bs = new BindingSource();
            bs.DataSource = Alumno_dao.LeerAlumnos();
            dgv_EstadoAlumno.DataSource = bs;

        }

        private void btn_CargarMaterias_Click(object sender, EventArgs e)
        {
            MateriaCursada materiaAux = new MateriaCursada("", "");
            cmb_Materias.Items.Clear();
            foreach (MateriaCursada materia in MateriaCursada_dao.LeerMateriasCursadas())
            {
                if (materia.Usuario == txt_Usuario.Text)
                {
                    materiaAux = materia;
                }
            }
            CargarCmb(materiaAux);
            MessageBox.Show("Materias del alumno cargadas");
        }

        private  void CargarCmb()
        {
            cmb_Estado.Items.Add("Libre");
            cmb_Estado.Items.Add("Regular");
            cmb_Estado.Items.Add("Sin Estado");
        }
        private void CargarCmb(MateriaCursada materiaCursada)
        {
            List<MateriaCursada> listAux = new List<MateriaCursada>();
            listAux = DevolverMateriasCursadas(materiaCursada);

            foreach (MateriaCursada materia in listAux)
            {
                if (materia.Usuario == materiaCursada.Usuario)
                {
                    cmb_Materias.Items.Add(materia.Materia);
                }
            }
        }
        
       
        private EstadoDelAlumno CambiarEstado(MateriaCursada materia)
        {
            
            if (cmb_Estado.Text == "regular")
            {
                materia.EstadoDelAlumno = EstadoDelAlumno.Regular;
            }
            else if (cmb_Estado.Text == "libre")
            {
                materia.EstadoDelAlumno = EstadoDelAlumno.Libre;
            }
            else if (cmb_Estado.Text == "sin estado")
            {
                materia.EstadoDelAlumno = EstadoDelAlumno.SinEstado;
            }

            return materia.EstadoDelAlumno;
        }

        /// <summary>
        /// Busca y devuelve una lista de las materias que cursa un alumno
        /// </summary>
        /// <param name="alumno">alumno del que quiero las materias que cursa</param>
        /// <returns></returns>       
        public static List<MateriaCursada> DevolverMateriasCursadas(MateriaCursada materiaCursada)
        {
            List<MateriaCursada> listAux = new List<MateriaCursada>();

            foreach (MateriaCursada materiaAux in MateriaCursada_dao.LeerMateriasCursadas())
            {
                if (materiaCursada.Usuario == materiaAux.Usuario)
                {
                    listAux.Add(materiaAux);
                }

            }
            return listAux;
        }
    }
}
