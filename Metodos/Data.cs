using System.Reflection.Metadata;

class Data
{
    public void ImprimirData(int dia, int mes, int ano)
    {
        if(dia < 10 && mes < 10)
        {
            string data = $"0{dia}/0{mes}/{ano}";
            Console.WriteLine(data);
        }
        else if (mes < 10)
        {
            string data = $"{dia}/0{mes}/{ano}";
            Console.WriteLine(data);
        }
        else if (dia < 10)
        {
            string data = $"0{dia}/{mes}/{ano}";
            Console.WriteLine(data);
        }
        else
        {
            string data = $"{dia}/{mes}/{ano}";
            Console.WriteLine(data);
        }
    }
}