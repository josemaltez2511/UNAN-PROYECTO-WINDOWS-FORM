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
        // ¿Qué es un evento?: Es una acción que "dispara" el código cuando el usuario hace clic.
        private void botonIniciarSesion_Click(object sender, EventArgs e)
        {
            // CAPTURA DE DATOS:
            // Guardamos en variables tipo string (texto) lo que el usuario escribió en las cajitas blancas.
            // Atrapamos lo que el usuario escribió
            string usuario = textBoxUsuario.Text;
            string contra = textBoxContraseña.Text;

            // PROCESO DE VERIFICACIÓN (Llamada al "Cerebro"):
            // Usamos nuestro servicio de autenticación para que busque en la "base de datos" (el array).
            // Si lo encuentra, nos devuelve un objeto 'Paciente' con todos sus datos.
            // Llamamos a nuestro servicio para verificar si existe
            Paciente pacienteEncontrado = miServicioAuth.Login(usuario, contra);

            // TOMA DE DECISIONES:
            // 'null' significa vacío. Si NO es null, significa que el paciente sí existe.
            // Verificamos la respuesta
            if (pacienteEncontrado != null)
            {
                // Damos una respuesta visual de éxito.
                MessageBox.Show("¡Bienvenido a Sanar Rural, " + pacienteEncontrado.Nombre + "!", "Ingreso Exitoso");

                // NAVEGACIÓN ENTRE VENTANAS:

                // Ocultamos el Login
                // 1. Ocultamos la ventana de Login (this.Hide). 
                // ¿Por qué Hide y no Close?: Porque si cerramos el Login, se apaga todo el programa.
                this.Hide();

                // 2. CREACIÓN DEL MENÚ PRINCIPAL:
                // Aquí ocurre la "magia". Al poner 'this' en los paréntesis, le estamos entregando 
                // al menú la "llave" de esta ventana de Login. 
                // Así, el menú sabrá a qué ventana debe llamar cuando cerremos sesión.
                // Abrimos el Menú Principal y le pasamos el paciente para que lo conozca
                menuForm formMenu = new menuForm(pacienteEncontrado, this);

                // Sincronizamos el tamaño: Si el Login estaba en pantalla completa, el Menú también abrirá así.
                formMenu.WindowState = this.WindowState;

                // Mostramos la nueva ventana.
                formMenu.Show();
            }
            else
            {
                // Si el servicio (la logica) nos devolvió 'null', mostramos un error con icono de advertencia.
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