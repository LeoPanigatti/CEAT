namespace ProyectCeat
{
    partial class frmRA
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
            this.dgvRA = new System.Windows.Forms.DataGridView();
            this.rdbMatriculado = new System.Windows.Forms.RadioButton();
            this.rdbRegimen = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRA)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRA
            // 
            this.dgvRA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRA.Location = new System.Drawing.Point(12, 90);
            this.dgvRA.Name = "dgvRA";
            this.dgvRA.RowHeadersWidth = 62;
            this.dgvRA.RowTemplate.Height = 28;
            this.dgvRA.Size = new System.Drawing.Size(776, 478);
            this.dgvRA.TabIndex = 0;
            // 
            // rdbMatriculado
            // 
            this.rdbMatriculado.AutoSize = true;
            this.rdbMatriculado.Location = new System.Drawing.Point(23, 39);
            this.rdbMatriculado.Name = "rdbMatriculado";
            this.rdbMatriculado.Size = new System.Drawing.Size(124, 24);
            this.rdbMatriculado.TabIndex = 1;
            this.rdbMatriculado.TabStop = true;
            this.rdbMatriculado.Text = "Matriculados";
            this.rdbMatriculado.UseVisualStyleBackColor = true;
            // 
            // rdbRegimen
            // 
            this.rdbRegimen.AutoSize = true;
            this.rdbRegimen.Location = new System.Drawing.Point(211, 39);
            this.rdbRegimen.Name = "rdbRegimen";
            this.rdbRegimen.Size = new System.Drawing.Size(183, 24);
            this.rdbRegimen.TabIndex = 2;
            this.rdbRegimen.TabStop = true;
            this.rdbRegimen.Text = "Alumno por Regimen";
            this.rdbRegimen.UseVisualStyleBackColor = true;
            // 
            // frmRA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 580);
            this.Controls.Add(this.rdbRegimen);
            this.Controls.Add(this.rdbMatriculado);
            this.Controls.Add(this.dgvRA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRA";
            this.Text = "frmInfoAlumno";
            this.Load += new System.EventHandler(this.frmRA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRA;
        private System.Windows.Forms.RadioButton rdbMatriculado;
        private System.Windows.Forms.RadioButton rdbRegimen;
    }
}