namespace Asp.Models
{
    public class Aluno
    {
        public int Id { get; set; } 

        public string Nome { get; set; } = string.Empty;

        public DateTime DataNascimento { get; set;}

        public string Endereco { get; set; } = string.Empty;

        public string ? Rg { get; set; }

        public string ? Cpf { get; set; }

        public string ? Telefone { get; set; }
    }
}
