using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SanarRuralProyectoUnan.Modulos;

namespace SanarRuralProyectoUnan.forms.citas
{
    public partial class verCitasForm : Form
    {
        // 1. VARIABLES PARA LA NAVEGACIÓN
        private Paciente _pacienteSesion; // Para saber qué citas buscar
        private Form _menuPadre;          // Para saber a qué ventana regresar
        private CitaService _citaService = new CitaService();

        // 2. CONSTRUCTOR
        public verCitasForm(Paciente paciente, Form menu)
        {
            InitializeComponent();
            _pacienteSesion = paciente;
            _menuPadre = menu;

            // Llamamos a nuestra función para llenar la tabla apenas cargue la ventana
            CargarCitasEnTabla();
        }

        // 3. FUNCIÓN PARA LLENAR LA TABLA (Lógica de Aprendizaje)
        private void CargarCitasEnTabla()
        {
            // ¿Cómo funciona?: Le pedimos al servicio que recorra su Array Bidimensional
            // y nos de solo las citas que coinciden con el ID de nuestro paciente.

            // Creamos una lista temporal para guardar los datos encontrados
            var listaCitas = new List<object>();

            // Aquí simulamos la lectura del servicio de consola
            // (En un sistema real usaríamos la lista que devuelve el CitaService)
            // Por ahora, usamos el método que creamos en el servicio para filtrar.
            dgvCitas.DataSource = _citaService.ObtenerCitasParaTabla(_pacienteSesion.Id);

            // Mejoramos el aspecto de la tabla
            dgvCitas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCitas.ReadOnly = true; // Que el paciente no pueda editar la tabla directamente
        }

        // 4. BOTÓN VOLVER
        private void btnVolver_Click(object sender, EventArgs e)
        {
            // Mostramos el menú que teníamos oculto y cerramos esta ventana
            _menuPadre.Show();
            this.Close();
        }
    }
}