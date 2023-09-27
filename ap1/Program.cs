using System;

namespace ap1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CALCULANDO IMC");

            Relatorio();
            
        }

        static void Imc(double altura, double peso)
        {

            

            double imc = peso / (altura * altura);

            

            if (imc <= 18.6)
            {
               Console.WriteLine($"IMC: {(int)imc}, abaixo do peso.");
            }
            else if (imc > 18.9 )
            {
                Console.WriteLine($"IMC: {(int)imc}, Indefinido.");
            }

        }

        static void FaixaEtaria(int? idade)
        {
             if (idade <= 12)
                {
                     Console.WriteLine($"Faixa etária: {idade} anos, criança");
                }
                else if (idade >= 13 && idade <= 19)
                {
                     Console.WriteLine($"Faixa etária: {idade} anos, adolescente");
                }
                else if (idade >= 20 && idade <= 60)
                {
                    Console.WriteLine($"Faixa etária: {idade} anos, adulto");
                }
                else
                {
                    Console.WriteLine($"Faixa etária: {idade} anos, idoso");
                }



        }

        static void Relatorio()
        {
            Console.WriteLine("Digite seu nome:");
            string? nome = Console.ReadLine();
            Console.WriteLine("Informe sua idade:");
            int? idade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe sua altura");
            double altura = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe seu peso");
            double peso = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine("Gerando relatório...");
            Console.WriteLine("");
            Console.WriteLine($"NOME: {nome}");
            FaixaEtaria(idade);
            Imc(altura, peso);
            Console.WriteLine("");
        }
    }
}
