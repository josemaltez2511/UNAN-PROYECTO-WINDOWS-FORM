using SanarRuralProyectoUnan.forms.citas;
using SanarRuralProyectoUnan.forms.diagnostico;
using SanarRuralProyectoUnan.forms.tratamientos;
using SanarRuralProyectoUnan.Modulos; // Traemos el molde de Paciente y el Servicio de Citas
using System;
using System.Windows.Forms;

namespace SanarRuralProyectoUnan
{
    public partial class menuForm : Form
    {
        // =============================================================
        // VARIABLES GLOBALES (ESTADO DEL FORMULARIO)
        // =============================================================

        // Creamos una variable para guardar al paciente que entró al sistema.
        // La dejamos privada para que solo este formulario pueda verla (Encapsulamiento).
        private Paciente _pacienteSesion;

        // Instanciamos el servicio de citas para poder guardar y leer datos.
        private CitaService _citaService = new CitaService();

        // El Constructor: Es lo primero que corre cuando se crea esta ventana.
        // Recibe al 'paciente' que viene viajando desde el Login.
        public menuForm(Paciente paciente)
        {
            InitializeComponent(); // Función obligatoria que dibuja los botones.

            // Guardamos los datos del paciente en nuestra variable de arriba.
            _pacienteSesion = paciente;

            // Personalizamos el saludo de bienvenida.
            if (_pacienteSesion != null)
            {
                // Ponemos el nombre real del paciente en el Label que creamos.
                lblBienvenida.Text = "Hola, " + _pacienteSesion.Nombre;
            }
        }

        // =============================================================
        // EVENTOS DE LOS BOTONES (LÓGICA DE NAVEGACIÓN)
        // =============================================================

        // 1. BOTÓN: AGENDAR CITA
        private void btnAgendarCita_Click(object sender, EventArgs e)
        {
            // Usamos InputBox para pedir datos rápido sin crear más ventanas por ahora.
            // Es una forma sencilla de aprender cómo capturar datos.
            string motivo = Microsoft.VisualBasic.Interaction.InputBox("¿Cuál es el motivo de su cita?", "Agendar Cita");
            string fecha = Microsoft.VisualBasic.Interaction.InputBox("Ingrese fecha (Ej: 2026-10-10 09:00):", "Agendar Cita", DateTime.Now.ToString("yyyy-MM-dd HH:mm"));

            // Le enviamos los datos al 'CitaService' para que los procese y guarde.
            string resultado = _citaService.RegistrarCita(_pacienteSesion.Id, motivo, fecha);

            if (resultado == "EXITO")
            {
                MessageBox.Show("¡Su cita ha sido agendada con éxito!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Si algo salió mal (como la fecha mal escrita), mostramos el error.
                MessageBox.Show(resultado, "Error en el Registro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // 2. BOTÓN: VER MIS CITAS
        private void btnVerCitas_Click(object sender, EventArgs e)
        {
            this.Hide(); // Escondemos el menú
            verCitasForm ventanaVer = new verCitasForm(_pacienteSesion, this);
            ventanaVer.Show(); // Mostramos la tabla de citas
        }

        // 3. BOTÓN: CONSULTA DE SÍNTOMAS
        // ESTA FUNCIÓN ES LA QUE ARREGLA EL ERROR CS1061.
        private void btnSintomas_Click(object sender, EventArgs e)
        {
            this.Hide(); // Ocultamos el menú
                         // Abrimos el nuevo formulario de diagnóstico
            diagnosticoForm ventanaDiagnostico = new diagnosticoForm(_pacienteSesion, this);
            ventanaDiagnostico.Show();
        }

        // 4. BOTÓN: CERRAR SESIÓN
        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            // Mostramos una confirmación antes de salir.
            DialogResult respuesta = MessageBox.Show("¿Está seguro que desea cerrar su sesión?", "Cerrar Sesión", MessageBoxButtons.YesNo);

            if (respuesta == DialogResult.Yes)
            {
                // 'this.Close()' cierra esta ventana y vuelve al Login (que está oculto).
                this.Close();
            }
        }

        private void menuForm_Load(object sender, EventArgs e)
        {

        }

        private void btnTratamientos_Click(object sender, EventArgs e)
        {
            this.Hide(); // Escondemos el menú principal

            // Abrimos la nueva ventana de tratamientos
            // Le pasamos el paciente actual y 'this' (el menú) para que sepa volver
            tratamientosForm ventana = new tratamientosForm(_pacienteSesion, this);
            ventana.Show();
        }
    }
}