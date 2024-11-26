namespace AcervoDigital.Models
{
    public class Emprestimo 
    {
        public int IdEmprestimo { get; set; }
        public DateTime DataDeEmprestimo { get; set; }
        public DateTime DataDeDevolucao { get; set; }
        public DateTime? DataDevolucaoReal { get; set; } 

        public Emprestimo()
        {

        }

        public void ExibirInformacoesDeEmprestimo()
        {
            Console.WriteLine($"ID: {IdEmprestimo} - Data de emprestimo: {DataDeEmprestimo:dd/MM/yyyy} - Data de Devolução: {DataDeDevolucao: dd/MM/yyyy}\n");
        }



    }


}
