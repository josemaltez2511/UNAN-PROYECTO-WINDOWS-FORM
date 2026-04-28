using System;
using System.Collections.Generic;

namespace SanarRuralProyectoUnan.Modulos
{
    public class TratamientoService
    {
        // 1. ESTRUCTURA DE DATOS (Array Bidimensional)
        // Columnas: [0]ID, [1]PacienteID, [2]Descripción, [3]Fecha Inicio, [4]Fecha Fin
        private static string[,] _tratamientos = new string[100, 5];
        private static int _contadorTratamientos = 0;

        // 2. MÉTODO PARA REGISTRAR
        public string RegistrarTratamiento(string pacienteId, string descripcion, DateTime inicio, DateTime fin)
        {
            // Validaciones básicas de seguridad
            if (string.IsNullOrEmpty(descripcion) || descripcion.Length < 5)
                return "Error: La descripción es muy corta.";

            if (fin < inicio)
                return "Error: La fecha de fin no puede ser antes que la de inicio.";

            if (_contadorTratamientos < 100)
            {
                // Guardamos los datos en las columnas correspondientes
                _tratamientos[_contadorTratamientos, 0] = (_contadorTratamientos + 1).ToString();
                _tratamientos[_contadorTratamientos, 1] = pacienteId;
                _tratamientos[_contadorTratamientos, 2] = descripcion;
                _tratamientos[_contadorTratamientos, 3] = inicio.ToShortDateString();
                _tratamientos[_contadorTratamientos, 4] = fin.ToShortDateString();

                _contadorTratamientos++;
                return "EXITO";
            }
            return "Error: Memoria llena (máximo 100 tratamientos).";
        }

        // 3. MÉTODO PARA LA TABLA
        // Filtra el array y devuelve solo lo que pertenece al paciente actual
        public List<object> ObtenerTratamientosPorPaciente(string pacienteId)
        {
            List<object> lista = new List<object>();
            for (int i = 0; i < _contadorTratamientos; i++)
            {
                if (_tratamientos[i, 1] == pacienteId)
                {
                    lista.Add(new
                    {
                        ID = _tratamientos[i, 0],
                        Descripción = _tratamientos[i, 2],
                        Inicio = _tratamientos[i, 3],
                        Fin = _tratamientos[i, 4]
                    });
                }
            }
            return lista;
        }
    }
}