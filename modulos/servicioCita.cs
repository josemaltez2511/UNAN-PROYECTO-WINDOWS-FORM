using System;
using System.Collections.Generic;

namespace SanarRuralProyectoUnan.Modulos
{
    public class CitaService
    {
        // 1. DEFINICIÓN DE LA "TABLA" (Array de 100 filas y 3 columnas)
        private const int MAX_CITAS = 100;
        private static string[,] _citas = new string[MAX_CITAS, 3]; // [PacienteID, Motivo, Fecha]
        private static int _contadorCitas = 0;

        // 2. MÉTODO PARA REGISTRAR (Tu lógica de consola mejorada)
        public string RegistrarCita(string pacienteId, string motivo, string fecha)
        {
            // Validamos que no falten datos básicos
            if (string.IsNullOrEmpty(motivo) || motivo.Length < 5)
                return "Error: El motivo debe ser más descriptivo.";

            if (_contadorCitas < MAX_CITAS)
            {
                // Guardamos los datos en la "tabla" (nuestro array)
                _citas[_contadorCitas, 0] = pacienteId;
                _citas[_contadorCitas, 1] = motivo;
                _citas[_contadorCitas, 2] = fecha;

                _contadorCitas++; // Aumentamos el contador para la siguiente cita
                return "EXITO";
            }
            return "Error: Ya no hay cupo para más citas.";
        }

        // 3. MÉTODO PARA LEER (Para mostrar en la tabla de Windows Forms)
        // Este método busca en el array y nos devuelve solo las citas del paciente que inició sesión.
        public List<object> ObtenerCitasLista(string pacienteId)
        {
            List<object> listaParaMostrar = new List<object>();

            for (int i = 0; i < _contadorCitas; i++)
            {
                if (_citas[i, 0] == pacienteId)
                {
                    // Creamos un objeto anónimo para que la tabla lo entienda fácil
                    listaParaMostrar.Add(new { Motivo = _citas[i, 1], Fecha = _citas[i, 2] });
                }
            }
            return listaParaMostrar;
        }

        // Agrega esto dentro de la clase CitaService en tu archivo de módulos
        public List<object> ObtenerCitasParaTabla(string pacienteId)
        {
            List<object> listaCitas = new List<object>();

            // Recorremos el Array de citas que ya teníamos
            for (int i = 0; i < _contadorCitas; i++)
            {
                // Si la cita pertenece al paciente que está logueado...
                if (_citas[i, 0] == pacienteId)
                {
                    // La agregamos a la lista que verá la tabla
                    listaCitas.Add(new
                    {
                        Motivo = _citas[i, 1],
                        Fecha = _citas[i, 2]
                    });
                }
            }
            return listaCitas;
        }
    }
}