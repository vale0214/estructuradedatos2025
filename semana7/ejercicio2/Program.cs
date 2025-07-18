using System;
using System.Collections.Generic;

class Torre
{
    public Stack<int> Discos { get; private set; }
    public string Nombre { get; private set; }

    public Torre(string nombre)
    {
        Nombre = nombre;
        Discos = new Stack<int>();
    }

    public void MoverSuperiorA(Torre destino)
    {
        int disco = Discos.Pop();
        destino.Discos.Push(disco);
        Console.WriteLine($"Mover disco {disco} de {Nombre} a {destino.Nombre}");
    }

    /// <summary>
    /// Método recursivo que resuelve las Torres de Hanoi paso a paso.
    /// </summary>
    public static void Resolver(int n, Torre origen, Torre auxiliar, Torre destino)
    {
        if (n <= 0) return;

        Resolver(n - 1, origen, destino, auxiliar);
        origen.MoverSuperiorA(destino);
        Resolver(n - 1, auxiliar, origen, destino);
    }
}

class Programa
{
    static void Main()
    {
        int cantidadDiscos = 3; // Puedes cambiar a cualquier número de discos

        Torre origen = new Torre("A");
        Torre auxiliar = new Torre("B");
        Torre destino = new Torre("C");

        // Cargar los discos en la torre origen (el más grande abajo)
        for (int i = cantidadDiscos; i >= 1; i--)
        {
            origen.Discos.Push(i);
        }

        Console.WriteLine($"Resolviendo Torres de Hanoi con {cantidadDiscos} discos:\n");
        Torre.Resolver(cantidadDiscos, origen, auxiliar, destino);
    }
}

