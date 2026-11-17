int x = 0;





Livro CadastrarLivro()
{
    Console.WriteLine("Informe o titulo do livro: ");
    string titulo = Console.ReadLine();
    Console.WriteLine("Informe o autor do livro: ");
    string autor = Console.ReadLine();
    int paginas = 0;
    while (paginas <= 0)
    {
        Console.WriteLine("Informe a quantidade de paginas do livro: ");
        paginas = int.Parse(Console.ReadLine());
    }

    return new Livro (titulo, autor, paginas);
}

 Livro[] MontarEstanteDeLivros()
{
    while (x == 0)
    {
        Console.WriteLine("Informe quantos livros vc quer guardar: ");
        x = int.Parse(Console.ReadLine());

        if (x <= 0)
        {
            x = 0;
        }
    }
    Livro[] livros = new Livro[x];

    for (int i = 0; i < livros.Length; i++)
    {
        livros[i] = CadastrarLivro();
    }
    return livros;
}

void MostrarEstanteDeLivros(Livro[] books)
{
    for (int i = 0;i < books.Length;i++)
    {
        Console.WriteLine(books[i]);
    }
}

MostrarEstanteDeLivros(MontarEstanteDeLivros());
