using System;
using System.Windows.Forms;
using SanarRuralProyectoUnan.Modulos;

namespace SanarRuralProyectoUnan.forms.tratamientos
{
    public partial class crearTratamientoForm : Form
    {
        // 1. VARIABLES PARA LA SESIÓN Y NAVEGACIÓN
        // Necesitamos saber quién es el paciente y qué ventana nos abrió para poder regresar.
        private Paciente _pacienteSesion;
        private Form _ventanaAnterior;
        private TratamientoService _servicio = new TratamientoService();

        // 2. CONSTRUCTOR: Se ejecuta al abrir la ventana
        public crearTratamientoForm(Paciente paciente, Form ventanaAnterior)
        {
            InitializeComponent();
            _pacienteSesion = paciente;    // Guardamos el paciente
            _ventanaAnterior = ventanaAnterior; // Guardamos la ventana previa
        }

        // 3. BOTÓN GUARDAR: Captura los datos y los envía al servicio
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Extraemos los textos de los cuadros de la pantalla
            string descripcion = txtDescripcion.Text;
            DateTime fechaInicio = dtpInicio.Value;
            DateTime fechaFin = dtpFin.Value;

            // Llamamos al servicio para que guarde en el Array
            string resultado = _servicio.RegistrarTratamiento(_pacienteSesion.Id, descripcion, fechaInicio, fechaFin);

            if (resultado == "EXITO")
            {
                // Si todo salió bien, damos feedback y regresamos
                MessageBox.Show("Tratamiento registrado con éxito.", "Sanar Rural", MessageBoxButtons.OK, MessageBoxIcon.Information);

                _ventanaAnterior.Show(); // Mostramos la ventana anterior
                this.Close();            // Cerramos esta
            }
            else
            {
                // Si el servicio detectó un error (ej. fecha fin menor a inicio) lo mostramos
                MessageBox.Show(resultado, "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // 4. BOTÓN CANCELAR: Regresa sin guardar nada
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            _ventanaAnterior.Show();
            this.Close();
        }

        private void crearTratamientoForm_Load(object sender, EventArgs e)
        {
            // Opcional: Alguna lógica al cargar la ventana
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}