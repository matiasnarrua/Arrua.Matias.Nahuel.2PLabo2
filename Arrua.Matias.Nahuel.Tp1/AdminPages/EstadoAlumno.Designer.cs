namespace Arrua.Matias.Nahuel.Tp1.AdminPages
{
    partial class frm_EstadoAlumno
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
            this.lbl_tituloEstado = new System.Windows.Forms.Label();
            this.dgv_EstadoAlumno = new System.Windows.Forms.DataGridView();
            this.usuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materiaCursadaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alumnoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txt_Usuario = new System.Windows.Forms.TextBox();
            this.lbl_User = new System.Windows.Forms.Label();
            this.cmb_Estado = new System.Windows.Forms.ComboBox();
            this.lbl_Estado = new System.Windows.Forms.Label();
            this.btn_CambiarEstado = new System.Windows.Forms.Button();
            this.cmb_Materias = new System.Windows.Forms.ComboBox();
            this.lbl_Materias = new System.Windows.Forms.Label();
            this.btn_CargarMaterias = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_EstadoAlumno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiaCursadaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_tituloEstado
            // 
            this.lbl_tituloEstado.AutoSize = true;
            this.lbl_tituloEstado.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_tituloEstado.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_tituloEstado.Location = new System.Drawing.Point(126, 9);
            this.lbl_tituloEstado.Name = "lbl_tituloEstado";
            this.lbl_tituloEstado.Size = new System.Drawing.Size(277, 37);
            this.lbl_tituloEstado.TabIndex = 0;
            this.lbl_tituloEstado.Text = "Estado del Alumno";
            // 
            // dgv_EstadoAlumno
            // 
            this.dgv_EstadoAlumno.AllowUserToAddRows = false;
            this.dgv_EstadoAlumno.AllowUserToDeleteRows = false;
            this.dgv_EstadoAlumno.AutoGenerateColumns = false;
            this.dgv_EstadoAlumno.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.dgv_EstadoAlumno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_EstadoAlumno.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_EstadoAlumno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_EstadoAlumno.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usuarioDataGridViewTextBoxColumn,
            this.materiaDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1});
            this.dgv_EstadoAlumno.DataSource = this.materiaCursadaBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_EstadoAlumno.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_EstadoAlumno.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgv_EstadoAlumno.Location = new System.Drawing.Point(12, 69);
            this.dgv_EstadoAlumno.Name = "dgv_EstadoAlumno";
            this.dgv_EstadoAlumno.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_EstadoAlumno.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.dgv_EstadoAlumno.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_EstadoAlumno.RowTemplate.Height = 25;
            this.dgv_EstadoAlumno.Size = new System.Drawing.Size(341, 331);
            this.dgv_EstadoAlumno.TabIndex = 1;
            // 
            // usuarioDataGridViewTextBoxColumn
            // 
            this.usuarioDataGridViewTextBoxColumn.DataPropertyName = "Usuario";
            this.usuarioDataGridViewTextBoxColumn.HeaderText = "Usuario";
            this.usuarioDataGridViewTextBoxColumn.Name = "usuarioDataGridViewTextBoxColumn";
            this.usuarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // materiaDataGridViewTextBoxColumn
            // 
            this.materiaDataGridViewTextBoxColumn.DataPropertyName = "Materia";
            this.materiaDataGridViewTextBoxColumn.HeaderText = "Materia";
            this.materiaDataGridViewTextBoxColumn.Name = "materiaDataGridViewTextBoxColumn";
            this.materiaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "EstadoDelAlumno";
            this.dataGridViewTextBoxColumn1.HeaderText = "EstadoDelAlumno";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // materiaCursadaBindingSource
            // 
            this.materiaCursadaBindingSource.DataSource = typeof(TiposDeUsuarios.MateriaCursada);
            // 
            // alumnoBindingSource
            // 
            this.alumnoBindingSource.DataSource = typeof(TiposDeUsuarios.Alumno);
            // 
            // txt_Usuario
            // 
            this.txt_Usuario.Location = new System.Drawing.Point(371, 90);
            this.txt_Usuario.Name = "txt_Usuario";
            this.txt_Usuario.Size = new System.Drawing.Size(149, 23);
            this.txt_Usuario.TabIndex = 2;
            // 
            // lbl_User
            // 
            this.lbl_User.AutoSize = true;
            this.lbl_User.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_User.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_User.Location = new System.Drawing.Point(412, 66);
            this.lbl_User.Name = "lbl_User";
            this.lbl_User.Size = new System.Drawing.Size(64, 21);
            this.lbl_User.TabIndex = 3;
            this.lbl_User.Text = "Usuario";
            // 
            // cmb_Estado
            // 
            this.cmb_Estado.FormattingEnabled = true;
            this.cmb_Estado.Location = new System.Drawing.Point(371, 277);
            this.cmb_Estado.Name = "cmb_Estado";
            this.cmb_Estado.Size = new System.Drawing.Size(149, 23);
            this.cmb_Estado.TabIndex = 4;
            // 
            // lbl_Estado
            // 
            this.lbl_Estado.AutoSize = true;
            this.lbl_Estado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Estado.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Estado.Location = new System.Drawing.Point(412, 253);
            this.lbl_Estado.Name = "lbl_Estado";
            this.lbl_Estado.Size = new System.Drawing.Size(56, 21);
            this.lbl_Estado.TabIndex = 5;
            this.lbl_Estado.Text = "Estado";
            // 
            // btn_CambiarEstado
            // 
            this.btn_CambiarEstado.Location = new System.Drawing.Point(393, 315);
            this.btn_CambiarEstado.Name = "btn_CambiarEstado";
            this.btn_CambiarEstado.Size = new System.Drawing.Size(107, 23);
            this.btn_CambiarEstado.TabIndex = 6;
            this.btn_CambiarEstado.Text = "Cambiar";
            this.btn_CambiarEstado.UseVisualStyleBackColor = true;
            this.btn_CambiarEstado.Click += new System.EventHandler(this.btn_CambiarEstado_Click);
            // 
            // cmb_Materias
            // 
            this.cmb_Materias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Materias.FormattingEnabled = true;
            this.cmb_Materias.Location = new System.Drawing.Point(371, 198);
            this.cmb_Materias.Name = "cmb_Materias";
            this.cmb_Materias.Size = new System.Drawing.Size(149, 23);
            this.cmb_Materias.TabIndex = 7;
            // 
            // lbl_Materias
            // 
            this.lbl_Materias.AutoSize = true;
            this.lbl_Materias.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Materias.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Materias.Location = new System.Drawing.Point(412, 174);
            this.lbl_Materias.Name = "lbl_Materias";
            this.lbl_Materias.Size = new System.Drawing.Size(70, 21);
            this.lbl_Materias.TabIndex = 8;
            this.lbl_Materias.Text = "Materias";
            // 
            // btn_CargarMaterias
            // 
            this.btn_CargarMaterias.Location = new System.Drawing.Point(393, 122);
            this.btn_CargarMaterias.Name = "btn_CargarMaterias";
            this.btn_CargarMaterias.Size = new System.Drawing.Size(107, 23);
            this.btn_CargarMaterias.TabIndex = 9;
            this.btn_CargarMaterias.Text = "Cargar Materias";
            this.btn_CargarMaterias.UseVisualStyleBackColor = true;
            this.btn_CargarMaterias.Click += new System.EventHandler(this.btn_CargarMaterias_Click);
            // 
            // frm_EstadoAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.ClientSize = new System.Drawing.Size(532, 412);
            this.Controls.Add(this.btn_CargarMaterias);
            this.Controls.Add(this.lbl_Materias);
            this.Controls.Add(this.cmb_Materias);
            this.Controls.Add(this.btn_CambiarEstado);
            this.Controls.Add(this.lbl_Estado);
            this.Controls.Add(this.cmb_Estado);
            this.Controls.Add(this.lbl_User);
            this.Controls.Add(this.txt_Usuario);
            this.Controls.Add(this.dgv_EstadoAlumno);
            this.Controls.Add(this.lbl_tituloEstado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_EstadoAlumno";
            this.Text = "EstadoAlumno";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_EstadoAlumno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiaCursadaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_tituloEstado;
        private DataGridView dgv_EstadoAlumno;
        private BindingSource alumnoBindingSource;
        private TextBox txt_Usuario;
        private Label lbl_User;
        private ComboBox cmb_Estado;
        private Label lbl_Estado;
        private Button btn_CambiarEstado;
        private ComboBox cmb_Materias;
        private Label lbl_Materias;
        private Button btn_CargarMaterias;
        private DataGridViewTextBoxColumn materiaCursadaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn estadoDelAlumnoDataGridViewTextBoxColumn;
        private BindingSource materiaCursadaBindingSource;
        private DataGridViewTextBoxColumn usuarioDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn materiaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}