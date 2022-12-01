namespace Arrua.Matias.Nahuel.Tp1.ProfesorPages
{
    partial class frm_CargarNota
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.btn_CargarNota = new System.Windows.Forms.Button();
            this.lbl_Examen = new System.Windows.Forms.Label();
            this.lbl_Examen2 = new System.Windows.Forms.Label();
            this.dgv_Alumnos = new System.Windows.Forms.DataGridView();
            this.examenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alumnoBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.alumnoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txt_Usuario = new System.Windows.Forms.TextBox();
            this.lbl_UserrAlumno = new System.Windows.Forms.Label();
            this.alumnoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cmb_Examen = new System.Windows.Forms.ComboBox();
            this.cmb_Nota = new System.Windows.Forms.ComboBox();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alumnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Alumnos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.examenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnoBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnoBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Title.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Title.Location = new System.Drawing.Point(170, 9);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(192, 37);
            this.lbl_Title.TabIndex = 2;
            this.lbl_Title.Text = "Cargar notas";
            // 
            // btn_CargarNota
            // 
            this.btn_CargarNota.Location = new System.Drawing.Point(384, 346);
            this.btn_CargarNota.Name = "btn_CargarNota";
            this.btn_CargarNota.Size = new System.Drawing.Size(100, 23);
            this.btn_CargarNota.TabIndex = 4;
            this.btn_CargarNota.Text = "Cargar Nota";
            this.btn_CargarNota.UseVisualStyleBackColor = true;
            this.btn_CargarNota.Click += new System.EventHandler(this.btn_CargarNota_Click);
            // 
            // lbl_Examen
            // 
            this.lbl_Examen.AutoSize = true;
            this.lbl_Examen.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Examen.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_Examen.Location = new System.Drawing.Point(250, 295);
            this.lbl_Examen.Name = "lbl_Examen";
            this.lbl_Examen.Size = new System.Drawing.Size(61, 20);
            this.lbl_Examen.TabIndex = 7;
            this.lbl_Examen.Text = "Examen";
            // 
            // lbl_Examen2
            // 
            this.lbl_Examen2.AutoSize = true;
            this.lbl_Examen2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Examen2.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_Examen2.Location = new System.Drawing.Point(388, 295);
            this.lbl_Examen2.Name = "lbl_Examen2";
            this.lbl_Examen2.Size = new System.Drawing.Size(86, 20);
            this.lbl_Examen2.TabIndex = 8;
            this.lbl_Examen2.Text = "Calificacion";
            // 
            // dgv_Alumnos
            // 
            this.dgv_Alumnos.AllowUserToAddRows = false;
            this.dgv_Alumnos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.dgv_Alumnos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Alumnos.AutoGenerateColumns = false;
            this.dgv_Alumnos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.dgv_Alumnos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Alumnos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Alumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Alumnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreDataGridViewTextBoxColumn,
            this.alumnoDataGridViewTextBoxColumn,
            this.materiaDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.notaDataGridViewTextBoxColumn});
            this.dgv_Alumnos.DataSource = this.examenBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Alumnos.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Alumnos.GridColor = System.Drawing.SystemColors.Window;
            this.dgv_Alumnos.Location = new System.Drawing.Point(12, 65);
            this.dgv_Alumnos.Name = "dgv_Alumnos";
            this.dgv_Alumnos.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Alumnos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_Alumnos.RowTemplate.Height = 25;
            this.dgv_Alumnos.Size = new System.Drawing.Size(508, 213);
            this.dgv_Alumnos.TabIndex = 9;
            // 
            // examenBindingSource
            // 
            this.examenBindingSource.DataSource = typeof(TiposDeUsuarios.Examen);
            // 
            // alumnoBindingSource2
            // 
            this.alumnoBindingSource2.DataSource = typeof(TiposDeUsuarios.Alumno);
            // 
            // alumnoBindingSource
            // 
            this.alumnoBindingSource.DataSource = typeof(TiposDeUsuarios.Alumno);
            // 
            // txt_Usuario
            // 
            this.txt_Usuario.Location = new System.Drawing.Point(27, 318);
            this.txt_Usuario.Name = "txt_Usuario";
            this.txt_Usuario.Size = new System.Drawing.Size(164, 23);
            this.txt_Usuario.TabIndex = 10;
            // 
            // lbl_UserrAlumno
            // 
            this.lbl_UserrAlumno.AutoSize = true;
            this.lbl_UserrAlumno.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_UserrAlumno.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_UserrAlumno.Location = new System.Drawing.Point(27, 295);
            this.lbl_UserrAlumno.Name = "lbl_UserrAlumno";
            this.lbl_UserrAlumno.Size = new System.Drawing.Size(140, 20);
            this.lbl_UserrAlumno.TabIndex = 11;
            this.lbl_UserrAlumno.Text = "Usuario del Alumno";
            // 
            // alumnoBindingSource1
            // 
            this.alumnoBindingSource1.DataSource = typeof(TiposDeUsuarios.Alumno);
            // 
            // cmb_Examen
            // 
            this.cmb_Examen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Examen.FormattingEnabled = true;
            this.cmb_Examen.Location = new System.Drawing.Point(220, 318);
            this.cmb_Examen.Name = "cmb_Examen";
            this.cmb_Examen.Size = new System.Drawing.Size(128, 23);
            this.cmb_Examen.TabIndex = 12;
            // 
            // cmb_Nota
            // 
            this.cmb_Nota.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Nota.FormattingEnabled = true;
            this.cmb_Nota.Location = new System.Drawing.Point(374, 318);
            this.cmb_Nota.Name = "cmb_Nota";
            this.cmb_Nota.Size = new System.Drawing.Size(121, 23);
            this.cmb_Nota.TabIndex = 13;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // alumnoDataGridViewTextBoxColumn
            // 
            this.alumnoDataGridViewTextBoxColumn.DataPropertyName = "Alumno";
            this.alumnoDataGridViewTextBoxColumn.HeaderText = "Alumno";
            this.alumnoDataGridViewTextBoxColumn.Name = "alumnoDataGridViewTextBoxColumn";
            this.alumnoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // materiaDataGridViewTextBoxColumn
            // 
            this.materiaDataGridViewTextBoxColumn.DataPropertyName = "Materia";
            this.materiaDataGridViewTextBoxColumn.HeaderText = "Materia";
            this.materiaDataGridViewTextBoxColumn.Name = "materiaDataGridViewTextBoxColumn";
            this.materiaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            this.fechaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // notaDataGridViewTextBoxColumn
            // 
            this.notaDataGridViewTextBoxColumn.DataPropertyName = "Nota";
            this.notaDataGridViewTextBoxColumn.HeaderText = "Nota";
            this.notaDataGridViewTextBoxColumn.Name = "notaDataGridViewTextBoxColumn";
            this.notaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frm_CargarNota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.ClientSize = new System.Drawing.Size(532, 412);
            this.Controls.Add(this.cmb_Nota);
            this.Controls.Add(this.cmb_Examen);
            this.Controls.Add(this.lbl_UserrAlumno);
            this.Controls.Add(this.txt_Usuario);
            this.Controls.Add(this.dgv_Alumnos);
            this.Controls.Add(this.lbl_Examen2);
            this.Controls.Add(this.lbl_Examen);
            this.Controls.Add(this.btn_CargarNota);
            this.Controls.Add(this.lbl_Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_CargarNota";
            this.Text = "UTN App";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Alumnos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.examenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnoBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnoBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_Title;
        private Button btn_CargarNota;
        private Label lbl_Examen;
        private Label lbl_Examen2;
        private DataGridView dgv_Alumnos;
        private BindingSource alumnoBindingSource;
        private TextBox txt_Usuario;
        private Label lbl_UserrAlumno;
        private BindingSource alumnoBindingSource1;
        
        private BindingSource alumnoBindingSource2;
        private ComboBox cmb_Examen;
        private ComboBox cmb_Nota;
        private DataGridViewTextBoxColumn materiaCursadaDataGridViewTextBoxColumn;
        private BindingSource examenBindingSource;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn alumnoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn materiaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn notaDataGridViewTextBoxColumn;
    }
}