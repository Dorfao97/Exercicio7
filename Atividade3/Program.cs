Console.WriteLine("Informe o título do livro: ");
string titulo = Console.ReadLine();

Console.WriteLine("Informe o autor do livro: ");
string autor = Console.ReadLine();

Console.WriteLine("Informe o número de páginas: ");
int paginas = int.Parse(Console.ReadLine());

Livro livro1 = new Livro(titulo, autor, paginas);
Console.WriteLine();
Console.WriteLine(livro1);
