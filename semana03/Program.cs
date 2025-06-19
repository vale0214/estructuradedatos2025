using System;

namespace RegistroEstudiante
{
    // Clase que representa a un estudiante
    public class Estudiante
    {
        // Campos privados encapsulados
        private string id;
        private string nombres;
        private string apellidos;
        private string[] telefonos;

        // Constructor para inicializar todos los datos
        public Estudiante(string id, string nombres, string apellidos, string[] telefonos)
        {
            this.id = id;
            this.nombres = nombres;
            this.apellidos = apellidos;

            // Validamos que se reciban exactamente 3 teléfonos
            if (telefonos.Length == 3)
                this.telefonos = telefonos;
            else
                this.telefonos = new string[3]; // Por defecto crea un arreglo vacío
        }

        // Método para mostrar los datos del estudiante
        public void MostrarInformacion()
        {
            Console.WriteLine("===== Datos del Estudiante =====");
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Nombres: " + nombres);
            Console.WriteLine("Apellidos: " + apellidos);
            Console.WriteLine("Teléfonos:");
            for (int i = 0; i < telefonos.Length; i++)
            {
                Console.WriteLine($"Teléfono {i + 1}: {telefonos[i]}");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Creamos el array de teléfonos del estudiante
            string[] telefonosValentina = { "09368275982", "0962524322", "09687255634" };

            // Instanciamos un objeto de tipo Estudiante
            Estudiante estudiante1 = new Estudiante("2300272421", "Valentina", "Cevallos", telefonosValentina);

            // Mostramos su información
            estudiante1.MostrarInformacion();

            // Espera para que no cierre la consola inmediatamente
            Console.ReadLine();
        }
    }
}
