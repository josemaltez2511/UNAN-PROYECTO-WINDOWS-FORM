namespace ProyectoMedicoWindowsForms.Entities
{
    public class Tratamiento
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Descripcion { get; set; }
        public DateTime FechaInicio { get; set; }

        // El signo de interrogación (?) convierte al DateTime en un "Nullable Type" (Tipo Anulable).
        // ¿Por qué?: Normalmente, un DateTime no puede estar vacío, por defecto toma la fecha 01/01/0001.
        // En la lógica de un hospital, si el tratamiento acaba de iniciar, la fecha de fin no existe aún.
        // El "?" permite que esta variable guarde un valor "null" temporalmente hasta que el médico la asigne.
        public DateTime? FechaFin { get; set; }
    }
}