using System;
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
    public partial class frmRA : Form
    {
        public frmRA(frmPrincipal formulario)
        {
            InitializeComponent();
        }

        private void frmRA_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            
            List<TextBox> textBoxes = new List<TextBox>
    {
        textBox2, textBox3, textBox5 ,textBox7, textBox9, textBox11, textBox13, textBox15, textBox17, /* Agrega más TextBox según sea necesario */
    };
            int suma = 0;

            foreach (TextBox textBox in textBoxes)
            {
                // Verifica si el TextBox contiene un número válido y súmalo a la suma total
                if (int.TryParse(textBox.Text, out int numero))
                {
                    suma += numero;
                }
                else
                {
                    // Si el TextBox no contiene un número válido, muestra un mensaje de error
                    MessageBox.Show($"Por favor, ingrese un número válido en {textBox.Name}.");
                    return; // Detiene el proceso si hay un error
                }
            }

            // Muestra la suma total en un Label o donde desees mostrar el resultado
            lblTotalVaron.Text = suma.ToString();

            List<TextBox> textBoxes2 = new List<TextBox>
            {
                textBox1, textBox4, textBox6, textBox8, textBox10, textBox12, textBox14, textBox16, textBox18
            };

            int suma2 = 0;

            foreach (TextBox textBox in textBoxes2)
            {
                // Verifica si el TextBox contiene un número válido y súmalo a la suma total
                if (int.TryParse(textBox.Text, out int numero))
                {
                    suma2 += numero;
                }
                else
                {
                    // Si el TextBox no contiene un número válido, muestra un mensaje de error
                    MessageBox.Show($"Por favor, ingrese un número válido en {textBox.Name}.");
                    return; // Detiene el proceso si hay un error
                }
            }


            // Muestra la suma total en el segundo Label
            lblTotalMujer.Text = suma2.ToString();

         
        }
    
    }
}
