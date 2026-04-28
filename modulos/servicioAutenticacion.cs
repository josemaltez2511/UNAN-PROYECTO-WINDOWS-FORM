using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

// Dirección unificada y en español
namespace SanarRuralProyectoUnan.Modulos
{
    // ==========================================
    // 1. ENTIDAD (El molde del Paciente)
    // ==========================================
    public class Paciente
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }

    // ==========================================
    // 2. SERVICIO (La lógica del negocio)
    // ==========================================
    public class AuthService
    {
        // Esta lista simula nuestra base de datos.
        private List<Paciente> _pacientesGuardados;

        // METODO CONSTRUCTOR: Se ejecuta apenas llamamos al servicio.
        public AuthService()
        {
            // Inicializamos la lista vacía.
            _pacientesGuardados = new List<Paciente>();

            // Creamos 3 pacientes de ejemplo para no tener que registrar a cada rato.
            _pacientesGuardados.Add(new Paciente
            {
                Id = "1",
                Nombre = "Juan Perez",
                Email = "juan@mail.com",
                Password = "123"
            });

            _pacientesGuardados.Add(new Paciente
            {
                Id = "2",
                Nombre = "Maria Lopez",
                Email = "maria@mail.com",
                Password = "456"
            });

            _pacientesGuardados.Add(new Paciente
            {
                Id = "3",
                Nombre = "Carlos Soto",
                Email = "carlos@mail.com",
                Password = "789"
            });
        }

        // METODO PARA CREAR PACIENTE
        public string RegistrarNuevoPaciente(string nombre, string email, string password)
        {
            // 1. Validaciones simples (Evitamos el validador externo)
            if (string.IsNullOrWhiteSpace(nombre) || nombre.Length < 3)
                return "Error: El nombre debe tener al menos 3 caracteres.";

            if (string.IsNullOrWhiteSpace(email) || !email.Contains("@"))
                return "Error: El email no es válido.";

            if (string.IsNullOrWhiteSpace(password) || password.Length < 4)
                return "Error: La contraseña debe tener al menos 4 caracteres.";

            // 2. Validar que no exista el email
            foreach (var p in _pacientesGuardados)
            {
                if (p.Email.ToLower() == email.ToLower())
                {
                    return "Error: Ya existe un paciente con este correo.";
                }
            }

            // 3. Crear el objeto paciente
            Paciente nuevoPaciente = new Paciente();
            nuevoPaciente.Id = (_pacientesGuardados.Count + 1).ToString();
            nuevoPaciente.Nombre = nombre;
            nuevoPaciente.Email = email;
            nuevoPaciente.Password = password;

            // 4. Guardarlo en la "base de datos"
            // En este caso, simplemente lo agregamos a la lista.
            // LA BASE DE DATOS NO EXISTE, SOLO SIMULAMOS SU FUNCIONAMIENTO CON UNA LISTA EN MEMORIA.
            _pacientesGuardados.Add(nuevoPaciente);

            return "Usuario registrado exitosamente"; // Si todo sale bien, retornamos esta palabra clave.
        }

        // METODO PARA INICIAR SESION
        public Paciente Login(string emailOUsuario, string password)
        {
            // Recorremos la lista buscando coincidencia
            // por cada paciente guardado. Si encontramos uno que coincida, devolvemos sus datos.
            foreach (var paciente in _pacientesGuardados)
            {
                // aqui decimos "si el nombre o el email coinciden (ignorando mayusculas/minusculas)
                //y la contraseña coincide, entonces es un login exitoso"
                bool coincideNombreOEmail = (paciente.Nombre.ToLower() == emailOUsuario.ToLower()
                    || paciente.Email.ToLower() == emailOUsuario.ToLower());

                // aqui decimos "si la contraseña coincide exactamente"
                bool coincidePassword = (paciente.Password == password);


                // aqui decimos "si ambas cosas coinciden, entonces devolvemos los datos del paciente"
                // lo dejamos entrar al sistema, es un login exitoso.
                if (coincideNombreOEmail && coincidePassword)
                {
                    return paciente; // Login exitoso, devolvemos los datos del paciente
                }
            }

            return null; // Login fallido
        }
    }
}