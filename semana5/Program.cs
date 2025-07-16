class Program
{
    static void Main()
    {
        // Crear una lista de asignaturas
        List<string> asignaturas = new List<string>()
        {
            "Inglés",
            "Robótica",
            "Química",
            "Ciencias",
            "Sociales"
        };

        // Mostrar las asignaturas por pantalla
        Console.WriteLine("Asignaturas del curso:");
        foreach (string asignatura in asignaturas)
        {
            Console.WriteLine("- " + asignatura);
        }
    }
}

