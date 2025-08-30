class Traductor
{
    static void Main()
    {
        // Diccionario base con algunas palabras en inglés ↔ español
        Dictionary<string, string> diccionario = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
        {
            {"time", "tiempo"},
            {"person", "persona"},
            {"year", "año"},
            {"way", "camino"},
            {"day", "día"},
            {"thing", "cosa"},
            {"man", "hombre"},
            {"world", "mundo"},
            {"life", "vida"},
            {"hand", "mano"},
            {"part", "parte"},
            {"child", "niño"},
            {"eye", "ojo"},
            {"woman", "mujer"},
            {"place", "lugar"},
            {"work", "trabajo"},
            {"week", "semana"},
            {"case", "caso"},
            {"point", "punto"},
            {"government", "gobierno"},
            {"company", "empresa"}
        };

        int opcion = -1;

        do
        {
            Console.WriteLine("\n==================== MENÚ ====================");
            Console.WriteLine("1. Traducir una frase");
            Console.WriteLine("2. Agregar palabras al diccionario");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opción: ");
            string entrada = Console.ReadLine();
            int.TryParse(entrada, out opcion);

            switch (opcion)
            {
                case 1:
                    TraducirFrase(diccionario);
                    break;

                case 2:
                    AgregarPalabra(diccionario);
                    break;

                case 0:
                    Console.WriteLine("Saliendo del traductor...");
                    break;

                default:
                    Console.WriteLine("Opción no válida. Intente nuevamente.");
                    break;
            }

        } while (opcion != 0);
    }

    // Método para traducir frases
    static void TraducirFrase(Dictionary<string, string> diccionario)
    {
        Console.Write("\nIngrese la frase a traducir: ");
        string frase = Console.ReadLine();
        string[] palabras = frase.Split(' ');

        Console.WriteLine("\n Traducción:");
        foreach (string palabra in palabras)
        {
            string palabraLimpia = palabra.Trim(' ', ',', '.', '!', '?', ';').ToLower();

            if (diccionario.ContainsKey(palabraLimpia))
            {
                // Reemplazar solo la parte traducida pero mantener la puntuación
                string traduccion = diccionario[palabraLimpia];
                Console.Write(palabra.Replace(palabraLimpia, traduccion) + " ");
            }
            else
            {
                Console.Write(palabra + " ");
            }
        }
        Console.WriteLine("\n");
    }

    // Método para agregar nuevas palabras
    static void AgregarPalabra(Dictionary<string, string> diccionario)
    {
        Console.Write("\nIngrese la palabra en inglés: ");
        string ingles = Console.ReadLine().ToLower();

        Console.Write("Ingrese su traducción al español: ");
        string espanol = Console.ReadLine().ToLower();

        if (!diccionario.ContainsKey(ingles))
        {
            diccionario.Add(ingles, espanol);
            Console.WriteLine($"Palabra agregada: {ingles} → {espanol}");
        }
        else
        {
            Console.WriteLine("Esa palabra ya existe en el diccionario.");
        }
    }
}
