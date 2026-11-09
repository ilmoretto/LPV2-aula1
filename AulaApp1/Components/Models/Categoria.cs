using System.ComponentModel.DataAnnotations;

namespace AulaApp1.Components.Models
{
    public class Categoria
    {
        [Required(ErrorMessage = "Informe o nome.")]
        [MinLength(3, ErrorMessage = "O nome deve ter no mínimo 3 caracteres.")]
        [MaxLength(50, ErrorMessage = "O nome deve ter no máximo 50 caracteres.")]
        public string Nome { get; set; } = "";

        [Range(0, 100000, ErrorMessage = "A quantidade deve ser entre 0 e 100000.")]
        public int Quantidade { get; set; }
    }
}

