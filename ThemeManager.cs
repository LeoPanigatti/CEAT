using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectCeat
{
    public static class ThemeManager
    {
        public static void SetDarkMode(Control control)
        {
            control.BackColor = Color.FromArgb(31, 31, 31);
            control.ForeColor = Color.White;

            if (control is Button button)
            {
                button.FlatStyle = FlatStyle.Flat;
                button.FlatAppearance.BorderColor = Color.White;
                button.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 122, 204);
                button.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 102, 204);
            }

            foreach (Control childControl in control.Controls)
            {
                SetDarkMode(childControl); // aplicar el tema oscuro a los controles secundarios.
            }
        }

        public static void SetLightMode(Control control)
        {
            control.BackColor = SystemColors.Control;
            control.ForeColor = SystemColors.ControlText;

            if (control is Button button)
            {
                button.FlatStyle = FlatStyle.Standard;
            }

            foreach (Control childControl in control.Controls)
            {
                SetLightMode(childControl); // aplicar el tema claro a los controles secundarios.
            }
        }
    }
}