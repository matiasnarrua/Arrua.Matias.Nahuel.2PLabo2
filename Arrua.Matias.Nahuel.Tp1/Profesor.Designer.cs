namespace Arrua.Matias.Nahuel.Tp1
{
    partial class frm_Profesor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Profesor));
            this.pnl_Contenedor = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_CerrarUserProfesor = new System.Windows.Forms.Button();
            this.btn_MinimizeProfesor = new System.Windows.Forms.PictureBox();
            this.btn_MinimizeAlumno = new System.Windows.Forms.PictureBox();
            this.btn_CloseProfesor = new System.Windows.Forms.PictureBox();
            this.btn_CloseAlumno = new System.Windows.Forms.PictureBox();
            this.btn_Minimize = new System.Windows.Forms.PictureBox();
            this.btn_Close = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_Materia = new System.Windows.Forms.Label();
            this.btn_CargarNota = new System.Windows.Forms.Button();
            this.btn_CrearExamen = new System.Windows.Forms.Button();
            this.lbl_UserProfesor = new System.Windows.Forms.Label();
            this.lbl_NombreProfesor = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_MinimizeProfesor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_MinimizeAlumno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_CloseProfesor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_CloseAlumno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Close)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Contenedor
            // 
            this.pnl_Contenedor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_Contenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.pnl_Contenedor.Location = new System.Drawing.Point(178, 40);
            this.pnl_Contenedor.Name = "pnl_Contenedor";
            this.pnl_Contenedor.Size = new System.Drawing.Size(532, 412);
            this.pnl_Contenedor.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.panel1.Controls.Add(this.btn_CerrarUserProfesor);
            this.panel1.Controls.Add(this.btn_MinimizeProfesor);
            this.panel1.Controls.Add(this.btn_MinimizeAlumno);
            this.panel1.Controls.Add(this.btn_CloseProfesor);
            this.panel1.Controls.Add(this.btn_CloseAlumno);
            this.panel1.Controls.Add(this.btn_Minimize);
            this.panel1.Controls.Add(this.btn_Close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(710, 40);
            this.panel1.TabIndex = 3;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // btn_CerrarUserProfesor
            // 
            this.btn_CerrarUserProfesor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.btn_CerrarUserProfesor.FlatAppearance.BorderSize = 0;
            this.btn_CerrarUserProfesor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CerrarUserProfesor.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_CerrarUserProfesor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_CerrarUserProfesor.Location = new System.Drawing.Point(8, 5);
            this.btn_CerrarUserProfesor.Name = "btn_CerrarUserProfesor";
            this.btn_CerrarUserProfesor.Size = new System.Drawing.Size(142, 23);
            this.btn_CerrarUserProfesor.TabIndex = 10;
            this.btn_CerrarUserProfesor.Text = "Cerrar Sesion";
            this.btn_CerrarUserProfesor.UseVisualStyleBackColor = true;
            this.btn_CerrarUserProfesor.Click += new System.EventHandler(this.btn_CerrarUserProfesor_Click);
            // 
            // btn_MinimizeProfesor
            // 
            this.btn_MinimizeProfesor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_MinimizeProfesor.Image = global::Arrua.Matias.Nahuel.Tp2.Properties.Resources.Minimize_Icon;
            this.btn_MinimizeProfesor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_MinimizeProfesor.Location = new System.Drawing.Point(648, 12);
            this.btn_MinimizeProfesor.Name = "btn_MinimizeProfesor";
            this.btn_MinimizeProfesor.Size = new System.Drawing.Size(16, 16);
            this.btn_MinimizeProfesor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btn_MinimizeProfesor.TabIndex = 9;
            this.btn_MinimizeProfesor.TabStop = false;
            this.btn_MinimizeProfesor.Click += new System.EventHandler(this.btn_MinimizeProfesor_Click);
            // 
            // btn_MinimizeAlumno
            // 
            this.btn_MinimizeAlumno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_MinimizeAlumno.Image = global::Arrua.Matias.Nahuel.Tp2.Properties.Resources.Minimize_Icon;
            this.btn_MinimizeAlumno.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_MinimizeAlumno.Location = new System.Drawing.Point(1158, 12);
            this.btn_MinimizeAlumno.Name = "btn_MinimizeAlumno";
            this.btn_MinimizeAlumno.Size = new System.Drawing.Size(16, 16);
            this.btn_MinimizeAlumno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btn_MinimizeAlumno.TabIndex = 7;
            this.btn_MinimizeAlumno.TabStop = false;
            // 
            // btn_CloseProfesor
            // 
            this.btn_CloseProfesor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_CloseProfesor.Image = global::Arrua.Matias.Nahuel.Tp2.Properties.Resources.Close_Icon;
            this.btn_CloseProfesor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_CloseProfesor.Location = new System.Drawing.Point(682, 12);
            this.btn_CloseProfesor.Name = "btn_CloseProfesor";
            this.btn_CloseProfesor.Size = new System.Drawing.Size(16, 16);
            this.btn_CloseProfesor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btn_CloseProfesor.TabIndex = 8;
            this.btn_CloseProfesor.TabStop = false;
            this.btn_CloseProfesor.Click += new System.EventHandler(this.btn_CloseProfesor_Click);
            // 
            // btn_CloseAlumno
            // 
            this.btn_CloseAlumno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_CloseAlumno.Image = global::Arrua.Matias.Nahuel.Tp2.Properties.Resources.Close_Icon;
            this.btn_CloseAlumno.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_CloseAlumno.Location = new System.Drawing.Point(1192, 12);
            this.btn_CloseAlumno.Name = "btn_CloseAlumno";
            this.btn_CloseAlumno.Size = new System.Drawing.Size(16, 16);
            this.btn_CloseAlumno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btn_CloseAlumno.TabIndex = 6;
            this.btn_CloseAlumno.TabStop = false;
            // 
            // btn_Minimize
            // 
            this.btn_Minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Minimize.Image = global::Arrua.Matias.Nahuel.Tp2.Properties.Resources.Minimize_Icon;
            this.btn_Minimize.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Minimize.Location = new System.Drawing.Point(1668, 12);
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
            this.btn_Close.Location = new System.Drawing.Point(1702, 12);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(16, 16);
            this.btn_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btn_Close.TabIndex = 4;
            this.btn_Close.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.panel3.Controls.Add(this.lbl_Materia);
            this.panel3.Controls.Add(this.btn_CargarNota);
            this.panel3.Controls.Add(this.btn_CrearExamen);
            this.panel3.Controls.Add(this.lbl_UserProfesor);
            this.panel3.Controls.Add(this.lbl_NombreProfesor);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Location = new System.Drawing.Point(0, 40);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(178, 412);
            this.panel3.TabIndex = 5;
            // 
            // lbl_Materia
            // 
            this.lbl_Materia.AutoSize = true;
            this.lbl_Materia.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Materia.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Materia.Location = new System.Drawing.Point(28, 71);
            this.lbl_Materia.Name = "lbl_Materia";
            this.lbl_Materia.Size = new System.Drawing.Size(0, 17);
            this.lbl_Materia.TabIndex = 18;
            // 
            // btn_CargarNota
            // 
            this.btn_CargarNota.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.btn_CargarNota.FlatAppearance.BorderSize = 0;
            this.btn_CargarNota.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.btn_CargarNota.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CargarNota.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_CargarNota.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_CargarNota.Location = new System.Drawing.Point(8, 209);
            this.btn_CargarNota.Name = "btn_CargarNota";
            this.btn_CargarNota.Size = new System.Drawing.Size(163, 28);
            this.btn_CargarNota.TabIndex = 17;
            this.btn_CargarNota.Text = "Cargar notas";
            this.btn_CargarNota.UseVisualStyleBackColor = false;
            this.btn_CargarNota.Click += new System.EventHandler(this.btn_CargarNota_Click);
            // 
            // btn_CrearExamen
            // 
            this.btn_CrearExamen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.btn_CrearExamen.FlatAppearance.BorderSize = 0;
            this.btn_CrearExamen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.btn_CrearExamen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CrearExamen.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_CrearExamen.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_CrearExamen.Location = new System.Drawing.Point(8, 148);
            this.btn_CrearExamen.Name = "btn_CrearExamen";
            this.btn_CrearExamen.Size = new System.Drawing.Size(163, 30);
            this.btn_CrearExamen.TabIndex = 16;
            this.btn_CrearExamen.Text = "Crear examen";
            this.btn_CrearExamen.UseVisualStyleBackColor = false;
            this.btn_CrearExamen.Click += new System.EventHandler(this.btn_CrearExamen_Click);
            // 
            // lbl_UserProfesor
            // 
            this.lbl_UserProfesor.AutoSize = true;
            this.lbl_UserProfesor.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_UserProfesor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_UserProfesor.Location = new System.Drawing.Point(28, 54);
            this.lbl_UserProfesor.Name = "lbl_UserProfesor";
            this.lbl_UserProfesor.Size = new System.Drawing.Size(35, 17);
            this.lbl_UserProfesor.TabIndex = 15;
            this.lbl_UserProfesor.Text = "Mail";
            // 
            // lbl_NombreProfesor
            // 
            this.lbl_NombreProfesor.AutoSize = true;
            this.lbl_NombreProfesor.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_NombreProfesor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_NombreProfesor.Location = new System.Drawing.Point(28, 34);
            this.lbl_NombreProfesor.Name = "lbl_NombreProfesor";
            this.lbl_NombreProfesor.Size = new System.Drawing.Size(59, 17);
            this.lbl_NombreProfesor.TabIndex = 13;
            this.lbl_NombreProfesor.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(28, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 22);
            this.label1.TabIndex = 12;
            this.label1.Text = "Profesor";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(178, 2);
            this.panel5.TabIndex = 11;
            // 
            // frm_Profesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 452);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnl_Contenedor);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Profesor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UTN Profesor";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_MinimizeProfesor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_MinimizeAlumno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_CloseProfesor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_CloseAlumno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Close)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnl_Contenedor;
        private Panel panel1;
        private PictureBox btn_MinimizeAlumno;
        private PictureBox btn_CloseAlumno;
        private PictureBox btn_Minimize;
        private PictureBox btn_Close;
        private PictureBox btn_MinimizeProfesor;
        private PictureBox btn_CloseProfesor;
        private Panel panel3;
        private Button btn_CargarNota;
        private Button btn_CrearExamen;
        private Label lbl_UserProfesor;
        private Label lbl_NombreProfesor;
        private Label label1;
        private Panel panel5;
        private Button btn_CerrarUserProfesor;
        private Label lbl_Materia;
    }
}