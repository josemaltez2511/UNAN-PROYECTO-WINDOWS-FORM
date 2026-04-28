using System;
using System.Linq;

namespace SanarRuralProyectoUnan.Modulos
{
    public class EnfermedadService
    {
        // ARRAYS PARALELOS: Cada índice [i] corresponde a la misma enfermedad
        private readonly string[] _nombres = { "Amigdalitis", "Gripe Estacional", "Dengue", "Gastroenteritis", "Conjuntivitis" };

        private readonly string[][] _sintomasCausa = {
            new string[] { "garganta", "fiebre", "tragar" },
            new string[] { "tos", "fiebre", "congestión", "moqueo" },
            new string[] { "fiebre alta", "articulaciones", "ojos", "sarpullido" },
            new string[] { "diarrea", "vómito", "estómago", "náuseas" },
            new string[] { "ojos rojos", "picazón", "lagrimeo" }
        };

        private readonly string[] _recomendaciones = {
            "Gárgaras con sal, hidratación y reposo.",
            "Mucho líquido, descanso y paracetamol si hay fiebre.",
            "¡IMPORTANTE! No tomar aspirinas. Ir al centro de salud de inmediato.",
            "Dieta blanda (arroz, pollo) y mucho suero oral.",
            "Lavado frecuente con suero y no tocarse los ojos."
        };

        // Método que hace la magia de comparar síntomas
        public string ObtenerDiagnostico(string inputSintomas)
        {
            if (string.IsNullOrWhiteSpace(inputSintomas)) return "Por favor, escribe tus malestares.";

            // Convertimos lo que escribió el usuario en una lista de palabras minúsculas
            string[] sintomasUsuario = inputSintomas.ToLower().Split(',');

            string mejorResultado = "No logramos identificar una enfermedad clara. \nTe recomendamos agendar una cita para revisión profesional.";
            int maxCoincidencias = 0;

            for (int i = 0; i < _nombres.Length; i++)
            {
                int coincidenciasActuales = 0;
                foreach (var sUser in sintomasUsuario)
                {
                    foreach (var sBase in _sintomasCausa[i])
                    {
                        if (sUser.Trim().Contains(sBase)) coincidenciasActuales++;
                    }
                }

                // Si encontramos al menos 2 síntomas, sugerimos esa enfermedad
                if (coincidenciasActuales >= 2 && coincidenciasActuales > maxCoincidencias)
                {
                    maxCoincidencias = coincidenciasActuales;
                    mejorResultado = $"Posible Diagnóstico: {_nombres[i]}\n\n" +
                                     $"Recomendación: {_recomendaciones[i]}\n\n" +
                                     "Nota: Este es un análisis preliminar.";
                }
            }
            return mejorResultado;
        }
    }
}