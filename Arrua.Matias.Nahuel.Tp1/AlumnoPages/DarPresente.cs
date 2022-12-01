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
    public partial class frm_DarPresente : Form
    {
        Alumno alumno = new Alumno("", "");
        public frm_DarPresente()
        {
            InitializeComponent();
        }
        public frm_DarPresente(Alumno alumno) : this()
        {
            this.alumno = alumno;
            CargarCmb(this.alumno);

        }

        private void btn_DarPresente_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Presente en {cmb_MateriasPresente.Text}");
            StringBuilder sb = new StringBuilder();
            sb.Append(cmb_MateriasPresente.Text);
            sb.Append(alumno.Nombre);
            sb.Append(alumno.User);
            
        }

        private void CargarCmb(Alumno alumno)
        {
            List<MateriaCursada> listAux = MateriaCursada_dao.LeerMateriasCursadas(alumno);
          
            foreach (MateriaCursada materia in listAux)
            {            
             cmb_MateriasPresente.Items.Add(materia.Materia);  
                
            }
        }
    }
}
