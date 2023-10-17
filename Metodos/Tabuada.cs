class Tabuada
{
    public void ImprimirTabuada(int n)
    {
        int numeroBase = n;
        int cont = 1;
        Console.WriteLine($"\nTABUADA DO NÚMERO {numeroBase}");
        while (cont <= 10)
        {
            Console.WriteLine($"{numeroBase} x {cont} = {numeroBase * cont}");
            cont += 1;
        }
        Console.ReadKey();
    }
}