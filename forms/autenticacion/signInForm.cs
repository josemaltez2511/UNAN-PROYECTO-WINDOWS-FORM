using System;
using System.Windows.Forms;

namespace SanarRuralProyectoUnan.forms
{
    public partial class signInForm : Form
    {
        // Variable para guardar la ventana de login original
        private Form _ventanaLogin;

        // Modificamos el constructor para recibir el form de login
        public signInForm(Form ventanaLogin)
        {
            InitializeComponent();
            _ventanaLogin = ventanaLogin; // Guardamos la referencia para usarla en los botones
        }

        // EVENTO: Botón Crear Usuario
        private void botonCrearUsuario_Click(object sender, EventArgs e)
        {
            // (En el siguiente paso conectaremos esto al servicio de autenticacion para guardar los datos reales)

            // 1. Mostrar cajita de éxito
            MessageBox.Show("Usuario creado exitosamente.", "Registro Completo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // 2. Regresar al Login si todo salió bien
            _ventanaLogin.Show(); // Volvemos a mostrar el login que estaba oculto
            this.Close(); // Cerramos esta ventana de registro para liberar memoria
        }

        // EVENTO: Botón Cancelar (Asegúrate de haberle dado doble clic en el diseño visual)
        private void botonCancelar_Click(object sender, EventArgs e)
        {
            // Regresamos al Login sin mostrar ningún mensaje
            _ventanaLogin.Show();
            this.Close();
        }

        // Eventos vacíos
        private void label1_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void txtNombreRegistro_TextChanged(object sender, EventArgs e) { }

        private void signInForm_Load(object sender, EventArgs e)
        {

        }

        private void tablaPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}