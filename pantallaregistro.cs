using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EcoConsumoAppC_
{
    public partial class pantallaregistro : Form
    {
        public pantallaregistro()
        {
            InitializeComponent();

            
            this.AcceptButton = btncrearcuenta;
        }

        private void pantallaregistro_Load(object sender, EventArgs e)
        {
            
            txtcontrasenausuario.UseSystemPasswordChar = true;
            txtconfirmarcontrasenausuario.UseSystemPasswordChar = true;
        }

        
        private void btncrearcuenta_Click(object sender, EventArgs e)
        {

        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = txtnombreusuario.Text.Trim();
            string usuario = txtusuariousuario.Text.Trim();
            string correo = txtcorreousuario.Text.Trim();
            string pass1 = txtcontrasenausuario.Text;
            string pass2 = txtconfirmarcontrasenausuario.Text;


            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(usuario) ||
                string.IsNullOrEmpty(correo) || string.IsNullOrEmpty(pass1) || string.IsNullOrEmpty(pass2))
            {
                MessageBox.Show("Por favor, completa todos los campos para registrarte.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

          
            if (!Regex.IsMatch(nombre, @"^[a-zA-ZáéíóúÁÉÍÓÚñÑ\s]+$"))
            {
                MessageBox.Show("El nombre solo puede contener letras y espacios.", "Nombre inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

          
            if (!Regex.IsMatch(usuario, @"^[a-zA-Z0-9]+$"))
            {
                MessageBox.Show("El nombre de usuario solo debe incluir letras y números, sin espacios ni caracteres especiales.", "Usuario inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

          
            if (!Regex.IsMatch(correo, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Por favor, ingresa una dirección de correo electrónico válida.", "Correo inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            if (pass1 != pass2)
            {
                MessageBox.Show("Las contraseñas no coinciden. Por favor, verifícalas.", "Contraseñas no coinciden", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

           
            MessageBox.Show("¡Cuenta creada exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            
            Form1 login = new Form1();
            login.Show();
            this.Close();
        }

       
        private void label4_Click(object sender, EventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }
    }
}