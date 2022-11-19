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
            
            bs.DataSource = Examen_dao.LeerExamenProfesor(profesor);
            dgv_Examenes.DataSource = bs;
           
        }


        

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            Examen examen = new Examen();
            examen.Nombre = txt_Nombre.Text;
            examen.Fecha = dtp_fecha.Value;
            ///TODO 03 Crear boton para cargar materia que elija el profesor, de las que tiene asignadas
           // examen.Materia = ;
            examen.Profesor = profesor1.User ;
                Examen_dao.CargarExamen(examen);
            
            BindingSource bs = new BindingSource();

            bs.DataSource = Examen_dao.LeerExamenProfesor(profesor1);
            dgv_Examenes.DataSource = bs;



        }



    }




}
