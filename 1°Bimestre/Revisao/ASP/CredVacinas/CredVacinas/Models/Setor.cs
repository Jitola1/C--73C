using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace CredVacinas.Models
{
    public class Setor
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo Obrigatorio")]
        public string Nome { get; set; } = string.Empty;

        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "Campo Obrigatorio")]
        public string ? Descricao { get; set; }
    }
}
