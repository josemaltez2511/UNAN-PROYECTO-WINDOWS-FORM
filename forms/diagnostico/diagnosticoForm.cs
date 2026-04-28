using System;
using System.Windows.Forms;
using SanarRuralProyectoUnan.Modulos;
using SanarRuralProyectoUnan.forms.citas; // Para abrir la agenda

namespace SanarRuralProyectoUnan.forms.diagnostico
{
    public partial class diagnosticoForm : Form
    {
        private Paciente _pacienteSesion;
        private Form _menuPadre;
        private EnfermedadService _enfermoService = new EnfermedadService();

        public diagnosticoForm(Paciente paciente, Form menu)
        {
            InitializeComponent();
            _pacienteSesion = paciente;
            _menuPadre = menu;
        }

        private void btnAnalizar_Click(object sender, EventArgs e)
        {
            // 1. Llamamos al servicio para que analice lo que escribió el usuario
            string diagnostico = _enfermoService.ObtenerDiagnostico(txtEntradaSintomas.Text);

            // 2. Mostramos el resultado en el label
            lblResultado.Text = diagnostico;

            // 3. Si se identificó algo, mostramos el botón de ir a agendar cita
            if (diagnostico.Contains("Diagnóstico:"))
            {
                btnIrACita.Visible = true;
            }
        }

        private void btnIrACita_Click(object sender, EventArgs e)
        {
            // Abrimos la ventana de citas que ya creamos antes
            agendarCitaForm cita = new agendarCitaForm(_pacienteSesion, _menuPadre);
            cita.Show();
            this.Close(); // Cerramos esta ventana
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            _menuPadre.Show();
            this.Close();
        }
    }
}