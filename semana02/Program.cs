using System;

namespace FigurasGeometricas
{
    // Clase que representa un círculo
    public class Circulo
    {
        // Campo privado que almacena el radio del círculo
        private double radio;

        // Propiedad pública para acceder y validar el radio
        public double Radio
        {
            get { return radio; }
            set
            {
                if (value >= 0)
                    radio = value;
            }
        }

        // Constructor que recibe el radio como argumento
        public Circulo(double radio)
        {
            Radio = radio;
        }

        // CalcularArea es una función que devuelve un valor double,
        // se utiliza para calcular el área de un círculo
        public double CalcularArea()
        {
            return Math.PI * radio * radio;
        }

        // CalcularPerimetro devuelve el perímetro del círculo (circunferencia)
        public double CalcularPerimetro()
        {
            return 2 * Math.PI * radio;
        }
    }

    // Clase que representa un cuadrado
    public class Cuadrado
    {
        // Campo privado que almacena la longitud del lado
        private double lado;

        // Propiedad pública para acceder y validar el lado
        public double Lado
        {
            get { return lado; }
            set
            {
                if (value >= 0)
                    lado = value;
            }
        }

        // Constructor que recibe el lado como argumento
        public Cuadrado(double lado)
        {
            Lado = lado;
        }

        // CalcularArea devuelve el área del cuadrado
        public double CalcularArea()
        {
            return lado * lado;
        }

        // CalcularPerimetro devuelve el perímetro del cuadrado
        public double CalcularPerimetro()
        {
            return 4 * lado;
        }
    }

    // Clase principal para probar las figuras
    class Program
    {
        static void Main(string[] args)
        {
            // Crear un círculo con radio 5
            Circulo miCirculo = new Circulo(5);
            Console.WriteLine("Área del círculo: " + miCirculo.CalcularArea());
            Console.WriteLine("Perímetro del círculo: " + miCirculo.CalcularPerimetro());

            // Crear un cuadrado con lado 4
            Cuadrado miCuadrado = new Cuadrado(4);
            Console.WriteLine("Área del cuadrado: " + miCuadrado.CalcularArea());
            Console.WriteLine("Perímetro del cuadrado: " + miCuadrado.CalcularPerimetro());
        }
    }
}
