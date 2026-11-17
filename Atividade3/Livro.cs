public class Livro
{
    public string titulo;
    public string autor;
    public int numeroPaginas;

    public Livro(string titulo, string autor, int numeroPaginas)
    {
        this.titulo = titulo;
        this.autor = autor;

        if (numeroPaginas > 0)
        {
            this.numeroPaginas = numeroPaginas;
        }
        else
        {
            this.numeroPaginas = 1;
        }
    }

    public string getTitulo()
    {
        return this.titulo;
    }

    public string getAutor()
    {
        return this.autor;
    }

    public int getNumeroPaginas()
    {
        return this.numeroPaginas;
    }

    public override string ToString()
    {
        return $"Título: {this.titulo}\nAutor: {this.autor}\nNúmero de Páginas: {this.numeroPaginas}";
    }
}

