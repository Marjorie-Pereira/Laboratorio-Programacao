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

// inicializando classe Animal
Animal a1 = new Animal();
a1.nome = "Peixe-palhaço";
a1.especie = "Amphiprion ocellaris";
a1.idade = 2;

Animal a2 = new Animal();
a2.nome = "flamingo-americano";
a2.especie = "Phoenicopterus ruber";
a2.idade = 4;

Console.WriteLine();
Console.WriteLine($"Animal: {a1.nome}, Espécie: {a1.especie}, Idade: {a1.idade} anos");

Console.WriteLine();
Console.WriteLine($"Animal: {a2.nome}, Espécie: {a2.especie}, Idade: {a2.idade} anos");

Curso curso1 = new Curso();
curso1.nome = "História";
curso1.professor = "Marília";
curso1.duracao = "8 semestres";

Curso curso2 = new Curso();
curso2.nome = "Ciência da Computação";
curso2.professor = "Francisco";
curso2.duracao = "8 semestres";

Curso curso3 = new Curso();
curso3.nome = "Design Gráfico";
curso3.professor = "Paula";
curso3.duracao = "4 semestres";

Console.WriteLine();
Console.WriteLine($"Nome do curso: {curso1.nome}, Duração: {curso1.duracao}, Professor(a): {curso1.professor}");

Console.WriteLine();
Console.WriteLine($"Nome do curso: {curso2.nome}, Duração: {curso2.duracao}, Professor(a): {curso2.professor}");

Console.WriteLine();
Console.WriteLine($"Nome do curso: {curso3.nome}, Duração: {curso3.duracao}, Professor(a): {curso3.professor}");

Carro car1 = new Carro();
car1.modelo = "Corolla";
car1.cor = "Preto";
car1.ano = 2010;

Carro car2 = new Carro();
car2.modelo = "Sandero";
car2.cor = "Prata";
car2.ano = 2015;

Carro car3 = new Carro();
car3.modelo = "Focus";
car3.cor = "Vermelho";
car3.ano = 2019;

Console.WriteLine();
Console.WriteLine($"Carro: {car1.modelo}, Ano: {car1.ano}, Cor: {car1.cor}");

Console.WriteLine();
Console.WriteLine($"Carro: {car2.modelo}, Ano: {car2.ano}, Cor: {car2.cor}");

Console.WriteLine();
Console.WriteLine($"Carro: {car3.modelo}, Ano: {car3.ano}, Cor: {car3.cor}");

Funcionario func1 = new Funcionario();
func1.nome = "Mariana";
func1.cargo = "Gerente de RH";
func1.salario = 4500;

Console.WriteLine();
Console.WriteLine($"Nome funcionário: {func1.nome}, Cargo: {func1.cargo}, Salário: R${func1.salario}");

Casa casa = new Casa();
casa.cor = "Verde";
casa.numQuartos = 5;
casa.numero = 34;

Console.WriteLine();
Console.WriteLine($"Casa {casa.cor}, Número {casa.numero}, Quantidade de quartos: {casa.numQuartos}");

TimeFutebol time1 = new TimeFutebol();
time1.nome = "Sport Club Internacional";
time1.anoFundacao = 1909;
time1.cidade = "Porto Alegre RS";

TimeFutebol time2 = new TimeFutebol();
time2.nome = "Clube Atlético Mineiro";
time2.anoFundacao = 1908;
time2.cidade = "Belo Horizonte MG";

Console.WriteLine();
Console.WriteLine($"Time: {time1.nome}, Fundação: {time1.anoFundacao}, Sede: {time1.cidade}");

Console.WriteLine();
Console.WriteLine($"Time: {time2.nome}, Fundação: {time2.anoFundacao}, Sede: {time2.cidade}");

Smartphone sm1 = new Smartphone();
sm1.modelo = "Galaxy A51";
sm1.marca = "Samsung";
sm1.anoLancamento = 2020;

Console.WriteLine();
Console.WriteLine($"Smartphone {sm1.modelo}, Fabricante: {sm1.marca}, Ano: {sm1.anoLancamento}");

Filme filme = new Filme();
filme.titulo = "Matilda";
filme.diretor = "Danny DeVito";
filme.anoLancamento = 1996;

Console.WriteLine();
Console.WriteLine($"Filme: {filme.titulo}, Ano Lançamento: {filme.anoLancamento}, Direção: {filme.diretor}");

Estudante estudante = new Estudante();
estudante.nome = "Marjorie";
estudante.idade = 19;
estudante.curso = "Análise e Desenvolvimento de Sistemas";

Console.WriteLine();
Console.WriteLine($"Estudante: {estudante.nome}, Idade: {estudante.idade} anos, Curso: {estudante.curso}");
Console.WriteLine();

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

class Funcionario
{
    public string? nome;
    public string? cargo;
    public double salario;
}

class Casa
{
    public int numQuartos;
    public int numero;
    public string? cor;
}

class TimeFutebol
{
    public string? nome;
    public string? cidade;
    public int anoFundacao;
}

class Smartphone
{
    public string? marca;
    public string? modelo;
    public int anoLancamento;
}

class Filme
{
    public string? titulo;
    public string? diretor;
    public int anoLancamento;
}

class Estudante
{
    public string? nome;
    public string? curso;
    public int idade;
}