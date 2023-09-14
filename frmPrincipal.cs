﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectCeat
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnInscripcion_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmInscribirAlumno(this));
        }
        public void AbrirFormulario (Form formulario) //metodo para abrir formulario en el panel contenedor
        {
            pnlContenedor.Controls.Clear(); //limpiamos el panel para abrir un nuevo formulario, para que no se abra uno arriba del otro, aunque tenga uno ahora.
            Form fh = formulario as Form; //creamos un objeto formulario y le asignamos el formulario que deseamos abrir.
            fh.TopLevel = false; 
            fh.Dock = DockStyle.Fill; // ajustamo el tamaño del formulario que vamos a abrir al tamaño del panel
            pnlContenedor.Controls.Add(fh); //agregamos el formulario al panel 
            fh.Show();// mostramos el formulario.
        }

        private void btbRA_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmRA(this));
        }
    }
}