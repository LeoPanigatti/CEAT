namespace ProyectCeat
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.pnlBotonera = new System.Windows.Forms.Panel();
            this.darkModeButton = new System.Windows.Forms.Button();
            this.btnConsultas = new System.Windows.Forms.Button();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btbRA = new System.Windows.Forms.Button();
            this.btnInscripcion = new System.Windows.Forms.Button();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.lightModeButton = new System.Windows.Forms.Button();
            this.pnlBotonera.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBotonera
            // 
            this.pnlBotonera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlBotonera.Controls.Add(this.lightModeButton);
            this.pnlBotonera.Controls.Add(this.darkModeButton);
            this.pnlBotonera.Controls.Add(this.btnConsultas);
            this.pnlBotonera.Controls.Add(this.btnIniciar);
            this.pnlBotonera.Controls.Add(this.btbRA);
            this.pnlBotonera.Controls.Add(this.btnInscripcion);
            this.pnlBotonera.Location = new System.Drawing.Point(0, 0);
            this.pnlBotonera.Margin = new System.Windows.Forms.Padding(2);
            this.pnlBotonera.Name = "pnlBotonera";
            this.pnlBotonera.Size = new System.Drawing.Size(133, 336);
            this.pnlBotonera.TabIndex = 1;
            // 
            // darkModeButton
            // 
            this.darkModeButton.BackColor = System.Drawing.Color.Gray;
            this.darkModeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.darkModeButton.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.darkModeButton.ForeColor = System.Drawing.SystemColors.MenuText;
            this.darkModeButton.Image = ((System.Drawing.Image)(resources.GetObject("darkModeButton.Image")));
            this.darkModeButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.darkModeButton.Location = new System.Drawing.Point(11, 218);
            this.darkModeButton.Margin = new System.Windows.Forms.Padding(2);
            this.darkModeButton.Name = "darkModeButton";
            this.darkModeButton.Size = new System.Drawing.Size(51, 54);
            this.darkModeButton.TabIndex = 5;
            this.darkModeButton.UseVisualStyleBackColor = false;
            this.darkModeButton.Click += new System.EventHandler(this.darkModeButton_Click);
            // 
            // btnConsultas
            // 
            this.btnConsultas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnConsultas.Enabled = false;
            this.btnConsultas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConsultas.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultas.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnConsultas.Location = new System.Drawing.Point(2, 40);
            this.btnConsultas.Margin = new System.Windows.Forms.Padding(2);
            this.btnConsultas.Name = "btnConsultas";
            this.btnConsultas.Size = new System.Drawing.Size(129, 34);
            this.btnConsultas.TabIndex = 2;
            this.btnConsultas.Text = "Consultas";
            this.btnConsultas.UseVisualStyleBackColor = false;
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnIniciar.Location = new System.Drawing.Point(2, 2);
            this.btnIniciar.Margin = new System.Windows.Forms.Padding(2);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(129, 34);
            this.btnIniciar.TabIndex = 3;
            this.btnIniciar.Text = "Iniciar Sesión";
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // btbRA
            // 
            this.btbRA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btbRA.Enabled = false;
            this.btbRA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btbRA.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbRA.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btbRA.Location = new System.Drawing.Point(2, 112);
            this.btbRA.Margin = new System.Windows.Forms.Padding(2);
            this.btbRA.Name = "btbRA";
            this.btbRA.Size = new System.Drawing.Size(129, 34);
            this.btbRA.TabIndex = 1;
            this.btbRA.Text = "R.A";
            this.btbRA.UseVisualStyleBackColor = false;
            this.btbRA.Click += new System.EventHandler(this.btbRA_Click);
            // 
            // btnInscripcion
            // 
            this.btnInscripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnInscripcion.Enabled = false;
            this.btnInscripcion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInscripcion.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInscripcion.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnInscripcion.Location = new System.Drawing.Point(2, 77);
            this.btnInscripcion.Margin = new System.Windows.Forms.Padding(2);
            this.btnInscripcion.Name = "btnInscripcion";
            this.btnInscripcion.Size = new System.Drawing.Size(129, 31);
            this.btnInscripcion.TabIndex = 0;
            this.btnInscripcion.Text = "Inscripción";
            this.btnInscripcion.UseVisualStyleBackColor = false;
            this.btnInscripcion.Click += new System.EventHandler(this.btnInscripcion_Click);
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.AutoScroll = true;
            this.pnlContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlContenedor.Location = new System.Drawing.Point(135, 0);
            this.pnlContenedor.Margin = new System.Windows.Forms.Padding(2);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(534, 336);
            this.pnlContenedor.TabIndex = 2;
            // 
            // lightModeButton
            // 
            this.lightModeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lightModeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lightModeButton.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lightModeButton.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lightModeButton.Image = ((System.Drawing.Image)(resources.GetObject("lightModeButton.Image")));
            this.lightModeButton.Location = new System.Drawing.Point(66, 218);
            this.lightModeButton.Margin = new System.Windows.Forms.Padding(2);
            this.lightModeButton.Name = "lightModeButton";
            this.lightModeButton.Size = new System.Drawing.Size(49, 54);
            this.lightModeButton.TabIndex = 6;
            this.lightModeButton.UseVisualStyleBackColor = false;
            this.lightModeButton.Click += new System.EventHandler(this.lightModeButton_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 343);
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.pnlBotonera);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(690, 382);
            this.MinimumSize = new System.Drawing.Size(690, 382);
            this.Name = "frmPrincipal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.pnlBotonera.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBotonera;
        private System.Windows.Forms.Button btnInscripcion;
        private System.Windows.Forms.Panel pnlContenedor;
        private System.Windows.Forms.Button btbRA;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnConsultas;
        private System.Windows.Forms.Button darkModeButton;
        private System.Windows.Forms.Button lightModeButton;
    }
}

