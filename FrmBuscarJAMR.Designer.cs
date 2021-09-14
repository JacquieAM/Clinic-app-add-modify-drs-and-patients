
namespace U2A1IDEJAMR
{
    partial class FrmBuscarJAMR
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBuscarJAMR));
            this.lbl_medicos = new System.Windows.Forms.Label();
            this.CbxMedicos = new System.Windows.Forms.ComboBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.lbl_pacientes = new System.Windows.Forms.Label();
            this.DgvPacientes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPacientes)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_medicos
            // 
            this.lbl_medicos.AutoSize = true;
            this.lbl_medicos.Location = new System.Drawing.Point(26, 23);
            this.lbl_medicos.Name = "lbl_medicos";
            this.lbl_medicos.Size = new System.Drawing.Size(47, 13);
            this.lbl_medicos.TabIndex = 0;
            this.lbl_medicos.Text = "Medicos";
            // 
            // CbxMedicos
            // 
            this.CbxMedicos.FormattingEnabled = true;
            this.CbxMedicos.Location = new System.Drawing.Point(29, 59);
            this.CbxMedicos.Name = "CbxMedicos";
            this.CbxMedicos.Size = new System.Drawing.Size(121, 21);
            this.CbxMedicos.TabIndex = 1;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(29, 321);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar.TabIndex = 2;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // lbl_pacientes
            // 
            this.lbl_pacientes.AutoSize = true;
            this.lbl_pacientes.Location = new System.Drawing.Point(26, 113);
            this.lbl_pacientes.Name = "lbl_pacientes";
            this.lbl_pacientes.Size = new System.Drawing.Size(54, 13);
            this.lbl_pacientes.TabIndex = 3;
            this.lbl_pacientes.Text = "Pacientes";
            // 
            // DgvPacientes
            // 
            this.DgvPacientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvPacientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPacientes.Location = new System.Drawing.Point(29, 148);
            this.DgvPacientes.Name = "DgvPacientes";
            this.DgvPacientes.Size = new System.Drawing.Size(385, 152);
            this.DgvPacientes.TabIndex = 5;
            // 
            // FrmBuscarJAMR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(510, 356);
            this.Controls.Add(this.DgvPacientes);
            this.Controls.Add(this.lbl_pacientes);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.CbxMedicos);
            this.Controls.Add(this.lbl_medicos);
            this.Name = "FrmBuscarJAMR";
            this.Text = "FrmBuscarJAMR";
            ((System.ComponentModel.ISupportInitialize)(this.DgvPacientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_medicos;
        private System.Windows.Forms.ComboBox CbxMedicos;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Label lbl_pacientes;
        private System.Windows.Forms.DataGridView DgvPacientes;
    }
}