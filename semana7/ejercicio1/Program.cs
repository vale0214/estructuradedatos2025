using System;
using System.Collections.Generic;

class VerificadorBalanceo
{
    /// <summary>
    /// Verifica si la expresión matemática tiene paréntesis, llaves y corchetes balanceados.
    /// </summary>
    public static bool EstaBalanceada(string expresion)
    {
        Stack<char> pila = new Stack<char>();

        foreach (char c in expresion)
        {
            if (c == '(' || c == '{' || c == '[')
            {
                pila.Push(c);
            }
            else if (c == ')' || c == '}' || c == ']')
            {
                if (pila.Count == 0)
                    return false;

                char top = pila.Pop();
                if (!EsParCoincidente(top, c))
                    return false;
            }
        }

        return pila.Count == 0;
    }

    /// <summary>
    /// Comprueba si dos símbolos de apertura y cierre coinciden.
    /// </summary>
    private static bool EsParCoincidente(char apertura, char cierre)
    {
        return (apertura == '(' && cierre == ')') ||
               (apertura == '[' && cierre == ']') ||
               (apertura == '{' && cierre == '}');
    }

    static void Main()
    {
        Console.Write("Ingrese una expresión matemática: ");
        string expresion = Console.ReadLine();

        if (EstaBalanceada(expresion))
            Console.WriteLine("Fórmula balanceada.");
        else
            Console.WriteLine("Fórmula NO balanceada.");
    }
}

