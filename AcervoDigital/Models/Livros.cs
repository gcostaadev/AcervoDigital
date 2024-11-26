namespace AcervoDigital.Models
{
    public class Livro
    {
        public int IdLivro { get;  set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Isbn { get; set; }
        public int AnoDePublicacao { get; set; }

        public Livro() 
        {
            
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"ID: {IdLivro} - Título: {Titulo} - Autor: {Autor} - ISBN: {Isbn} - Ano de Publicação: {AnoDePublicacao}\n");
        }

    }
}
