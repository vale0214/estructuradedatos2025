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

    public int ContarElementos()
    {
        int contador = 0;
        Nodo actual = Cabeza;
        while (actual != null)
        {
            contador++;
            actual = actual.Siguiente;
        }
        return contador;
    }
}

class Programa
{
    static void Main()
    {
        ListaEnlazada lista = new ListaEnlazada();
        lista.Agregar(5);
        lista.Agregar(10);
        lista.Agregar(15);

        Console.WriteLine("Número de elementos en la lista: " + lista.ContarElementos());
    }
}
