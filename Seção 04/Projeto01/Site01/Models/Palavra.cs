using Site01.Library.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Site01.Models
{
    public class Palavra
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "O campo'Nome' é obrigatório!")]
        [MaxLength(70, ErrorMessage = "O campo 'Nome' deve conter no máximo 70 caracteres!")]
        [UnicoNomePalavra]
        public string Nome { get; set; }
        public byte? Nivel { get; set; } //1 - fácil, 2 - Médio, 3 - Dificil
    }
}
