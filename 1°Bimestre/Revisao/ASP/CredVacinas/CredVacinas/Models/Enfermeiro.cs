using System.ComponentModel.DataAnnotations;
namespace CredVacinas.Models
{
    public class Enfermeiro
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo Obrigatorio")]
        public string Nome { get; set; } = string.Empty;

        [Display(Name = "RG")]
        [Required(ErrorMessage = "Campo Obrigatorio")]
        public string? Rg { get; set; }

        [Display(Name = "CPF")]
        [Required(ErrorMessage = "Campo Obrigatorio")]
        public string? Cpf { get; set; }

        [Display(Name = "Endereço")]
        [Required(ErrorMessage = "Campo Obrigatorio")]
        public string? Endereco { get; set; }

        [Display(Name = "Coren")]
        [Required(ErrorMessage = "Campo Obrigatorio")]
        public string? Coren { get; set; }

        [Display(Name = "Data de Admissão")]
        [Required(ErrorMessage = "Campo Obrigatorio")]
        public DateTime DataNascimento { get; set; }

    }
}
