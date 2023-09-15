using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectCeat
{
    
    public partial class frmLogin: Form
    {
        
        
        public frmLogin(frmPrincipal formulario)
        {
            InitializeComponent();
            
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(3, 36, 79);

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "admin") 
            {
                
                if(txtContra.Text == "admin") 
                {
                    frmPrincipal frmP = Application.OpenForms.OfType<frmPrincipal>().FirstOrDefault();
                    frmP.sesion = true;
                    frmP.iniciarsesion();
                    this.Close(); 
                }
                else
                {
                    MessageBox.Show("Contraseña Incorrecta");
                }
            }
            else
            {
                MessageBox.Show("Usuario Incorrecto");
            }
        }
    }
}
