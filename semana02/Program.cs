# Crear contenido del código C# con comentarios explicativos
codigo_csharp = """
// Clase para representar un Círculo
public class Circulo
{
    // Variable privada que almacena el radio del círculo
    private double radio;

    // Constructor que inicializa el radio
    public Circulo(double radio)
    {
        this.radio = radio;
    }

    // Método que calcula el área del círculo
    // CalcularArea devuelve un valor double, se utiliza para calcular el área de un círculo
    public double CalcularArea()
    {
        return Math.PI * radio * radio;
    }

    // Método que calcula el perímetro del círculo
    // CalcularPerimetro devuelve un valor double, se utiliza para calcular la circunferencia del círculo
    public double CalcularPerimetro()
    {
        return 2 * Math.PI * radio;
    }
}

// Clase para representar un Rectángulo
public class Rectangulo
{
    // Variables privadas que almacenan la base y la altura del rectángulo
    private double baseRect;
    private double altura;

    // Constructor que inicializa base y altura
    public Rectangulo(double baseRect, double altura)
    {
        this.baseRect = baseRect;
        this.altura = altura;
    }

    // Método que calcula el área del rectángulo
    // CalcularArea devuelve un valor double, multiplicando base por altura
    public double CalcularArea()
    {
        return baseRect * altura;
    }

    // Método que calcula el perímetro del rectángulo
    // CalcularPerimetro devuelve un valor double, sumando el doble de la base y el doble de la altura
    public double CalcularPerimetro()
    {
        return 2 * (baseRect + altura);
    }
}
"""