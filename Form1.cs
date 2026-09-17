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
    public partial class Form1 : Form
    {
        // Lista de frases ecológicas aleatorias
        private string[] frasesEcológicas = new string[]
        {
            "«La energía más eficiente es la que no necesita consumirse».",
            "«Si este mundo quieres conservar, la luz que no usas debes apagar».",
            "«Luz que apagas, luz que no pagas».",
            "«Aprovecha el día y ahorra energía».",
            "«Si quieres que tus hijos puedan heredar, el consumo de energía ya no puedes derrochar».",
            "«El ahorro es dinero: gasta en vacaciones y no en luz»."
        };

        public Form1()
        {
            InitializeComponent();

            // Asigna la tecla ENTER para ejecutar la acción de Iniciar Sesión
            this.AcceptButton = btniniciarsesion;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 03. Selecciona una frase aleatoria cada vez que se abre la aplicación
            Random rand = new Random();
            lblfrase.Text = frasesEcológicas[rand.Next(frasesEcológicas.Length)];

            // Estado inicial del campo de contraseña
            txtcontrasena.UseSystemPasswordChar = true;
        }

        // 02. Funcionalidad de Ocultar / Mostrar Contraseña
        private void chkOcultarPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtcontrasena.UseSystemPasswordChar = cbocultarcontrasena.Checked;
        }

        // 01. Validación de campos al presionar Iniciar Sesión
        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {

        }

        // Redirección al formulario de Registro
        private void btnregistrarse_Click(object sender, EventArgs e)
        {
            pantallaregistro Formulario = new pantallaregistro();
            Formulario.Show();
            this.Hide();
        }

        // Eventos vacíos del diseñador (se mantienen para evitar errores en Form1.Designer.cs)
        private void panelRedondeado2_Paint(object sender, PaintEventArgs e) { }
        private void label6_Click(object sender, EventArgs e) { }
        private void label8_Click(object sender, EventArgs e) { }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void btniniciarsesion_Click_1(object sender, EventArgs e)
        {
            string usuario = txtusuario.Text.Trim();
            string password = txtcontrasena.Text;

            // Validar que no haya campos vacíos
            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Por favor, completa todos los campos para ingresar.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar que no contenga caracteres especiales (solo letras, números, @ y .)
            if (!Regex.IsMatch(usuario, @"^[a-zA-Z0-9@.]+$"))
            {
                MessageBox.Show("El usuario/correo no debe contener caracteres especiales indebidos.", "Usuario inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Aquí tu compañero de SQL agregará la conexión a la Base de Datos
            MessageBox.Show("¡Validaciones correctas! Conectando...", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Dashboard Formulario = new Dashboard();
            Formulario.Show();
            this.Hide();
        }
    }
}