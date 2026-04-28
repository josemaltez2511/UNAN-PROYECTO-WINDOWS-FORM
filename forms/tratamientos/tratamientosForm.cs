using System;
using System.Windows.Forms;
using SanarRuralProyectoUnan.Modulos;

namespace SanarRuralProyectoUnan.forms.tratamientos
{
    public partial class tratamientosForm : Form
    {
        // 1. VARIABLES PARA LA NAVEGACIÓN Y DATOS
        private Paciente _pacienteSesion;
        private Form _menuPadre;
        private TratamientoService _servicio = new TratamientoService();

        // 2. CONSTRUCTOR
        public tratamientosForm(Paciente paciente, Form menu)
        {
            InitializeComponent();
            _pacienteSesion = paciente;
            _menuPadre = menu;

            // Apenas abre, mostramos lo que ya tiene el paciente
            ActualizarTabla();
        }

        // 3. BOTÓN GUARDAR
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Extraemos los datos de la pantalla
            string desc = txtDescripcion.Text;
            DateTime fInicio = dtpInicio.Value;
            DateTime fFin = dtpFin.Value;

            // Mandamos al servicio (Cerebro) a guardar en el Array
            string resultado = _servicio.RegistrarTratamiento(_pacienteSesion.Id, desc, fInicio, fFin);

            if (resultado == "EXITO")
            {
                MessageBox.Show("Tratamiento guardado correctamente.", "Éxito");
                txtDescripcion.Clear(); // Limpiamos para el siguiente
                ActualizarTabla();      // Refrescamos la tabla visual
            }
            else
            {
                MessageBox.Show(resultado, "Error");
            }
        }

        // 4. ACTUALIZAR TABLA (KISS)
        private void ActualizarTabla()
        {
            // Conectamos la tabla visual con los datos filtrados del servicio
            dgvTratamientos.DataSource = null;
            dgvTratamientos.DataSource = _servicio.ObtenerTratamientosPorPaciente(_pacienteSesion.Id);
            dgvTratamientos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        // 5. BOTÓN VOLVER
        private void btnVolver_Click(object sender, EventArgs e)
        {
            _menuPadre.Show(); // Mostramos el menú que escondimos
            this.Close();      // Cerramos esta ventana
        }

        private void tratamientosForm_Load(object sender, EventArgs e)
        {

        }

        private void dgvTratamientos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}