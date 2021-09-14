
namespace U2A1IDEJAMR
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Guardar = new System.Windows.Forms.Button();
            this.RbdSexo = new System.Windows.Forms.GroupBox();
            this.RbdSexoM = new System.Windows.Forms.RadioButton();
            this.RbdSexoF = new System.Windows.Forms.RadioButton();
            this.CbxEdoCivil = new System.Windows.Forms.ComboBox();
            this.lbl_EdoCivil = new System.Windows.Forms.Label();
            this.TxtNombreC = new System.Windows.Forms.TextBox();
            this.lbl_nombreCompleto = new System.Windows.Forms.Label();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.lbl_direccion = new System.Windows.Forms.Label();
            this.TxtTelefonoFijo = new System.Windows.Forms.TextBox();
            this.lbl_telefonoFijo = new System.Windows.Forms.Label();
            this.TxtCelular = new System.Windows.Forms.TextBox();
            this.lbl_celular = new System.Windows.Forms.Label();
            this.TxtEdad = new System.Windows.Forms.TextBox();
            this.lbl_edad = new System.Windows.Forms.Label();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.btn_conectar = new System.Windows.Forms.Button();
            this.lbl_medicos = new System.Windows.Forms.Label();
            this.CbxMedicos = new System.Windows.Forms.ComboBox();
            this.RbdSexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // Guardar
            // 
            this.Guardar.Location = new System.Drawing.Point(240, 401);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(135, 37);
            this.Guardar.TabIndex = 0;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = true;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // RbdSexo
            // 
            this.RbdSexo.Controls.Add(this.RbdSexoM);
            this.RbdSexo.Controls.Add(this.RbdSexoF);
            this.RbdSexo.Location = new System.Drawing.Point(378, 9);
            this.RbdSexo.Name = "RbdSexo";
            this.RbdSexo.Size = new System.Drawing.Size(99, 44);
            this.RbdSexo.TabIndex = 1;
            this.RbdSexo.TabStop = false;
            this.RbdSexo.Text = "Sexo";
            // 
            // RbdSexoM
            // 
            this.RbdSexoM.AutoSize = true;
            this.RbdSexoM.Location = new System.Drawing.Point(54, 19);
            this.RbdSexoM.Name = "RbdSexoM";
            this.RbdSexoM.Size = new System.Drawing.Size(34, 17);
            this.RbdSexoM.TabIndex = 1;
            this.RbdSexoM.TabStop = true;
            this.RbdSexoM.Text = "M";
            this.RbdSexoM.UseVisualStyleBackColor = true;
            // 
            // RbdSexoF
            // 
            this.RbdSexoF.AutoSize = true;
            this.RbdSexoF.Location = new System.Drawing.Point(6, 19);
            this.RbdSexoF.Name = "RbdSexoF";
            this.RbdSexoF.Size = new System.Drawing.Size(31, 17);
            this.RbdSexoF.TabIndex = 0;
            this.RbdSexoF.TabStop = true;
            this.RbdSexoF.Text = "F";
            this.RbdSexoF.UseVisualStyleBackColor = true;
            // 
            // CbxEdoCivil
            // 
            this.CbxEdoCivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxEdoCivil.FormattingEnabled = true;
            this.CbxEdoCivil.Location = new System.Drawing.Point(118, 290);
            this.CbxEdoCivil.Name = "CbxEdoCivil";
            this.CbxEdoCivil.Size = new System.Drawing.Size(121, 21);
            this.CbxEdoCivil.TabIndex = 2;
            // 
            // lbl_EdoCivil
            // 
            this.lbl_EdoCivil.AutoSize = true;
            this.lbl_EdoCivil.Location = new System.Drawing.Point(9, 290);
            this.lbl_EdoCivil.Name = "lbl_EdoCivil";
            this.lbl_EdoCivil.Size = new System.Drawing.Size(45, 13);
            this.lbl_EdoCivil.TabIndex = 3;
            this.lbl_EdoCivil.Text = "EdoCivil";
            // 
            // TxtNombreC
            // 
            this.TxtNombreC.Location = new System.Drawing.Point(118, 9);
            this.TxtNombreC.Name = "TxtNombreC";
            this.TxtNombreC.Size = new System.Drawing.Size(192, 20);
            this.TxtNombreC.TabIndex = 4;
            this.TxtNombreC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombreC_KeyPress);
            // 
            // lbl_nombreCompleto
            // 
            this.lbl_nombreCompleto.AutoSize = true;
            this.lbl_nombreCompleto.Location = new System.Drawing.Point(9, 9);
            this.lbl_nombreCompleto.Name = "lbl_nombreCompleto";
            this.lbl_nombreCompleto.Size = new System.Drawing.Size(91, 13);
            this.lbl_nombreCompleto.TabIndex = 5;
            this.lbl_nombreCompleto.Text = "Nombre Completo";
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.Location = new System.Drawing.Point(118, 155);
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(257, 20);
            this.TxtDireccion.TabIndex = 6;
            // 
            // lbl_direccion
            // 
            this.lbl_direccion.AutoSize = true;
            this.lbl_direccion.Location = new System.Drawing.Point(9, 155);
            this.lbl_direccion.Name = "lbl_direccion";
            this.lbl_direccion.Size = new System.Drawing.Size(52, 13);
            this.lbl_direccion.TabIndex = 7;
            this.lbl_direccion.Text = "Direccion";
            // 
            // TxtTelefonoFijo
            // 
            this.TxtTelefonoFijo.Location = new System.Drawing.Point(118, 246);
            this.TxtTelefonoFijo.Name = "TxtTelefonoFijo";
            this.TxtTelefonoFijo.Size = new System.Drawing.Size(121, 20);
            this.TxtTelefonoFijo.TabIndex = 8;
            this.TxtTelefonoFijo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTelefonoFijo_KeyPress);
            // 
            // lbl_telefonoFijo
            // 
            this.lbl_telefonoFijo.AutoSize = true;
            this.lbl_telefonoFijo.Location = new System.Drawing.Point(9, 246);
            this.lbl_telefonoFijo.Name = "lbl_telefonoFijo";
            this.lbl_telefonoFijo.Size = new System.Drawing.Size(68, 13);
            this.lbl_telefonoFijo.TabIndex = 9;
            this.lbl_telefonoFijo.Text = "Telefono Fijo";
            // 
            // TxtCelular
            // 
            this.TxtCelular.Location = new System.Drawing.Point(118, 201);
            this.TxtCelular.Name = "TxtCelular";
            this.TxtCelular.Size = new System.Drawing.Size(121, 20);
            this.TxtCelular.TabIndex = 10;
            this.TxtCelular.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCelular_KeyPress);
            // 
            // lbl_celular
            // 
            this.lbl_celular.AutoSize = true;
            this.lbl_celular.Location = new System.Drawing.Point(9, 201);
            this.lbl_celular.Name = "lbl_celular";
            this.lbl_celular.Size = new System.Drawing.Size(39, 13);
            this.lbl_celular.TabIndex = 11;
            this.lbl_celular.Text = "Celular";
            // 
            // TxtEdad
            // 
            this.TxtEdad.Location = new System.Drawing.Point(118, 46);
            this.TxtEdad.Name = "TxtEdad";
            this.TxtEdad.Size = new System.Drawing.Size(39, 20);
            this.TxtEdad.TabIndex = 12;
            this.TxtEdad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtEdad_KeyPress);
            // 
            // lbl_edad
            // 
            this.lbl_edad.AutoSize = true;
            this.lbl_edad.Location = new System.Drawing.Point(9, 49);
            this.lbl_edad.Name = "lbl_edad";
            this.lbl_edad.Size = new System.Drawing.Size(32, 13);
            this.lbl_edad.TabIndex = 13;
            this.lbl_edad.Text = "Edad";
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(118, 103);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(148, 20);
            this.TxtEmail.TabIndex = 14;
            this.TxtEmail.Leave += new System.EventHandler(this.TxtEmail_Leave);
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(9, 103);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(32, 13);
            this.lbl_email.TabIndex = 15;
            this.lbl_email.Text = "Email";
            // 
            // btn_conectar
            // 
            this.btn_conectar.Location = new System.Drawing.Point(12, 401);
            this.btn_conectar.Name = "btn_conectar";
            this.btn_conectar.Size = new System.Drawing.Size(135, 37);
            this.btn_conectar.TabIndex = 18;
            this.btn_conectar.Text = "Conectar";
            this.btn_conectar.UseVisualStyleBackColor = true;
            this.btn_conectar.Click += new System.EventHandler(this.btn_conectar_Click);
            // 
            // lbl_medicos
            // 
            this.lbl_medicos.AutoSize = true;
            this.lbl_medicos.Location = new System.Drawing.Point(9, 338);
            this.lbl_medicos.Name = "lbl_medicos";
            this.lbl_medicos.Size = new System.Drawing.Size(47, 13);
            this.lbl_medicos.TabIndex = 19;
            this.lbl_medicos.Text = "Medicos";
            // 
            // CbxMedicos
            // 
            this.CbxMedicos.FormattingEnabled = true;
            this.CbxMedicos.Location = new System.Drawing.Point(118, 338);
            this.CbxMedicos.Name = "CbxMedicos";
            this.CbxMedicos.Size = new System.Drawing.Size(146, 21);
            this.CbxMedicos.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(552, 449);
            this.Controls.Add(this.CbxMedicos);
            this.Controls.Add(this.lbl_medicos);
            this.Controls.Add(this.btn_conectar);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.lbl_edad);
            this.Controls.Add(this.TxtEdad);
            this.Controls.Add(this.lbl_celular);
            this.Controls.Add(this.TxtCelular);
            this.Controls.Add(this.lbl_telefonoFijo);
            this.Controls.Add(this.TxtTelefonoFijo);
            this.Controls.Add(this.lbl_direccion);
            this.Controls.Add(this.TxtDireccion);
            this.Controls.Add(this.lbl_nombreCompleto);
            this.Controls.Add(this.TxtNombreC);
            this.Controls.Add(this.lbl_EdoCivil);
            this.Controls.Add(this.CbxEdoCivil);
            this.Controls.Add(this.RbdSexo);
            this.Controls.Add(this.Guardar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.RbdSexo.ResumeLayout(false);
            this.RbdSexo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.GroupBox RbdSexo;
        private System.Windows.Forms.RadioButton RbdSexoF;
        private System.Windows.Forms.RadioButton RbdSexoM;
        private System.Windows.Forms.ComboBox CbxEdoCivil;
        private System.Windows.Forms.Label lbl_EdoCivil;
        private System.Windows.Forms.TextBox TxtNombreC;
        private System.Windows.Forms.Label lbl_nombreCompleto;
        private System.Windows.Forms.TextBox TxtDireccion;
        private System.Windows.Forms.Label lbl_direccion;
        private System.Windows.Forms.TextBox TxtTelefonoFijo;
        private System.Windows.Forms.Label lbl_telefonoFijo;
        private System.Windows.Forms.TextBox TxtCelular;
        private System.Windows.Forms.Label lbl_celular;
        private System.Windows.Forms.TextBox TxtEdad;
        private System.Windows.Forms.Label lbl_edad;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Button btn_conectar;
        private System.Windows.Forms.Label lbl_medicos;
        private System.Windows.Forms.ComboBox CbxMedicos;
    }
}

