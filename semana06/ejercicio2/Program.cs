using System;

class Nodo
{
    public int Valor;
    public Nodo Siguiente;

    public Nodo(int valor)
    {
        Valor = valor;
        Siguiente = null;
    }
}

class ListaEnlazada
{
    public Nodo Cabeza;

    public void Agregar(int valor)
    {
        Nodo nuevo = new Nodo(valor);
        if (Cabeza == null)
            Cabeza = nuevo;
        else
        {
            Nodo actual = Cabeza;
            while (actual.Siguiente != null)
                actual = actual.Siguiente;
            actual.Siguiente = nuevo;
        }
    }

    public void Invertir()
    {
        Nodo anterior = null;
        Nodo actual = Cabeza;
        Nodo siguiente = null;

        while (actual != null)
        {
            siguiente = actual.Siguiente;
            actual.Siguiente = anterior;
            anterior = actual;
            actual = siguiente;
        }
        Cabeza = anterior;
    }

    public void Mostrar()
    {
        Nodo actual = Cabeza;
        while (actual != null)
        {
            Console.Write(actual.Valor + " ");
            actual = actual.Siguiente;
        }
        Console.WriteLine();
    }
}

class Programa
{
    static void Main()
    {
        ListaEnlazada lista = new ListaEnlazada();
        lista.Agregar(1);
        lista.Agregar(2);
        lista.Agregar(3);
        lista.Agregar(4);
        lista.Agregar(5);

        Console.WriteLine("Lista original:");
        lista.Mostrar();

        lista.Invertir();

        Console.WriteLine("Lista invertida:");
        lista.Mostrar();
    }
}
