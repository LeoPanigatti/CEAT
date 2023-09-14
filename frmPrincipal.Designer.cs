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
            this.pnlBotonera = new System.Windows.Forms.Panel();
            this.btnConsultas = new System.Windows.Forms.Button();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btbRA = new System.Windows.Forms.Button();
            this.btnInscripcion = new System.Windows.Forms.Button();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.pnlBotonera.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBotonera
            // 
            this.pnlBotonera.BackColor = System.Drawing.Color.White;
            this.pnlBotonera.Controls.Add(this.btnConsultas);
            this.pnlBotonera.Controls.Add(this.btnIniciar);
            this.pnlBotonera.Controls.Add(this.btbRA);
            this.pnlBotonera.Controls.Add(this.btnInscripcion);
            this.pnlBotonera.Location = new System.Drawing.Point(0, 0);
            this.pnlBotonera.Name = "pnlBotonera";
            this.pnlBotonera.Size = new System.Drawing.Size(200, 517);
            this.pnlBotonera.TabIndex = 1;
            // 
            // btnConsultas
            // 
            this.btnConsultas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnConsultas.Enabled = false;
            this.btnConsultas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConsultas.Location = new System.Drawing.Point(3, 3);
            this.btnConsultas.Name = "btnConsultas";
            this.btnConsultas.Size = new System.Drawing.Size(194, 52);
            this.btnConsultas.TabIndex = 2;
            this.btnConsultas.Text = "Consultas";
            this.btnConsultas.UseVisualStyleBackColor = false;
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIniciar.Location = new System.Drawing.Point(3, 172);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(194, 52);
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
            this.btbRA.Location = new System.Drawing.Point(3, 114);
            this.btbRA.Name = "btbRA";
            this.btbRA.Size = new System.Drawing.Size(194, 52);
            this.btbRA.TabIndex = 1;
            this.btbRA.Text = "Relevamiento Anual";
            this.btbRA.UseVisualStyleBackColor = false;
            this.btbRA.Click += new System.EventHandler(this.btbRA_Click);
            // 
            // btnInscripcion
            // 
            this.btnInscripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnInscripcion.Enabled = false;
            this.btnInscripcion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInscripcion.Location = new System.Drawing.Point(3, 61);
            this.btnInscripcion.Name = "btnInscripcion";
            this.btnInscripcion.Size = new System.Drawing.Size(194, 47);
            this.btnInscripcion.TabIndex = 0;
            this.btnInscripcion.Text = "Inscripción";
            this.btnInscripcion.UseVisualStyleBackColor = false;
            this.btnInscripcion.Click += new System.EventHandler(this.btnInscripcion_Click);
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.AutoScroll = true;
            this.pnlContenedor.BackColor = System.Drawing.Color.White;
            this.pnlContenedor.Location = new System.Drawing.Point(203, 0);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(801, 517);
            this.pnlContenedor.TabIndex = 2;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 511);
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.pnlBotonera);
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1027, 567);
            this.MinimumSize = new System.Drawing.Size(1027, 567);
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
    }
}

