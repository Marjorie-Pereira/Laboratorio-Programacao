//instanciando valores
Livro livro1 = new Livro(1, "Morte no Nilo", "Agatha Christie");
Livro livro2 = new Livro(2, "O Natal de Hercule Poirot", "Agatha Christie");
Livro livro3 = new Livro(3, "Verity", "Colleen Hoover");

Biblioteca biblioteca = new Biblioteca();

//passando um valor específico para o atributo opcional DescricaoInterna
livro2.DescLivro = "Hercule Poirot's Christmas é um romance policial de Agatha Christie, publicado em 1938.";
livro3.DescLivro = "Finalista do prêmio Goodreads como melhor romance de 2019, \nVerity é o primeiro thriller de Colleen Hoover e deixa os leitores envolvidos do começo ao fim. ";


//testando programa
biblioteca.AdicionarItem(livro1);
biblioteca.AdicionarItem(livro2);
biblioteca.AdicionarItem(livro3);

biblioteca.BuscarPorTitulo("Morte no Nilo");
biblioteca.BuscarPorId(2);

biblioteca.BuscarPorTitulo(livro3);
biblioteca.BuscarPorId(livro3);

biblioteca.RemoverItem(livro1);

biblioteca.BuscarPorId(10);
biblioteca.BuscarPorTitulo("Morte no Nilo");

