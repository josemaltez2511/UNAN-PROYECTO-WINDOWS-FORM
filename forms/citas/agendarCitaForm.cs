using System;
using System.Windows.Forms;
using SanarRuralProyectoUnan.Modulos;

namespace SanarRuralProyectoUnan.forms.citas
{
    public partial class agendarCitaForm : Form
    {
        // 1. VARIABLES PARA GUARDAR LA SESIÓN
        // Necesitamos recordar quién es el paciente y cuál es la ventana del menú para volver.
        private Paciente _pacienteSesion;
        private Form _menuAnterior;
        private CitaService _citaService = new CitaService();

        // 2. CONSTRUCTOR: El "taller" donde se construye esta ventana
        public agendarCitaForm(Paciente paciente, Form menu)
        {
            InitializeComponent();
            _pacienteSesion = paciente; // Guardamos al paciente
            _menuAnterior = menu;       // Guardamos el menú original
        }

        // 3. BOTÓN GUARDAR: Captura los datos y registra la cita
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Extraemos los datos de los controles visuales
            string motivo = txtMotivo.Text;
            string fecha = dtpFecha.Value.ToShortDateString();

            // Enviamos los datos al servicio para que los guarde en el Array
            string resultado = _citaService.RegistrarCita(_pacienteSesion.Id, fecha, motivo);

            // 4. FEEDBACK Y REDIRECCIÓN (Lo que pediste)
            // Si el servicio nos responde con éxito:
            if (resultado == "Cita registrada con éxito.")
            {
                // Mostramos la cajita con el botón de Aceptar
                MessageBox.Show("¡Cita registrada con éxito!", "Sanar Rural", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // IMPORTANTE: Al darle clic en "Aceptar" en el mensaje de arriba, 
                // el código sigue aquí abajo y hace la redirección:

                _menuAnterior.Show(); // Volvemos a mostrar el Menú Principal
                this.Close();        // Cerramos esta ventana de citas
            }
            else
            {
                // Si hubo algún error (como fecha pasada), lo mostramos aquí
                MessageBox.Show(resultado, "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // 5. BOTÓN REGRESAR: Por si el usuario no quiere agendar nada
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            _menuAnterior.Show(); // Mostramos el menú que estaba oculto
            this.Close();        // Cerramos la ventana actual
        }

        private void agendarCitaForm_Load(object sender, EventArgs e)
        {
            // Aquí puedes poner lógica que ocurra apenas cargue la ventana si quieres
        }

        private void agendarCitaForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}