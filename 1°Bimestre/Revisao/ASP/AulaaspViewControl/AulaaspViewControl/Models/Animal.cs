using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;

namespace AulaaspViewControl.Models
{
        [Table("Animal")]
    public class Animal
    {
        [Column("id")]
        [Key]
        public int Id_animal { get; set; }

        [Column("nome")]
        [Required(ErrorMessage = "Campo obrigatorio")]
        public string ? Nome { get; set; }

        [Column("especie")]
        [Required(ErrorMessage = "Campo obrigatorio")]
        public string ? Especie { get; set; }

        [Column("data_nascimento")]
        [Display(Name = "Data de Nascimetno")]
        public string ? DataNascimento { get; set; }

    }
}
