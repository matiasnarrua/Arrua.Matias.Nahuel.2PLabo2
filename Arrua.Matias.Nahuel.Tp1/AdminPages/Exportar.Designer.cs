namespace Arrua.Matias.Nahuel.Tp2.AdminPages
{
    partial class frm_Exportar
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
            this.btn_ExportarCsv = new System.Windows.Forms.Button();
            this.btn_ExportarJSON = new System.Windows.Forms.Button();
            this.cmb_Materias = new System.Windows.Forms.ComboBox();
            this.btn_Importar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_ExportarCsv
            // 
            this.btn_ExportarCsv.Location = new System.Drawing.Point(104, 248);
            this.btn_ExportarCsv.Name = "btn_ExportarCsv";
            this.btn_ExportarCsv.Size = new System.Drawing.Size(125, 55);
            this.btn_ExportarCsv.TabIndex = 0;
            this.btn_ExportarCsv.Text = "Exportar Csv";
            this.btn_ExportarCsv.UseVisualStyleBackColor = true;
            this.btn_ExportarCsv.Click += new System.EventHandler(this.btn_ExportarCsv_Click);
            // 
            // btn_ExportarJSON
            // 
            this.btn_ExportarJSON.Location = new System.Drawing.Point(278, 248);
            this.btn_ExportarJSON.Name = "btn_ExportarJSON";
            this.btn_ExportarJSON.Size = new System.Drawing.Size(125, 55);
            this.btn_ExportarJSON.TabIndex = 1;
            this.btn_ExportarJSON.Text = "Exportar Json";
            this.btn_ExportarJSON.UseVisualStyleBackColor = true;
            this.btn_ExportarJSON.Click += new System.EventHandler(this.btn_ExportarJSON_Click);
            // 
            // cmb_Materias
            // 
            this.cmb_Materias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Materias.FormattingEnabled = true;
            this.cmb_Materias.Location = new System.Drawing.Point(179, 127);
            this.cmb_Materias.Name = "cmb_Materias";
            this.cmb_Materias.Size = new System.Drawing.Size(157, 23);
            this.cmb_Materias.TabIndex = 2;
            // 
            // btn_Importar
            // 
            this.btn_Importar.Location = new System.Drawing.Point(188, 324);
            this.btn_Importar.Name = "btn_Importar";
            this.btn_Importar.Size = new System.Drawing.Size(125, 55);
            this.btn_Importar.TabIndex = 3;
            this.btn_Importar.Text = "Importar Json";
            this.btn_Importar.UseVisualStyleBackColor = true;
            this.btn_Importar.Click += new System.EventHandler(this.btn_Importar_Click);
            // 
            // frm_Exportar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.ClientSize = new System.Drawing.Size(532, 412);
            this.Controls.Add(this.btn_Importar);
            this.Controls.Add(this.cmb_Materias);
            this.Controls.Add(this.btn_ExportarJSON);
            this.Controls.Add(this.btn_ExportarCsv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Exportar";
            this.Text = "Exportar";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn_ExportarCsv;
        private Button btn_ExportarJSON;
        private ComboBox cmb_Materias;
        private Button btn_Importar;
    }
}