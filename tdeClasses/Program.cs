Pessoa p1 = new Pessoa();
p1.nome = "Marjorie";
p1.idade = 19;
p1.cidadeNatal = "Capão da Canoa";

Console.WriteLine();
Console.WriteLine($"Nome: {p1.nome}, Idade: {p1.idade} , Cidade Natal: {p1.cidadeNatal}");

Produto prod1 = new Produto();
prod1.nome = "Xícara";
prod1.preco = 12.99;
prod1.categoria = "Cozinha";

Console.WriteLine();
Console.WriteLine($"Produto: {prod1.nome}, Preço: R${prod1.preco}, Categoria: {prod1.categoria}");

Animal a1 = new Animal();
a1.nome = "Peixe-palhaço";
a1.especie = "Amphiprion ocellaris";
a1.idade = 2;

Animal a2 = new Animal();
a2.nome = "flamingo-americano";
a2.especie = "Phoenicopterus ruber";
a2.idade = 4;

Console.WriteLine();
Console.WriteLine($"Animal: {a1.nome}, Espécie: {a1.especie}, Idade: {a1.idade}");

Console.WriteLine();
Console.WriteLine($"Animal: {a2.nome}, Espécie: {a2.especie}, Idade: {a2.idade}");


class Pessoa
{
    public string? nome;
    public int? idade;
    public string? cidadeNatal;

}

class Produto
{
    public string? nome;
    public double preco;
    public string? categoria;
}

class Animal
{
    public string? nome;
    public string? especie;
    public int idade;
}

class Curso
{
    public string? nome;
    public string? duracao;
    public string? professor;
}


class Carro
{
    public string? cor;
    public string? modelo;
    public int ano;
}