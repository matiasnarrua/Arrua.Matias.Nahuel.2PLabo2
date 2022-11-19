namespace Arrua.Matias.Nahuel.Tp1.AlumnoPages
{
    partial class frm_AlumnoInicio
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
            this.dgv_MateriasCursadas = new System.Windows.Forms.DataGridView();
            this.alumnoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ExamenNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExamenNota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoMateria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MateriasCursadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_MateriasCursadas
            // 
            this.dgv_MateriasCursadas.AllowUserToAddRows = false;
            this.dgv_MateriasCursadas.AllowUserToDeleteRows = false;
            this.dgv_MateriasCursadas.AutoGenerateColumns = false;
            this.dgv_MateriasCursadas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.dgv_MateriasCursadas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_MateriasCursadas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_MateriasCursadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_MateriasCursadas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ExamenNombre,
            this.ExamenNota,
            this.EstadoMateria,
            this.nombreDataGridViewTextBoxColumn});
            this.dgv_MateriasCursadas.DataSource = this.alumnoBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_MateriasCursadas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_MateriasCursadas.Location = new System.Drawing.Point(22, 34);
            this.dgv_MateriasCursadas.Name = "dgv_MateriasCursadas";
            this.dgv_MateriasCursadas.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_MateriasCursadas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dgv_MateriasCursadas.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_MateriasCursadas.RowTemplate.Height = 25;
            this.dgv_MateriasCursadas.Size = new System.Drawing.Size(488, 342);
            this.dgv_MateriasCursadas.TabIndex = 0;
            // 
            // alumnoBindingSource
            // 
            this.alumnoBindingSource.DataSource = typeof(TiposDeUsuarios.Alumno);
            // 
            // ExamenNombre
            // 
            this.ExamenNombre.DataPropertyName = "ExamenNombre";
            this.ExamenNombre.HeaderText = "Examen";
            this.ExamenNombre.Name = "ExamenNombre";
            this.ExamenNombre.ReadOnly = true;
            // 
            // ExamenNota
            // 
            this.ExamenNota.DataPropertyName = "ExamenNota";
            this.ExamenNota.HeaderText = "Calificacion";
            this.ExamenNota.Name = "ExamenNota";
            this.ExamenNota.ReadOnly = true;
            // 
            // EstadoMateria
            // 
            this.EstadoMateria.DataPropertyName = "EstadoMateria";
            this.EstadoMateria.HeaderText = "EstadoMateria";
            this.EstadoMateria.Name = "EstadoMateria";
            this.EstadoMateria.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frm_AlumnoInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.ClientSize = new System.Drawing.Size(532, 412);
            this.Controls.Add(this.dgv_MateriasCursadas);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_AlumnoInicio";
            this.Text = "AlumnoInicio";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MateriasCursadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgv_MateriasCursadas;
        private BindingSource alumnoBindingSource;
        private DataGridViewTextBoxColumn materiaCursadaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn estadoDelAlumnoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ExamenNombre;
        private DataGridViewTextBoxColumn ExamenNota;
        private DataGridViewTextBoxColumn EstadoMateria;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
    }
}