 public class Livro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int NumeroPaginas { get; set; }

        // Construtor 1: Sem parâmetros
        public Livro()
        {
            Titulo = "Desconhecido";
            Autor = "Desconhecido";
            NumeroPaginas = 0;
        }

        // Construtor 2: Apenas o título
        public Livro(string titulo)
        {
            Titulo = titulo;
            Autor = "Desconhecido";
            NumeroPaginas = 0;
        }

        // Construtor 3: Título e autor
        public Livro(string titulo, string autor)
        {
            Titulo = titulo;
            Autor = autor;
            NumeroPaginas = 0;
        }

        // Construtor 4: Título, autor e número de páginas
        public Livro(string titulo, string autor, int numeroPaginas)
        {
            Titulo = titulo;
            Autor = autor;
            NumeroPaginas = numeroPaginas;
        }

        public void ExibirDados()
        {
            Console.WriteLine($"Livro: {Titulo} | Autor: {Autor} | Páginas: {NumeroPaginas}");
        }
    }
