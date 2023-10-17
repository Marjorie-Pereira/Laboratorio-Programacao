using System.Security.Cryptography.X509Certificates;

class Quadrado
{
    public void Calculo(int n1)
    {
        int resultado = n1 * n1;
        Console.WriteLine($"{n1}² = {resultado}");
    }
}