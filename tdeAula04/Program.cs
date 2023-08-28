// Ex 01
string nome = "Paulo";
var idade = 17;
var nota = 7.5;
Console.WriteLine(nome + " tem " + idade + " anos e nota: " + nota);
// interpolação
Console.WriteLine($"{nome} tem {idade} anos e nota: {nota}.");

// EX 02
Console.WriteLine($"\n Nome: {nome} \n idade: {idade} \n nota: {nota}");

// EX 03

// class ReverseString
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Digite tres letras");
//         string str = Console.ReadLine();
//         char[] stringArray = str.ToCharArray();
//         Array.Reverse(stringArray);
//         string reversedStr = new string(stringArray);
//         Console.Write($"Letras digitadas: {str} \n");
//         Console.Write($"Letras digitadas na ordem contrária: {reversedStr}");
//     }

// }

// EX 04

// Console.WriteLine("Digite dois numeros para a realizacao de operacoes matematicas:");
// double num1 = Convert.ToDouble(Console.ReadLine());
// double num2 = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
// Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
// Console.WriteLine($"{num1} x {num2} = {num1 * num2}");
// Console.WriteLine($"{num1} / {num2} = {num1/num2}");
// Console.WriteLine($"{num1} elevado a {num2} = {Math.Pow(num1, num2)}");
// Console.WriteLine($"Modulo de {num1} por {num2} = {num1 % num2} ");

// EX 05
// var a = 1;
// var b = 12;
// var c = -13; 
 
// Console.WriteLine($"{b} ** 2 + 4.{a}.{c} = {Math.Pow(b, 2) + 4 * a * c} ");

// EX 06

// Console.WriteLine("Digite o nome de usuário e a senha:");
// string user = Console.ReadLine();
// int senha = Convert.ToInt32(Console.ReadLine());

// string validar = (user == "admin" || user == "maria" && senha == 123) ? "Login feito com sucesso." : "Login inválido.";

// Console.WriteLine(validar);

// EX 07

Console.WriteLine("Digite dois números para saber se são pares ou não.");

int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());

string seParX = (x % 2 == 0) ? " é par." : " é ímpar.";
string seParY = (y % 2 == 0) ? " é par." : " é ímpar.";   

Console.WriteLine($"O número {x}{seParX}");
Console.WriteLine($"O número {y}{seParY}");