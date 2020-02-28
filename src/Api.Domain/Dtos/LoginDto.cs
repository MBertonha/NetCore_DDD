using System.Security.AccessControl;
using System.Diagnostics;
using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Dtos
{
    public class LoginDto
    {
        //Valida o formato e a mensagem do campo
        [Required(ErrorMessage = "Email é campo obrigatório para o LOGIN ...")]  //obigatório
        [EmailAddress(ErrorMessage = "E-mail em formato inválido ...")]
        [StringLength(100, ErrorMessage = "E-mail deve ter no máximo {1} cacacteres ...")]
        public string Email { get; set; }
    }
}
