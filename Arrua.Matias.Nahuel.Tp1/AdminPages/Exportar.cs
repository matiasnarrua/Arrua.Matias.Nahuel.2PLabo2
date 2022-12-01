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

namespace Arrua.Matias.Nahuel.Tp2.AdminPages
{
    public partial class frm_Exportar : Form
    {
        public frm_Exportar()
        {
            InitializeComponent();
                        
            foreach (Materia materia in Materia_dao.LeerMateria())
            {
                cmb_Materias.Items.Add(materia.Nombre);
            }

        }

        private void btn_ExportarCsv_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            foreach (MateriaCursada materia in MateriaCursada_dao.LeerAlumnosDeMateria(cmb_Materias.Text))
            {
              sb.AppendLine($"{materia.Usuario}, {materia.EstadoDelAlumno}, {materia.EstadoMateria}");
                
            }
            
            Clase_Serializadora<string>.EscribirCsv(sb.ToString(), cmb_Materias.Text);
            MessageBox.Show($"Alumnos de la materia {cmb_Materias.Text} exportados en Csv");
        }

        private void btn_ExportarJSON_Click(object sender, EventArgs e)
        {
            List<MateriaCursada> materias = MateriaCursada_dao.LeerAlumnosDeMateria(cmb_Materias.Text);

            Clase_Serializadora<List<MateriaCursada>>.EscribirJson(materias, cmb_Materias.Text);
            MessageBox.Show($"Alumnos de la materia {cmb_Materias.Text} exportados en Json");
        }

        private void btn_Importar_Click(object sender, EventArgs e)
        {           
            List<Alumno> alumnos = Clase_Serializadora<List<Alumno>>.LeerJson("Alumnos");           
                        
            foreach (Alumno alumno in alumnos)
            {
                Alumno_dao.CargarAlumno(alumno);
            }
            MessageBox.Show("Alumnos Importados");
        }
    }
}
    