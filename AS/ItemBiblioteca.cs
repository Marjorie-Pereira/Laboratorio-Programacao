public abstract class ItemBiblioteca
{
    public int Id { get; set; }
    public string? Titulo { get; set; }

    // propriedade protegida para que seu valor nao seja alterado indesejadamente
    protected string? DescricaoInterna { get; set; } 

    //parametro opcional description definido como default
    public ItemBiblioteca(int id, string titulo)
    {
        this.Id = id;
        this.Titulo = titulo;
        DescricaoInterna = "descrição";
    }
}