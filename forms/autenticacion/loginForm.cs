using SanarRuralProyectoUnan.forms;
using SanarRuralProyectoUnan.Modulos; // Conectamos con el archivo servicioAutenticacion.cs para usar lo que tenemos ahi
using System;
using System.Windows.Forms;

namespace SanarRuralProyectoUnan
{
    public partial class loginForm : Form
    {
        // 1. Instanciamos el servicio a nivel de la clase para poder usarlo en todos los botones
        AuthService miServicioAuth = new AuthService();

        public loginForm()
        {
            InitializeComponent();
        }

        // 2. El evento del botón "Iniciar Sesión"
        private void botonIniciarSesion_Click(object sender, EventArgs e)
        {
            // Atrapamos lo que el usuario escribió
            string usuario = textBoxUsuario.Text;
            string contra = textBoxContraseña.Text;

            // Llamamos a nuestro servicio para verificar si existe
            Paciente pacienteEncontrado = miServicioAuth.Login(usuario, contra);

            // Verificamos la respuesta
            if (pacienteEncontrado != null)
            {
                MessageBox.Show("¡Bienvenido a Sanar Rural, " + pacienteEncontrado.Nombre + "!", "Ingreso Exitoso");

                // 1. Ocultamos el Login
                this.Hide();

                // 2. Abrimos el Menú Principal y le pasamos el paciente para que lo conozca
                menuForm formMenu = new menuForm(pacienteEncontrado);
                formMenu.Show();
            }
            else
            {
                MessageBox.Show("El correo o contraseña no son correctos. Inténtalo de nuevo.", "Error de Acceso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 3. El evento del enlace "Crear Cuenta"
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Ocultamos esta ventana de Login
            this.Hide();

            // Abrimos la ventana de registro y le pasamos 'this' (esta misma ventana) 
            // para que el signInForm sepa a dónde regresar cuando termine.
            signInForm ventanaRegistro = new signInForm(this);
            ventanaRegistro.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void loginForm_Load(object sender, EventArgs e)
        {

        }
    }
}