namespace Arrua.Matias.Nahuel.Tp1
{
    partial class frm_Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Admin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_CerrarUserAdmin = new System.Windows.Forms.Button();
            this.btn_Minimize = new System.Windows.Forms.PictureBox();
            this.btn_Close = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_EstadoAlumno = new System.Windows.Forms.Button();
            this.btn_AddMateria = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_AddProfesor = new System.Windows.Forms.Button();
            this.btn_AddAlumno = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_AsignarProfesor = new System.Windows.Forms.Button();
            this.btn_AddAdmin = new System.Windows.Forms.Button();
            this.pnl_Contenedor = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Close)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.panel1.Controls.Add(this.btn_CerrarUserAdmin);
            this.panel1.Controls.Add(this.btn_Minimize);
            this.panel1.Controls.Add(this.btn_Close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(710, 40);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // btn_CerrarUserAdmin
            // 
            this.btn_CerrarUserAdmin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.btn_CerrarUserAdmin.FlatAppearance.BorderSize = 0;
            this.btn_CerrarUserAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CerrarUserAdmin.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_CerrarUserAdmin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_CerrarUserAdmin.Location = new System.Drawing.Point(6, 5);
            this.btn_CerrarUserAdmin.Name = "btn_CerrarUserAdmin";
            this.btn_CerrarUserAdmin.Size = new System.Drawing.Size(142, 23);
            this.btn_CerrarUserAdmin.TabIndex = 9;
            this.btn_CerrarUserAdmin.Text = "Cerrar Sesion";
            this.btn_CerrarUserAdmin.UseVisualStyleBackColor = true;
            this.btn_CerrarUserAdmin.Click += new System.EventHandler(this.btn_CerrarUserAdmin_Click);
            // 
            // btn_Minimize
            // 
            this.btn_Minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Minimize.Image = global::Arrua.Matias.Nahuel.Tp2.Properties.Resources.Minimize_Icon;
            this.btn_Minimize.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Minimize.Location = new System.Drawing.Point(648, 12);
            this.btn_Minimize.Name = "btn_Minimize";
            this.btn_Minimize.Size = new System.Drawing.Size(16, 16);
            this.btn_Minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btn_Minimize.TabIndex = 5;
            this.btn_Minimize.TabStop = false;
            this.btn_Minimize.Click += new System.EventHandler(this.btn_Minimize_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Close.Image = global::Arrua.Matias.Nahuel.Tp2.Properties.Resources.Close_Icon;
            this.btn_Close.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Close.Location = new System.Drawing.Point(682, 12);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(16, 16);
            this.btn_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btn_Close.TabIndex = 4;
            this.btn_Close.TabStop = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btn_EstadoAlumno);
            this.panel2.Controls.Add(this.btn_AddMateria);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btn_AddProfesor);
            this.panel2.Controls.Add(this.btn_AddAlumno);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.btn_AsignarProfesor);
            this.panel2.Controls.Add(this.btn_AddAdmin);
            this.panel2.Location = new System.Drawing.Point(0, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(178, 412);
            this.panel2.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(178, 2);
            this.panel5.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(50, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "Admin";
            // 
            // btn_EstadoAlumno
            // 
            this.btn_EstadoAlumno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.btn_EstadoAlumno.FlatAppearance.BorderSize = 0;
            this.btn_EstadoAlumno.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.btn_EstadoAlumno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_EstadoAlumno.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_EstadoAlumno.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_EstadoAlumno.Location = new System.Drawing.Point(6, 353);
            this.btn_EstadoAlumno.Name = "btn_EstadoAlumno";
            this.btn_EstadoAlumno.Size = new System.Drawing.Size(163, 28);
            this.btn_EstadoAlumno.TabIndex = 9;
            this.btn_EstadoAlumno.Text = "Estado del alumno";
            this.btn_EstadoAlumno.UseVisualStyleBackColor = false;
            this.btn_EstadoAlumno.Click += new System.EventHandler(this.btn_EstadoAlumno_Click);
            // 
            // btn_AddMateria
            // 
            this.btn_AddMateria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.btn_AddMateria.FlatAppearance.BorderSize = 0;
            this.btn_AddMateria.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.btn_AddMateria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddMateria.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_AddMateria.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_AddMateria.Location = new System.Drawing.Point(6, 319);
            this.btn_AddMateria.Name = "btn_AddMateria";
            this.btn_AddMateria.Size = new System.Drawing.Size(163, 28);
            this.btn_AddMateria.TabIndex = 8;
            this.btn_AddMateria.Text = "Crear materia";
            this.btn_AddMateria.UseVisualStyleBackColor = false;
            this.btn_AddMateria.Click += new System.EventHandler(this.btn_AddMateria_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(41, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 26);
            this.label2.TabIndex = 7;
            this.label2.Text = "Materias";
            // 
            // btn_AddProfesor
            // 
            this.btn_AddProfesor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.btn_AddProfesor.FlatAppearance.BorderSize = 0;
            this.btn_AddProfesor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.btn_AddProfesor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddProfesor.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_AddProfesor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_AddProfesor.Location = new System.Drawing.Point(6, 201);
            this.btn_AddProfesor.Name = "btn_AddProfesor";
            this.btn_AddProfesor.Size = new System.Drawing.Size(166, 28);
            this.btn_AddProfesor.TabIndex = 6;
            this.btn_AddProfesor.Text = "Profesor";
            this.btn_AddProfesor.UseVisualStyleBackColor = false;
            this.btn_AddProfesor.Click += new System.EventHandler(this.btn_AddProfesor_Click);
            // 
            // btn_AddAlumno
            // 
            this.btn_AddAlumno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.btn_AddAlumno.FlatAppearance.BorderSize = 0;
            this.btn_AddAlumno.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.btn_AddAlumno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddAlumno.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_AddAlumno.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_AddAlumno.Location = new System.Drawing.Point(6, 167);
            this.btn_AddAlumno.Name = "btn_AddAlumno";
            this.btn_AddAlumno.Size = new System.Drawing.Size(166, 28);
            this.btn_AddAlumno.TabIndex = 5;
            this.btn_AddAlumno.Text = "Alumno";
            this.btn_AddAlumno.UseVisualStyleBackColor = false;
            this.btn_AddAlumno.Click += new System.EventHandler(this.btn_AddAlumno_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(61, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Alta";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.panel4.Location = new System.Drawing.Point(3, 251);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(7, 28);
            this.panel4.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.panel3.Location = new System.Drawing.Point(3, 99);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(7, 28);
            this.panel3.TabIndex = 1;
            // 
            // btn_AsignarProfesor
            // 
            this.btn_AsignarProfesor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.btn_AsignarProfesor.FlatAppearance.BorderSize = 0;
            this.btn_AsignarProfesor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.btn_AsignarProfesor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AsignarProfesor.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_AsignarProfesor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_AsignarProfesor.Location = new System.Drawing.Point(6, 285);
            this.btn_AsignarProfesor.Name = "btn_AsignarProfesor";
            this.btn_AsignarProfesor.Size = new System.Drawing.Size(163, 28);
            this.btn_AsignarProfesor.TabIndex = 2;
            this.btn_AsignarProfesor.Text = "Asignar profesor";
            this.btn_AsignarProfesor.UseVisualStyleBackColor = false;
            this.btn_AsignarProfesor.Click += new System.EventHandler(this.btn_AsignarProfesor_Click);
            // 
            // btn_AddAdmin
            // 
            this.btn_AddAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.btn_AddAdmin.FlatAppearance.BorderSize = 0;
            this.btn_AddAdmin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.btn_AddAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddAdmin.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_AddAdmin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_AddAdmin.Location = new System.Drawing.Point(6, 133);
            this.btn_AddAdmin.Name = "btn_AddAdmin";
            this.btn_AddAdmin.Size = new System.Drawing.Size(163, 28);
            this.btn_AddAdmin.TabIndex = 0;
            this.btn_AddAdmin.Text = "Admin";
            this.btn_AddAdmin.UseVisualStyleBackColor = false;
            this.btn_AddAdmin.Click += new System.EventHandler(this.btn_AddAdmin_Click);
            // 
            // pnl_Contenedor
            // 
            this.pnl_Contenedor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_Contenedor.Location = new System.Drawing.Point(178, 40);
            this.pnl_Contenedor.Name = "pnl_Contenedor";
            this.pnl_Contenedor.Size = new System.Drawing.Size(532, 412);
            this.pnl_Contenedor.TabIndex = 2;
            // 
            // frm_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.ClientSize = new System.Drawing.Size(710, 452);
            this.Controls.Add(this.pnl_Contenedor);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Close)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private PictureBox btn_Minimize;
        private PictureBox btn_Close;
        private Panel panel2;
        private Button btn_AddAdmin;
        private Panel panel4;
        private Panel panel3;
        private Button btn_AsignarProfesor;
        private Label label3;
        private Button btn_EstadoAlumno;
        private Button btn_AddMateria;
        private Label label2;
        private Button btn_AddProfesor;
        private Button btn_AddAlumno;
        private Label label1;
        private Panel panel5;
        private Panel pnl_Contenedor;
        private Button btn_CerrarUserAdmin;
    }
}