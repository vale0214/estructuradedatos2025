using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Lista de asignaturas
        List<string> asignaturas = new List<string>()
        {
            "Inglés",
            "Robótica",
            "Química",
            "Ciencias",
            "Sociales"
        };

        // Diccionario para guardar las notas asociadas a cada asignatura
        Dictionary<string, double> notas = new Dictionary<string, double>();

        // Solicitar al usuario la nota para cada asignatura
        foreach (string asignatura in asignaturas)
        {
            Console.Write($"¿Qué nota has sacado en {asignatura}? ");
            string entrada = Console.ReadLine();

            // Convertir a número y guardar
            if (double.TryParse(entrada, out double nota))
            {
                notas[asignatura] = nota;
            }
            else
            {
                Console.WriteLine("Entrada no válida. Se asignará nota 0.");
                notas[asignatura] = 0;
            }
        }

        // Mostrar el resultado
        Console.WriteLine("\nResultados:");
        foreach (var asignatura in asignaturas)
        {
            Console.WriteLine($"En {asignatura} has sacado {notas[asignatura]}");
        }
    }
}

