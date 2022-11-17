namespace Arrua.Matias.Nahuel.Tp1.AdminPages
{
    partial class frm_CrearMateria
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_Materias = new System.Windows.Forms.DataGridView();
            this.lbl_User = new System.Windows.Forms.Label();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.btn_AltaMateria = new System.Windows.Forms.Button();
            this.txt_Correlativa = new System.Windows.Forms.TextBox();
            this.txt_NombreMateria = new System.Windows.Forms.TextBox();
            this.materiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profesorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materiaCorrelativaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Materias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(157, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Crear Materia";
            // 
            // dgv_Materias
            // 
            this.dgv_Materias.AllowUserToAddRows = false;
            this.dgv_Materias.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.dgv_Materias.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Materias.AutoGenerateColumns = false;
            this.dgv_Materias.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.dgv_Materias.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Materias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Materias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Materias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreDataGridViewTextBoxColumn,
            this.profesorDataGridViewTextBoxColumn,
            this.materiaCorrelativaDataGridViewTextBoxColumn});
            this.dgv_Materias.DataSource = this.materiaBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Materias.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Materias.GridColor = System.Drawing.Color.White;
            this.dgv_Materias.Location = new System.Drawing.Point(12, 67);
            this.dgv_Materias.Name = "dgv_Materias";
            this.dgv_Materias.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Materias.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            this.dgv_Materias.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_Materias.RowTemplate.Height = 25;
            this.dgv_Materias.Size = new System.Drawing.Size(363, 254);
            this.dgv_Materias.TabIndex = 5;
            // 
            // lbl_User
            // 
            this.lbl_User.AutoSize = true;
            this.lbl_User.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_User.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_User.Location = new System.Drawing.Point(211, 339);
            this.lbl_User.Name = "lbl_User";
            this.lbl_User.Size = new System.Drawing.Size(86, 19);
            this.lbl_User.TabIndex = 15;
            this.lbl_User.Text = "Correlativa";
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Nombre.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Nombre.Location = new System.Drawing.Point(20, 336);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(160, 19);
            this.lbl_Nombre.TabIndex = 13;
            this.lbl_Nombre.Text = "Nombre de la materia";
            // 
            // btn_AltaMateria
            // 
            this.btn_AltaMateria.Location = new System.Drawing.Point(384, 354);
            this.btn_AltaMateria.Name = "btn_AltaMateria";
            this.btn_AltaMateria.Size = new System.Drawing.Size(93, 29);
            this.btn_AltaMateria.TabIndex = 12;
            this.btn_AltaMateria.Text = "Agregar";
            this.btn_AltaMateria.UseVisualStyleBackColor = true;
            this.btn_AltaMateria.Click += new System.EventHandler(this.btn_AltaMateria_Click);
            // 
            // txt_Correlativa
            // 
            this.txt_Correlativa.Location = new System.Drawing.Point(211, 361);
            this.txt_Correlativa.Name = "txt_Correlativa";
            this.txt_Correlativa.Size = new System.Drawing.Size(124, 23);
            this.txt_Correlativa.TabIndex = 11;
            // 
            // txt_NombreMateria
            // 
            this.txt_NombreMateria.Location = new System.Drawing.Point(40, 358);
            this.txt_NombreMateria.Name = "txt_NombreMateria";
            this.txt_NombreMateria.Size = new System.Drawing.Size(124, 23);
            this.txt_NombreMateria.TabIndex = 9;
            // 
            // materiaBindingSource
            // 
            this.materiaBindingSource.DataSource = typeof(TiposDeUsuarios.Materia);
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // profesorDataGridViewTextBoxColumn
            // 
            this.profesorDataGridViewTextBoxColumn.DataPropertyName = "Profesor";
            this.profesorDataGridViewTextBoxColumn.HeaderText = "Profesor";
            this.profesorDataGridViewTextBoxColumn.Name = "profesorDataGridViewTextBoxColumn";
            this.profesorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // materiaCorrelativaDataGridViewTextBoxColumn
            // 
            this.materiaCorrelativaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.materiaCorrelativaDataGridViewTextBoxColumn.DataPropertyName = "MateriaCorrelativa";
            this.materiaCorrelativaDataGridViewTextBoxColumn.HeaderText = "Materia Correlativa";
            this.materiaCorrelativaDataGridViewTextBoxColumn.Name = "materiaCorrelativaDataGridViewTextBoxColumn";
            this.materiaCorrelativaDataGridViewTextBoxColumn.ReadOnly = true;
            this.materiaCorrelativaDataGridViewTextBoxColumn.Width = 121;
            // 
            // frm_CrearMateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.ClientSize = new System.Drawing.Size(532, 412);
            this.Controls.Add(this.lbl_User);
            this.Controls.Add(this.lbl_Nombre);
            this.Controls.Add(this.btn_AltaMateria);
            this.Controls.Add(this.txt_Correlativa);
            this.Controls.Add(this.txt_NombreMateria);
            this.Controls.Add(this.dgv_Materias);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_CrearMateria";
            this.Text = "CrearMateria";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Materias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private DataGridView dgv_Materias;
        private Label lbl_User;
        private Label lbl_Nombre;
        private Button btn_AltaMateria;
        private TextBox txt_Correlativa;
        private TextBox txt_NombreMateria;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn profesorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn materiaCorrelativaDataGridViewTextBoxColumn;
        private BindingSource materiaBindingSource;
    }
}