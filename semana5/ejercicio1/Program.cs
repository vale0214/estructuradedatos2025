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

        // Mostrar mensaje para cada asignatura
        foreach (string asignatura in asignaturas)
        {
            Console.WriteLine($"Yo estudio {asignatura}");
        }
    }
}
