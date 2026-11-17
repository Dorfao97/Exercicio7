public class Livro
{
    public string Titulo;
    public string Autor;
    public int NumeroPaginas;

    public Livro(string titulo, string autor, int numeroPaginas)
    {
        this.Titulo = titulo;
        this.Autor = autor;

        if (numeroPaginas > 0)
        {
            this.NumeroPaginas = numeroPaginas;
        }
        else
        {
            this.NumeroPaginas = 1;
        }
    }

    public string getTitulo()
    {
        return this.Titulo;
    }

    public string getAutor()
    {
        return this.Autor;
    }

    public int getNumeroPaginas()
    {
        return this.NumeroPaginas;
    }

    public override string ToString()
    {
        return $"Título: {this.Titulo}\nAutor: {this.Autor}\nNúmero de Páginas: {this.NumeroPaginas}";
    }
}

