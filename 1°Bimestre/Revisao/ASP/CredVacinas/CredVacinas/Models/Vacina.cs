using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace CredVacinas.Models
{
    public class Vacina
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo Obrigatorio")]
        public string Lote { get; set; } = string.Empty;

        [Required(ErrorMessage = "Campo Obrigatorio")]
        public int quantidade { get; set; }

        [Display(Name = "Data de Fabricação")]
        [Required(ErrorMessage = "Campo Obrigatorio")]
        public DateTime DataNascimento { get; set; }

        [Display(Name = "Data de Vencimento")]
        [Required(ErrorMessage = "Campo Obrigatorio")]
        public DateTime dataVenc { get; set; }

    }
}
