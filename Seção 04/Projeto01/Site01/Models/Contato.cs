using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Site01.Models
{
    public class Contato
    {
        [Required(ErrorMessage = "O campo'Nome' é obrigatório!")]
        [MaxLength(50, ErrorMessage = "O campo 'Nome' deve conter no máximo 50 caracteres!")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "O campo'Nome' é obrigatório!")]
        [MaxLength(70, ErrorMessage = "O campo 'E-mail' deve conter no máximo 70 caracteres!")]
        [EmailAddress(ErrorMessage = "O campo e-mail é inválido!")]
        public string Email { get; set; }
        [Required(ErrorMessage = "O campo'Nome' é obrigatório!")]
        [MaxLength(70, ErrorMessage = "O campo 'Assunto' deve conter no máximo 70 caracteres!")]
        public string Assunto { get; set; }
        [Required(ErrorMessage = "O campo'Nome' é obrigatório!")]
        [MaxLength(2000, ErrorMessage = "O campo 'Mensagem' deve conter no máximo 200 caracteres!")]
        public string Mensagem { get; set; }
    }
}
