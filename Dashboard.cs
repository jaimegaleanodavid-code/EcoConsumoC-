using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EcoConsumoAppC_
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void lblNombreUsuarioHeader_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMenuCerrarSesion_Click(object sender, EventArgs e)
        {
            // Muestra la ventana de confirmación
            DialogResult resultado = MessageBox.Show(
                "¿Está seguro de que desea cerrar la sesión actual?",
                "Cerrar Sesión",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            // Si el usuario presiona "Sí"
            if (resultado == DialogResult.Yes)
            {
                // 1. Instancia nuevamente formulario de Login

                Form1 login = new Form1();
                login.Show();

                // 2. Cierra el Dashboard actual
                this.Close();
            }
            // Si presiona "No", el código no hace nada y el usuario se queda en el Dashboard
        }
    }
}
