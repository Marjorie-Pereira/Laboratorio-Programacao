// AP1: CALCULANDO IMC

string? resp;

string fxEtaria;

string classificaImc;

do
{   
    // Guardando os dados
    Console.WriteLine("Digite seu nome:");
    string? nome = Console.ReadLine();
    Console.WriteLine("Digite sua idade");
    int idade = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Digite sua altura:");
    double altura = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Digite seu peso");
    double peso = Convert.ToDouble(Console.ReadLine());

    double imc = peso / (altura * altura);
    
    // classificacao do imc
    if (imc < 18.5)
    {
        classificaImc = "abaixo do peso.";
    }
    else if (imc >= 18.6 && imc <= 24.9)
    {
        classificaImc = "com peso ideal.";
    }
    else if (imc >= 25 && imc <= 29.9)
    {
        classificaImc = "levemente acima do peso.";
    }
    else if (imc >= 30 && imc <= 34.9)
    {
        classificaImc = "com obesidade grau I";
    }
    else if (imc >= 35 && imc <= 39.9)
    {
        classificaImc = "com obesidade grau II";
    }
    else
    {
        classificaImc = "com obesidade grau III";
    }
    // verificando faixa etária
    if (idade <= 12)
    {
        fxEtaria = "Criança";
    }
    else if (idade >= 13 && idade <= 19)
    {
        fxEtaria = "Adolescente";
    }
    else if (idade >= 20 && idade <= 60)
    {
        fxEtaria = "Adulto";
    }
    else
    {
        fxEtaria = "Idoso";
    }

    // gerando relatório
    Console.WriteLine("Nome: " + nome);
    Console.WriteLine($"Idade: {idade} anos.");
    Console.WriteLine("Faixa etária: " + fxEtaria);
    Console.WriteLine("IMC: " + (int)imc);
    Console.WriteLine("Você está " + classificaImc);


    // Solicitando resposta ao usuario
    Console.WriteLine("\n Deseja fazer um novo relatório? [S/N]");
    resp = Console.ReadLine();
    resp = resp?.ToLower();
    

}
while(resp == "s"); //loop baseado na resposta do usuario.

Console.WriteLine("Encerrando...");