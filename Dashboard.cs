using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
            
            DialogResult resultado = MessageBox.Show(
                "¿Está seguro de que desea cerrar la sesión actual?",
                "Cerrar Sesión",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

           
            if (resultado == DialogResult.Yes)
            {
                Form1 login = new Form1();
                login.Show();

                
                this.Close();
            }
            
        }

        private void chartConsumoSemanal_Click(object sender, EventArgs e)
        {

        }

        private void lblBodyTip_Click(object sender, EventArgs e)
        {

        }

        private void llblproyectogithub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                llblproyectogithub.LinkVisited = true;

                
                Process.Start(new ProcessStartInfo("https://github.com/jaimegaleanodavid-code/EcoConsumoC-.git") { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo abrir el enlace: " + ex.Message);
            }
        }
    }
}
