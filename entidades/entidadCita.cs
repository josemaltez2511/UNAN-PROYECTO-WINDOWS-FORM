namespace ProyectoMedicoWindowsForms.Entities
{
    // Esta clase es un modelo de datos. Define la estructura que tendrá una cita en la memoria.
    public class Cita
    {
        // Se utiliza Guid (Identificador Único Global) en lugar de un número entero (1, 2, 3).
        // ¿Por qué?: Para evitar que dos citas tengan el mismo ID si
        // el sistema crece o si se guardan datos al mismo tiempo.
        // { get; set; } son propiedades automáticas que permiten leer (get)
        // y escribir (set) el dato desde otras partes del programa.
        public Guid Id { get; set; } = Guid.NewGuid();

        // Se usa DateTime porque es una estructura optimizada en C# que maneja 
        // internamente calendarios, horas y zonas horarias, evitando que guardemos texto simple.
        public DateTime Fecha { get; set; }

        public string Motivo { get; set; }
    }
}