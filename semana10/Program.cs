class Program
{
    static void Main()
    {
        // 1. Generar 500 ciudadanos ficticios
        var ciudadanos = Enumerable.Range(1, 500)
                                   .Select(i => $"Ciudadano {i}")
                                   .ToList();

        // 2. Crear conjuntos de vacunados con Pfizer (75) y AstraZeneca (75)
        var vacunadosPfizer = new HashSet<string>(ciudadanos.Take(75)); // primeros 75
        var vacunadosAstra = new HashSet<string>(ciudadanos.Skip(50).Take(75)); // 75 desde el 51 al 125

        // 3. Operaciones de teoría de conjuntos
        var noVacunados = ciudadanos.Except(vacunadosPfizer.Union(vacunadosAstra));
        var ambasDosis = vacunadosPfizer.Intersect(vacunadosAstra);
        var soloPfizer = vacunadosPfizer.Except(vacunadosAstra);
        var soloAstra = vacunadosAstra.Except(vacunadosPfizer);

        // 4. Mostrar resultados
        Console.WriteLine("==== Ciudadanos NO vacunados ====");
        foreach (var c in noVacunados) Console.WriteLine(c);

        Console.WriteLine("\n==== Ciudadanos con ambas dosis (Pfizer y AstraZeneca) ====");
        foreach (var c in ambasDosis) Console.WriteLine(c);

        Console.WriteLine("\n==== Ciudadanos SOLO Pfizer ====");
        foreach (var c in soloPfizer) Console.WriteLine(c);

        Console.WriteLine("\n==== Ciudadanos SOLO AstraZeneca ====");
        foreach (var c in soloAstra) Console.WriteLine(c);
    }
}
