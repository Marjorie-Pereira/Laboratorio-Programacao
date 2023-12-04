public class Biblioteca
{
    List<Livro> itensBiblioteca = new List<Livro>();

    public void AdicionarItem(Livro livro)
    {
        itensBiblioteca.Add(livro);
        Console.WriteLine($"\"{livro.Titulo}\" adicionado à biblioteca.");
    }
    public void RemoverItem(Livro livro)
    {
        itensBiblioteca.Remove(livro);
        Console.WriteLine($"\"{livro.Titulo}\" removido da biblioteca.");
    }

    public void BuscarPorTitulo(string titulo)
    {
        //percorrendo colecao itensBiblioteca
        Console.WriteLine("==============");
        Console.WriteLine($"Buscando item de título {titulo}...");
        bool found = false;
        for(int i = 0; i < itensBiblioteca.Count(); i++)
        {
            //verificando se existe o titulo informado
            if(itensBiblioteca[i].Titulo == titulo)
            {
                Console.WriteLine("Id: " + itensBiblioteca[i].Id);
                Console.WriteLine("Título: " + itensBiblioteca[i].Titulo);
                Console.WriteLine("Autor: " + itensBiblioteca[i].Autor);

                itensBiblioteca[i].ExibirDescricaoInterna();
                found = true;
            }
            else
            {
                continue;
            }
        }
        if(found == false)
        {
            Console.WriteLine("Livro não encontrado.");
        }
        Console.WriteLine("==============");      
    }
    //sobrecarga do metodo acima que recebe um objeto da classe Livro por parâmetro
    public void BuscarPorTitulo(Livro livro)
    {
       Console.WriteLine("==============");
       Console.WriteLine($"Buscando item de título {livro.Titulo}...");
        bool found = false;
        for(int i = 0; i < itensBiblioteca.Count(); i++)
        {
            //verificando se existe o titulo informado
            if(itensBiblioteca[i].Titulo == livro.Titulo)
            {
                Console.WriteLine("Id: " + itensBiblioteca[i].Id);
                Console.WriteLine("Título: " + itensBiblioteca[i].Titulo);
                Console.WriteLine("Autor: " + itensBiblioteca[i].Autor);

                itensBiblioteca[i].ExibirDescricaoInterna();
                found = true;
            }
            else
            {
                continue;
            }
        }
        if(found == false)
        {
            Console.WriteLine("Livro não encontrado.");
        }
        Console.WriteLine("==============");
    }
    public void BuscarPorId(int id)
    {
        Console.WriteLine("==============");
        Console.WriteLine($"Buscando item de ID {id}...");
        bool found = false;
        for(int i = 0; i < itensBiblioteca.Count(); i++)
        {
            if(itensBiblioteca[i].Id == id)
            {
                Console.WriteLine("Id: " + itensBiblioteca[i].Id);
                Console.WriteLine("Título: " + itensBiblioteca[i].Titulo);
                Console.WriteLine("Autor: " + itensBiblioteca[i].Autor);

                itensBiblioteca[i].ExibirDescricaoInterna();
                found = true;
            }
            else
            {
                continue;
            }
        }
        if(found == false)
        {
            Console.WriteLine("Livro não encontrado.");
        }
        Console.WriteLine("==============");
    }
    //sobrecarga do metro BuscarPorId, recebendo como parâmetro um objeto da classe Livro
    public void BuscarPorId(Livro livro)
    {
        Console.WriteLine("==============");
        Console.WriteLine($"Buscando item de ID {livro.Id}...");

        bool found = false;
        for(int i = 0; i < itensBiblioteca.Count(); i++)
        {
            if(itensBiblioteca[i].Id == livro.Id)
            {
                Console.WriteLine("Id: " + itensBiblioteca[i].Id);
                Console.WriteLine("Título: " + itensBiblioteca[i].Titulo);
                Console.WriteLine("Autor: " + itensBiblioteca[i].Autor);

                itensBiblioteca[i].ExibirDescricaoInterna();
                found = true;
            }
            else
            {
                continue;
            }
        }
        if(found == false)
        {
            Console.WriteLine("Livro não encontrado.");
        }
        Console.WriteLine("==============");
    }
}