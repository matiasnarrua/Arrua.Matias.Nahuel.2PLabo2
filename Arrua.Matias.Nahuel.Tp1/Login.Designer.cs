namespace Arrua.Matias.Nahuel.Tp1
{
    partial class frm_Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Minimize = new System.Windows.Forms.PictureBox();
            this.btn_Close = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_ingresar = new System.Windows.Forms.Button();
            this.txt_Usuario = new System.Windows.Forms.TextBox();
            this.txt_Pass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_PreAdmin = new System.Windows.Forms.Button();
            this.btn_PreProfesor = new System.Windows.Forms.Button();
            this.btn_PreAlumno = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.panel1.Controls.Add(this.btn_Minimize);
            this.panel1.Controls.Add(this.btn_Close);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // btn_Minimize
            // 
            this.btn_Minimize.Image = global::Arrua.Matias.Nahuel.Tp2.Properties.Resources.Minimize_Icon;
            resources.ApplyResources(this.btn_Minimize, "btn_Minimize");
            this.btn_Minimize.Name = "btn_Minimize";
            this.btn_Minimize.TabStop = false;
            this.btn_Minimize.Click += new System.EventHandler(this.btn_Minimize_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Image = global::Arrua.Matias.Nahuel.Tp2.Properties.Resources.Close_Icon;
            resources.ApplyResources(this.btn_Close, "btn_Close");
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.TabStop = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // btn_ingresar
            // 
            resources.ApplyResources(this.btn_ingresar, "btn_ingresar");
            this.btn_ingresar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_ingresar.Name = "btn_ingresar";
            this.btn_ingresar.UseVisualStyleBackColor = true;
            this.btn_ingresar.Click += new System.EventHandler(this.btn_ingresar_Click);
            // 
            // txt_Usuario
            // 
            resources.ApplyResources(this.txt_Usuario, "txt_Usuario");
            this.txt_Usuario.Name = "txt_Usuario";
            // 
            // txt_Pass
            // 
            resources.ApplyResources(this.txt_Pass, "txt_Pass");
            this.txt_Pass.Name = "txt_Pass";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Name = "label2";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Arrua.Matias.Nahuel.Tp2.Properties.Resources.LogoUtn;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // btn_PreAdmin
            // 
            resources.ApplyResources(this.btn_PreAdmin, "btn_PreAdmin");
            this.btn_PreAdmin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_PreAdmin.Name = "btn_PreAdmin";
            this.btn_PreAdmin.UseVisualStyleBackColor = true;
            this.btn_PreAdmin.Click += new System.EventHandler(this.btn_PreAdmin_Click);
            // 
            // btn_PreProfesor
            // 
            resources.ApplyResources(this.btn_PreProfesor, "btn_PreProfesor");
            this.btn_PreProfesor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_PreProfesor.Name = "btn_PreProfesor";
            this.btn_PreProfesor.UseVisualStyleBackColor = true;
            this.btn_PreProfesor.Click += new System.EventHandler(this.btn_PreProfesor_Click);
            // 
            // btn_PreAlumno
            // 
            resources.ApplyResources(this.btn_PreAlumno, "btn_PreAlumno");
            this.btn_PreAlumno.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_PreAlumno.Name = "btn_PreAlumno";
            this.btn_PreAlumno.UseVisualStyleBackColor = true;
            this.btn_PreAlumno.Click += new System.EventHandler(this.btn_PreAlumno_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Name = "label3";
            // 
            // frm_Login
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_PreAlumno);
            this.Controls.Add(this.btn_PreProfesor);
            this.Controls.Add(this.btn_PreAdmin);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Pass);
            this.Controls.Add(this.txt_Usuario);
            this.Controls.Add(this.btn_ingresar);
            this.Controls.Add(this.panel2);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Login";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login_MouseDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox btn_Minimize;
        private PictureBox btn_Close;
        private Button btn_ingresar;
        private TextBox txt_Usuario;
        private TextBox txt_Pass;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private Button btn_PreAdmin;
        private Button btn_PreProfesor;
        private Button btn_PreAlumno;
        private Label label3;
    }
}