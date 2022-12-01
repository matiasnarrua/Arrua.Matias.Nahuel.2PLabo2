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

namespace Arrua.Matias.Nahuel.Tp1.AlumnoPages
{
    public partial class frm_AlumnoInicio : Form
    {
        public frm_AlumnoInicio()
        {
            InitializeComponent();
        }
        public frm_AlumnoInicio(Alumno alum) : this()
        {
            BindingSource bs = new BindingSource();
           
            bs.DataSource = alum.CargarDgvAlumno(alum);
            dgv_MateriasCursadas.DataSource = bs;
           
        }


       
    }
}
