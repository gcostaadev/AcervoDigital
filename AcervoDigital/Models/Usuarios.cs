namespace AcervoDigital.Models
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }


        public Usuario()
        {

        }

        public void ExibirInformacoesDeUsuario()
        {
            Console.WriteLine($"ID: {IdUsuario} - Nome: {Nome} - Email: {Email}\n");
        }
    }

}
