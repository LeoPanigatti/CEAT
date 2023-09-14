namespace ProyectCeat
{
    partial class frmInscribirAlumno
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpFechadeemision = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbDistrito = new System.Windows.Forms.ComboBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtGrado = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.rdbProv = new System.Windows.Forms.RadioButton();
            this.rdbNac = new System.Windows.Forms.RadioButton();
            this.rdbPriv = new System.Windows.Forms.RadioButton();
            this.ckbMismaescuela = new System.Windows.Forms.CheckBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtAceptar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(6, 60);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 26);
            this.txtName.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.ckbMismaescuela);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtDni);
            this.groupBox1.Controls.Add(this.txtApellido);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(464, 264);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Del Alumno";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(6, 126);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 26);
            this.txtApellido.TabIndex = 2;
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(6, 204);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(100, 26);
            this.txtDni.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Apellido:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "DNI:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(203, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Fecha de Nacimiento:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbPriv);
            this.groupBox2.Controls.Add(this.rdbNac);
            this.groupBox2.Controls.Add(this.rdbProv);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtGrado);
            this.groupBox2.Controls.Add(this.txtNumero);
            this.groupBox2.Controls.Add(this.cmbDistrito);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.dtpFechadeemision);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(12, 282);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(464, 242);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Escuela:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Fecha De Emision:";
            // 
            // dtpFechadeemision
            // 
            this.dtpFechadeemision.Location = new System.Drawing.Point(177, 52);
            this.dtpFechadeemision.Name = "dtpFechadeemision";
            this.dtpFechadeemision.Size = new System.Drawing.Size(200, 26);
            this.dtpFechadeemision.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(86, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Distrito:";
            // 
            // cmbDistrito
            // 
            this.cmbDistrito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDistrito.FormattingEnabled = true;
            this.cmbDistrito.Location = new System.Drawing.Point(177, 86);
            this.cmbDistrito.Name = "cmbDistrito";
            this.cmbDistrito.Size = new System.Drawing.Size(121, 28);
            this.cmbDistrito.TabIndex = 15;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(177, 120);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(121, 26);
            this.txtNumero.TabIndex = 16;
            // 
            // txtGrado
            // 
            this.txtGrado.Location = new System.Drawing.Point(177, 196);
            this.txtGrado.Name = "txtGrado";
            this.txtGrado.Size = new System.Drawing.Size(121, 26);
            this.txtGrado.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(86, 126);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "Número:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(86, 202);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 20);
            this.label10.TabIndex = 19;
            this.label10.Text = "Grado:";
            // 
            // rdbProv
            // 
            this.rdbProv.AutoSize = true;
            this.rdbProv.Location = new System.Drawing.Point(177, 157);
            this.rdbProv.Name = "rdbProv";
            this.rdbProv.Size = new System.Drawing.Size(69, 24);
            this.rdbProv.TabIndex = 20;
            this.rdbProv.TabStop = true;
            this.rdbProv.Text = "Prov.";
            this.rdbProv.UseVisualStyleBackColor = true;
            // 
            // rdbNac
            // 
            this.rdbNac.AutoSize = true;
            this.rdbNac.Location = new System.Drawing.Point(262, 157);
            this.rdbNac.Name = "rdbNac";
            this.rdbNac.Size = new System.Drawing.Size(66, 24);
            this.rdbNac.TabIndex = 21;
            this.rdbNac.TabStop = true;
            this.rdbNac.Text = "Nac.";
            this.rdbNac.UseVisualStyleBackColor = true;
            // 
            // rdbPriv
            // 
            this.rdbPriv.AutoSize = true;
            this.rdbPriv.Location = new System.Drawing.Point(346, 157);
            this.rdbPriv.Name = "rdbPriv";
            this.rdbPriv.Size = new System.Drawing.Size(63, 24);
            this.rdbPriv.TabIndex = 22;
            this.rdbPriv.TabStop = true;
            this.rdbPriv.Text = "Priv.";
            this.rdbPriv.UseVisualStyleBackColor = true;
            // 
            // ckbMismaescuela
            // 
            this.ckbMismaescuela.AutoSize = true;
            this.ckbMismaescuela.Location = new System.Drawing.Point(207, 129);
            this.ckbMismaescuela.Name = "ckbMismaescuela";
            this.ckbMismaescuela.Size = new System.Drawing.Size(217, 24);
            this.ckbMismaescuela.TabIndex = 12;
            this.ckbMismaescuela.Text = "Procede De Esta Escuela";
            this.ckbMismaescuela.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(207, 60);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // txtAceptar
            // 
            this.txtAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.txtAceptar.Location = new System.Drawing.Point(292, 547);
            this.txtAceptar.Name = "txtAceptar";
            this.txtAceptar.Size = new System.Drawing.Size(184, 34);
            this.txtAceptar.TabIndex = 13;
            this.txtAceptar.Text = "Aceptar";
            this.txtAceptar.UseVisualStyleBackColor = false;
            // 
            // frmInscribirAlumno
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(491, 609);
            this.Controls.Add(this.txtAceptar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmInscribirAlumno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "frmInscribirAlumno";
            this.Load += new System.EventHandler(this.frmInscribirAlumno_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbDistrito;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpFechadeemision;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtGrado;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.RadioButton rdbPriv;
        private System.Windows.Forms.RadioButton rdbNac;
        private System.Windows.Forms.RadioButton rdbProv;
        private System.Windows.Forms.CheckBox ckbMismaescuela;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button txtAceptar;
    }
}