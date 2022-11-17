namespace Arrua.Matias.Nahuel.Tp1
{
    partial class frm_Alumno
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Alumno));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_CerrarUserAlumno = new System.Windows.Forms.Button();
            this.btn_MinimizeAlumno = new System.Windows.Forms.PictureBox();
            this.btn_CloseAlumno = new System.Windows.Forms.PictureBox();
            this.btn_Minimize = new System.Windows.Forms.PictureBox();
            this.btn_Close = new System.Windows.Forms.PictureBox();
            this.pnl_Contenedor = new System.Windows.Forms.Panel();
            this.dgv_MateriasCursadas = new System.Windows.Forms.DataGridView();
            this.materiaCursadaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExamenNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExamenNota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoMateria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoDelAlumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alumnoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_inicioAlumno = new System.Windows.Forms.Button();
            this.btn_DarPresente = new System.Windows.Forms.Button();
            this.btn_Inscripcion = new System.Windows.Forms.Button();
            this.lbl_User = new System.Windows.Forms.Label();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.lbl_Alumno = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_MinimizeAlumno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_CloseAlumno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Close)).BeginInit();
            this.pnl_Contenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MateriasCursadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnoBindingSource)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.panel1.Controls.Add(this.btn_CerrarUserAlumno);
            this.panel1.Controls.Add(this.btn_MinimizeAlumno);
            this.panel1.Controls.Add(this.btn_CloseAlumno);
            this.panel1.Controls.Add(this.btn_Minimize);
            this.panel1.Controls.Add(this.btn_Close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(710, 40);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // btn_CerrarUserAlumno
            // 
            this.btn_CerrarUserAlumno.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.btn_CerrarUserAlumno.FlatAppearance.BorderSize = 0;
            this.btn_CerrarUserAlumno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CerrarUserAlumno.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_CerrarUserAlumno.Location = new System.Drawing.Point(8, 5);
            this.btn_CerrarUserAlumno.Name = "btn_CerrarUserAlumno";
            this.btn_CerrarUserAlumno.Size = new System.Drawing.Size(142, 23);
            this.btn_CerrarUserAlumno.TabIndex = 8;
            this.btn_CerrarUserAlumno.Text = "Cerrar Sesion";
            this.btn_CerrarUserAlumno.UseVisualStyleBackColor = true;
            this.btn_CerrarUserAlumno.Click += new System.EventHandler(this.btn_CerrarUserAlumno_Click);
            // 
            // btn_MinimizeAlumno
            // 
            this.btn_MinimizeAlumno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_MinimizeAlumno.Image = global::Arrua.Matias.Nahuel.Tp2.Properties.Resources.Minimize_Icon;
            this.btn_MinimizeAlumno.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_MinimizeAlumno.Location = new System.Drawing.Point(648, 12);
            this.btn_MinimizeAlumno.Name = "btn_MinimizeAlumno";
            this.btn_MinimizeAlumno.Size = new System.Drawing.Size(16, 16);
            this.btn_MinimizeAlumno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btn_MinimizeAlumno.TabIndex = 7;
            this.btn_MinimizeAlumno.TabStop = false;
            this.btn_MinimizeAlumno.Click += new System.EventHandler(this.btn_MinimizeAlumno_Click);
            // 
            // btn_CloseAlumno
            // 
            this.btn_CloseAlumno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_CloseAlumno.Image = global::Arrua.Matias.Nahuel.Tp2.Properties.Resources.Close_Icon;
            this.btn_CloseAlumno.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_CloseAlumno.Location = new System.Drawing.Point(682, 12);
            this.btn_CloseAlumno.Name = "btn_CloseAlumno";
            this.btn_CloseAlumno.Size = new System.Drawing.Size(16, 16);
            this.btn_CloseAlumno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btn_CloseAlumno.TabIndex = 6;
            this.btn_CloseAlumno.TabStop = false;
            this.btn_CloseAlumno.Click += new System.EventHandler(this.btn_CloseAlumno_Click);
            // 
            // btn_Minimize
            // 
            this.btn_Minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Minimize.Image = global::Arrua.Matias.Nahuel.Tp2.Properties.Resources.Minimize_Icon;
            this.btn_Minimize.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Minimize.Location = new System.Drawing.Point(1158, 12);
            this.btn_Minimize.Name = "btn_Minimize";
            this.btn_Minimize.Size = new System.Drawing.Size(16, 16);
            this.btn_Minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btn_Minimize.TabIndex = 5;
            this.btn_Minimize.TabStop = false;
            // 
            // btn_Close
            // 
            this.btn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Close.Image = global::Arrua.Matias.Nahuel.Tp2.Properties.Resources.Close_Icon;
            this.btn_Close.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Close.Location = new System.Drawing.Point(1192, 12);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(16, 16);
            this.btn_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btn_Close.TabIndex = 4;
            this.btn_Close.TabStop = false;
            // 
            // pnl_Contenedor
            // 
            this.pnl_Contenedor.Controls.Add(this.dgv_MateriasCursadas);
            this.pnl_Contenedor.Location = new System.Drawing.Point(177, 40);
            this.pnl_Contenedor.Name = "pnl_Contenedor";
            this.pnl_Contenedor.Size = new System.Drawing.Size(533, 409);
            this.pnl_Contenedor.TabIndex = 2;
            // 
            // dgv_MateriasCursadas
            // 
            this.dgv_MateriasCursadas.AllowUserToAddRows = false;
            this.dgv_MateriasCursadas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.dgv_MateriasCursadas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_MateriasCursadas.AutoGenerateColumns = false;
            this.dgv_MateriasCursadas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.dgv_MateriasCursadas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_MateriasCursadas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_MateriasCursadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_MateriasCursadas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.materiaCursadaDataGridViewTextBoxColumn,
            this.ExamenNombre,
            this.ExamenNota,
            this.EstadoMateria,
            this.EstadoDelAlumno});
            this.dgv_MateriasCursadas.DataSource = this.alumnoBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_MateriasCursadas.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_MateriasCursadas.Location = new System.Drawing.Point(21, 34);
            this.dgv_MateriasCursadas.Name = "dgv_MateriasCursadas";
            this.dgv_MateriasCursadas.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_MateriasCursadas.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_MateriasCursadas.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_MateriasCursadas.RowTemplate.Height = 25;
            this.dgv_MateriasCursadas.Size = new System.Drawing.Size(488, 342);
            this.dgv_MateriasCursadas.TabIndex = 0;
            // 
            // materiaCursadaDataGridViewTextBoxColumn
            // 
            this.materiaCursadaDataGridViewTextBoxColumn.DataPropertyName = "MateriaCursada";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.materiaCursadaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.materiaCursadaDataGridViewTextBoxColumn.HeaderText = "Materia Cursada";
            this.materiaCursadaDataGridViewTextBoxColumn.Name = "materiaCursadaDataGridViewTextBoxColumn";
            this.materiaCursadaDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.EstadoMateria.HeaderText = "Estado Materia";
            this.EstadoMateria.Name = "EstadoMateria";
            this.EstadoMateria.ReadOnly = true;
            // 
            // EstadoDelAlumno
            // 
            this.EstadoDelAlumno.DataPropertyName = "EstadoDelAlumno";
            this.EstadoDelAlumno.HeaderText = "Estado";
            this.EstadoDelAlumno.Name = "EstadoDelAlumno";
            this.EstadoDelAlumno.ReadOnly = true;
            // 
            // alumnoBindingSource
            // 
            this.alumnoBindingSource.DataSource = typeof(TiposDeUsuarios.Alumno);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.panel3.Controls.Add(this.btn_inicioAlumno);
            this.panel3.Controls.Add(this.btn_DarPresente);
            this.panel3.Controls.Add(this.btn_Inscripcion);
            this.panel3.Controls.Add(this.lbl_User);
            this.panel3.Controls.Add(this.lbl_Nombre);
            this.panel3.Controls.Add(this.lbl_Alumno);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Location = new System.Drawing.Point(0, 40);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(178, 412);
            this.panel3.TabIndex = 3;
            // 
            // btn_inicioAlumno
            // 
            this.btn_inicioAlumno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.btn_inicioAlumno.FlatAppearance.BorderSize = 0;
            this.btn_inicioAlumno.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.btn_inicioAlumno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_inicioAlumno.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_inicioAlumno.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_inicioAlumno.Location = new System.Drawing.Point(8, 372);
            this.btn_inicioAlumno.Name = "btn_inicioAlumno";
            this.btn_inicioAlumno.Size = new System.Drawing.Size(163, 28);
            this.btn_inicioAlumno.TabIndex = 18;
            this.btn_inicioAlumno.Text = "Inicio";
            this.btn_inicioAlumno.UseVisualStyleBackColor = false;
            this.btn_inicioAlumno.Click += new System.EventHandler(this.btn_inicioAlumno_Click);
            // 
            // btn_DarPresente
            // 
            this.btn_DarPresente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.btn_DarPresente.FlatAppearance.BorderSize = 0;
            this.btn_DarPresente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.btn_DarPresente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DarPresente.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_DarPresente.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_DarPresente.Location = new System.Drawing.Point(8, 209);
            this.btn_DarPresente.Name = "btn_DarPresente";
            this.btn_DarPresente.Size = new System.Drawing.Size(163, 28);
            this.btn_DarPresente.TabIndex = 17;
            this.btn_DarPresente.Text = "Dar Presente";
            this.btn_DarPresente.UseVisualStyleBackColor = false;
            this.btn_DarPresente.Click += new System.EventHandler(this.btn_DarPresente_Click);
            // 
            // btn_Inscripcion
            // 
            this.btn_Inscripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.btn_Inscripcion.FlatAppearance.BorderSize = 0;
            this.btn_Inscripcion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.btn_Inscripcion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Inscripcion.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Inscripcion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Inscripcion.Location = new System.Drawing.Point(8, 148);
            this.btn_Inscripcion.Name = "btn_Inscripcion";
            this.btn_Inscripcion.Size = new System.Drawing.Size(163, 30);
            this.btn_Inscripcion.TabIndex = 16;
            this.btn_Inscripcion.Text = "Inscribirse materia/s";
            this.btn_Inscripcion.UseVisualStyleBackColor = false;
            this.btn_Inscripcion.Click += new System.EventHandler(this.btn_Inscripcion_Click);
            // 
            // lbl_User
            // 
            this.lbl_User.AutoSize = true;
            this.lbl_User.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_User.Location = new System.Drawing.Point(28, 51);
            this.lbl_User.Name = "lbl_User";
            this.lbl_User.Size = new System.Drawing.Size(35, 17);
            this.lbl_User.TabIndex = 15;
            this.lbl_User.Text = "Mail";
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Nombre.Location = new System.Drawing.Point(28, 34);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(59, 17);
            this.lbl_Nombre.TabIndex = 13;
            this.lbl_Nombre.Text = "Nombre";
            // 
            // lbl_Alumno
            // 
            this.lbl_Alumno.AutoSize = true;
            this.lbl_Alumno.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Alumno.Location = new System.Drawing.Point(28, 12);
            this.lbl_Alumno.Name = "lbl_Alumno";
            this.lbl_Alumno.Size = new System.Drawing.Size(75, 22);
            this.lbl_Alumno.TabIndex = 12;
            this.lbl_Alumno.Text = "Alumno";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(178, 2);
            this.panel5.TabIndex = 11;
            // 
            // frm_Alumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.ClientSize = new System.Drawing.Size(710, 452);
            this.Controls.Add(this.pnl_Contenedor);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Alumno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UTN Alumno";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_MinimizeAlumno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_CloseAlumno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Close)).EndInit();
            this.pnl_Contenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MateriasCursadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnoBindingSource)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private PictureBox btn_Minimize;
        private PictureBox btn_Close;
        private PictureBox btn_MinimizeAlumno;
        private PictureBox btn_CloseAlumno;
        private Panel pnl_Contenedor;
        private Panel panel3;
        private Panel panel5;
        private Label lbl_User;
        private Label lbl_Nombre;
        private Label lbl_Alumno;
        private Button btn_DarPresente;
        private Button btn_Inscripcion;
        private Button btn_CerrarUserAlumno;
        private DataGridView dgv_MateriasCursadas;
        private BindingSource alumnoBindingSource;
        private Button btn_inicioAlumno;
        private DataGridViewTextBoxColumn materiaCursadaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ExamenNombre;
        private DataGridViewTextBoxColumn ExamenNota;
        private DataGridViewTextBoxColumn EstadoMateria;
        private DataGridViewTextBoxColumn EstadoDelAlumno;
    }
}