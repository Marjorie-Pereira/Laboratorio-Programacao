// TDE AULA 06

// EX 01
// Console.WriteLine("Digite um número:");
// int numero = Convert.ToInt32(Console.ReadLine());

// if (numero > 0)
// {
//     Console.WriteLine("O número é positivo.");
// }
// else if (numero < 0)
// {
//     Console.WriteLine("O número é negativo.");
// }
// else
// {
//     Console.WriteLine("O número é zero.");
// }

// EX 02
// Console.WriteLine("Digite um número que representa os dias da semana:");
// int numero = Convert.ToInt32(Console.ReadLine());

// switch (numero)
// {
//     case 1:
//     Console.WriteLine("Domingo.");
//     break;
//     case 2:
//     Console.WriteLine("Segunda-feira.");
//     break;
//     case 3:
//     Console.WriteLine("Terça-feira.");
//     break;
//     case 4:
//     Console.WriteLine("Quarta-feira.");
//     break;
//     case 5:
//     Console.WriteLine("Quinta-feira.");
//     break;
//     case 6:
//     Console.WriteLine("Sexta-feira.");
//     break;
//     case 7:
//     Console.WriteLine("Sábado.");
//     break;
//     default:
//     Console.WriteLine("Número inválido.");
//     break;
// }

// EX 03

// Console.WriteLine("Informe sua idade:");
// int idade = Convert.ToInt32(Console.ReadLine());

// if (idade >= 0 && idade <= 12)
// {
//     Console.WriteLine("Você é criança.");
// }
// else if (idade >= 13 && idade <= 18)
// {
//     Console.WriteLine("Você é adolescente.");
// }
// else if (idade >= 19 && idade <= 59)
// {
//     Console.WriteLine("Você é adulto.");
// }
// else if (idade >= 60)
// {
//     Console.WriteLine("Você é idoso.");
// }

// EX 04

// Console.WriteLine("Digite o ano atual.");
// int ano = Convert.ToInt32(Console.ReadLine());

// if (ano % 4 == 0)
// {
//     Console.WriteLine("É um ano bissexto.");
// }
// else if (ano % 400 == 0)
// {
//     Console.WriteLine("É um ano bissexto.");
// }
// else if (ano % 100 == 0)
// {
//     Console.WriteLine("É um ano bissexto");
// }
// else
// {
//     Console.WriteLine("Não é um ano bissexto.");
// }

// EX 05

// Console.WriteLine("\nCalculadora simples. Digite dois números para realizar as operações matemáticas.");
// Console.WriteLine("Digite o primeiro número:");
// var num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Digite o segundo número:");
// var num2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Digite 1 para somar, 2 para subtrair, 3 para multiplicar e 4 para dividir. ");
// var resp = Convert.ToInt32(Console.ReadLine());

// switch (resp)
// {
//     case 1:
//     Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
//     break;
//     case 2:
//     Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
//     break;
//     case 3:
//     Console.WriteLine($"{num1} x {num2} = {num1* num2}");
//     break;
//     case 4:
//     Console.WriteLine($"{num1} : {num2} = {num1 / num2}");
//     break;
// }

// EX 06

// Console.WriteLine("\nAvaliação de notas.");
// Console.WriteLine("Informe a nota");

// double nota = Convert.ToDouble(Console.ReadLine());

// if (nota >= 90 && nota <= 100)
// {
//     Console.WriteLine("Nota A");
// }
// else if(nota >= 80 && nota <= 89)
// {
//     Console.WriteLine("Nota B");
// }
// else if(nota >= 70 && nota <= 79)
// {
//     Console.WriteLine("Nota C");
// }
// else if(nota >= 60 && nota <= 69)
// {
//     Console.WriteLine("Nota D");
// }
// else if(nota >= 0 && nota <= 59)
// {
//     Console.WriteLine("Nota F");
// }

// EX 07

// Console.WriteLine("Digite um número que corresponda ao mês do ano (números entre 1 e 12):");
// int numero = Convert.ToInt32(Console.ReadLine());

// switch (numero)
// {
//     case 1:
//     Console.WriteLine("Janeiro.");
//     break;
//     case 2:
//     Console.WriteLine("Fevereiro.");
//     break;
//     case 3:
//     Console.WriteLine("Março.");
//     break;
//     case 4:
//     Console.WriteLine("Abril.");
//     break;
//     case 5:
//     Console.WriteLine("Maio.");
//     break;
//     case 6:
//     Console.WriteLine("Junho.");
//     break;
//     case 7:
//     Console.WriteLine("Julho.");
//     break;
//     case 8:
//     Console.WriteLine("Agosto.");
//     break;
//     case 9:
//     Console.WriteLine("Setembro.");
//     break;
//     case 10:
//     Console.WriteLine("Outubro.");
//     break;
//     case 11:
//     Console.WriteLine("Novembro.");
//     break;
//     case 12:
//     Console.WriteLine("Dezembro.");
//     break;
//     default:
//     Console.WriteLine("Número inválido.");
//     break;
// }

// EX 08

// Console.WriteLine("Digite três números");
// Console.WriteLine("Primeiro número");
// double num1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Segundo número");
// double num2 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Terceiro número");
// double num3 = Convert.ToDouble(Console.ReadLine());

// if (num1 > num2 && num1 > num3)
// {
//     Console.WriteLine($"O maior número digitado foi {num1}");
// }
// else if(num2 > num1 && num2 > num3)
// {
//     Console.WriteLine($"O maior número digitado foi {num2}");
// }
// else
// {
//     Console.WriteLine($"O maior número digitado foi {num3}");
// }

// EX 09

// Console.WriteLine("Informe sua idade para consultar o valor a ser pago na tarifa do ônibus.");
// int idade = Convert.ToInt32(Console.ReadLine());

// if (idade <= 5)
// {
//     Console.WriteLine("A tarifa é grátis");
// }
// else if (idade >= 6 && idade <= 12)
// {
//     Console.WriteLine("50% de desconto na tarifa.");
// }
// if (idade >= 13 && idade <= 59)
// {
//     Console.WriteLine("Tarifa completa.");
// }
// if (idade >= 60)
// {
//     Console.WriteLine("A tarifa é grátis");
// }

// EX 10

Console.WriteLine("Informe a temperatura atual");
double temp = Convert.ToDouble(Console.ReadLine());

if (temp >= 0 && temp <= 15)
{
    Console.WriteLine("Frio!");
}
else if (temp >= 16 && temp <= 25)
{
    Console.WriteLine("Clima agradável!");
}
else if(temp >= 26 && temp <= 35)
{
    Console.WriteLine("Calor!");
}
else if (temp > 35)
{
    Console.WriteLine("Muito quente!");
}
else
{
    Console.WriteLine("Congelando!");
}