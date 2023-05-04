using System.ComponentModel.DataAnnotations;

namespace Asp.Models
{
    public class Aluno
    {
        public int Id { get; set; }
        [Required (ErrorMessage = "Campo Obrigatorio")]
        public string Nome { get; set; } = string.Empty;

        [Display(Name = "Data de Nascimento")]
        [Required(ErrorMessage = "Campo Obrigatorio")]
        public DateTime DataNascimento { get; set;}

        [Display(Name = "Enderco")]
        [Required(ErrorMessage = "Campo Obrigatorio")]
        public string Endereco { get; set; } = string.Empty;

        [Display(Name = "RG")]
        [Required(ErrorMessage = "Campo Obrigatorio")]
        public string ? Rg { get; set; }

        [Display(Name = "CPF")]
        [Required(ErrorMessage = "Campo Obrigatorio")]
        public string ? Cpf { get; set; }

        [Display(Name = "Telefone")]
        [Required(ErrorMessage = "Campo Obrigatorio")]
        public string ? Telefone { get; set; }
    }
}
