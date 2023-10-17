class CalculadoraArea
{
    public void CalcularArea(double lado1, double lado2)
    {
        Console.WriteLine(lado1 * lado2);
    }
    public void CalcularArea(double base1, double base2, double h)
    {
        Console.WriteLine((base1+base2)*h/2);
    }
    
}