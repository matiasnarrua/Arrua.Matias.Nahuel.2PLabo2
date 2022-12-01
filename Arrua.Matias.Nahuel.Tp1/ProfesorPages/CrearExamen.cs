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
    public partial class frm_CrearExamen : Form
    {
        public Profesor profesor1 = new Profesor("", "");
        public frm_CrearExamen()
        {
            InitializeComponent();
        }
        public frm_CrearExamen(Profesor profesor) : this()
        {
            this.profesor1 = profesor;
            
            BindingSource bs = new BindingSource();
            
            bs.DataSource = ExamenAlumno_dao.LeerExamenProfesor(profesor);
            dgv_Examenes.DataSource = bs;
           
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {            
            Examen nuevoExamen = new Examen();
            nuevoExamen.Nombre = txt_Nombre.Text;
            nuevoExamen.Fecha = dtp_fecha.Value;            
            nuevoExamen.Materia = Materia_dao.LeerMateriaProfesor(profesor1);
            nuevoExamen.Profesor = profesor1.User ;
                                    
            ExamenAlumno_dao.CargarNuevoExamen(nuevoExamen);
            
            foreach (MateriaCursada materia in MateriaCursada_dao.LeerMateriasCursadas())
            {
                if (materia.Materia == nuevoExamen.Materia)
                {
                    nuevoExamen.Alumno = materia.Usuario;
                    ExamenAlumno_dao.AsignarNuevoExamen(nuevoExamen);
                }                
            }
           
            BindingSource bs = new BindingSource();
            bs.DataSource = ExamenAlumno_dao.LeerExamenProfesor(profesor1);
            dgv_Examenes.DataSource = bs;
       }
    }


}
