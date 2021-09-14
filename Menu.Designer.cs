
namespace U2A1IDEJAMR
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAltaMedicos = new System.Windows.Forms.Button();
            this.btnModificarEliminarMedicos = new System.Windows.Forms.Button();
            this.btnAltaPacientes = new System.Windows.Forms.Button();
            this.btnModificarEliminarPacientes = new System.Windows.Forms.Button();
            this.btnBuscarPacientes = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 0);
            this.panel1.TabIndex = 1;
            // 
            // btnAltaMedicos
            // 
            this.btnAltaMedicos.Location = new System.Drawing.Point(3, 76);
            this.btnAltaMedicos.Name = "btnAltaMedicos";
            this.btnAltaMedicos.Size = new System.Drawing.Size(168, 23);
            this.btnAltaMedicos.TabIndex = 2;
            this.btnAltaMedicos.Text = "Alta Medicos";
            this.btnAltaMedicos.UseVisualStyleBackColor = true;
            this.btnAltaMedicos.Click += new System.EventHandler(this.btnAltaMedicos_Click);
            // 
            // btnModificarEliminarMedicos
            // 
            this.btnModificarEliminarMedicos.Location = new System.Drawing.Point(3, 137);
            this.btnModificarEliminarMedicos.Name = "btnModificarEliminarMedicos";
            this.btnModificarEliminarMedicos.Size = new System.Drawing.Size(168, 23);
            this.btnModificarEliminarMedicos.TabIndex = 3;
            this.btnModificarEliminarMedicos.Text = "Modificar y Eliminar Medicos";
            this.btnModificarEliminarMedicos.UseVisualStyleBackColor = true;
            this.btnModificarEliminarMedicos.Click += new System.EventHandler(this.btnModificarEliminarMedicos_Click);
            // 
            // btnAltaPacientes
            // 
            this.btnAltaPacientes.Location = new System.Drawing.Point(3, 203);
            this.btnAltaPacientes.Name = "btnAltaPacientes";
            this.btnAltaPacientes.Size = new System.Drawing.Size(168, 23);
            this.btnAltaPacientes.TabIndex = 4;
            this.btnAltaPacientes.Text = "Alta Pacientes";
            this.btnAltaPacientes.UseVisualStyleBackColor = true;
            this.btnAltaPacientes.Click += new System.EventHandler(this.btnAltaPacientes_Click);
            // 
            // btnModificarEliminarPacientes
            // 
            this.btnModificarEliminarPacientes.Location = new System.Drawing.Point(5, 266);
            this.btnModificarEliminarPacientes.Name = "btnModificarEliminarPacientes";
            this.btnModificarEliminarPacientes.Size = new System.Drawing.Size(168, 23);
            this.btnModificarEliminarPacientes.TabIndex = 5;
            this.btnModificarEliminarPacientes.Text = "Modificar y Eliminar Pacientes";
            this.btnModificarEliminarPacientes.UseVisualStyleBackColor = true;
            this.btnModificarEliminarPacientes.Click += new System.EventHandler(this.btnModificarEliminarPacientes_Click);
            // 
            // btnBuscarPacientes
            // 
            this.btnBuscarPacientes.Location = new System.Drawing.Point(3, 326);
            this.btnBuscarPacientes.Name = "btnBuscarPacientes";
            this.btnBuscarPacientes.Size = new System.Drawing.Size(168, 23);
            this.btnBuscarPacientes.TabIndex = 6;
            this.btnBuscarPacientes.Text = "Buscar Pacientes";
            this.btnBuscarPacientes.UseVisualStyleBackColor = true;
            this.btnBuscarPacientes.Click += new System.EventHandler(this.btnBuscarPacientes_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel2.Controls.Add(this.lblTitulo);
            this.panel2.Controls.Add(this.btnAltaMedicos);
            this.panel2.Controls.Add(this.btnBuscarPacientes);
            this.panel2.Controls.Add(this.btnModificarEliminarMedicos);
            this.panel2.Controls.Add(this.btnModificarEliminarPacientes);
            this.panel2.Controls.Add(this.btnAltaPacientes);
            this.panel2.Location = new System.Drawing.Point(2, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(176, 452);
            this.panel2.TabIndex = 7;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Mistral", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTitulo.Location = new System.Drawing.Point(25, 13);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(147, 34);
            this.lblTitulo.TabIndex = 7;
            this.lblTitulo.Text = "Clinica Salud";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(510, 438);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAltaMedicos;
        private System.Windows.Forms.Button btnModificarEliminarMedicos;
        private System.Windows.Forms.Button btnAltaPacientes;
        private System.Windows.Forms.Button btnModificarEliminarPacientes;
        private System.Windows.Forms.Button btnBuscarPacientes;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTitulo;
    }
}