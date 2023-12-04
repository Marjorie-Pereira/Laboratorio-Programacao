public class Livro : ItemBiblioteca //herdando os atributos de ItemBiblioteca
{
    public string? Autor { get; set; }
    public string? DescLivro { get; set; }

    //construtor Livro com os parametros herdados da classe base
    public Livro(int id, string titulo, string autor) : base(id, titulo)
    {
        this.Autor = autor;
        DescLivro = DescricaoInterna; //atribuindo o valor padrao de DescricaoInterna a DescLivro
        
    }
    public void ExibirDescricaoInterna()
    {
        Console.WriteLine($"Descrição: {DescLivro}");
    }
}