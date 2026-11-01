using System.ComponentModel.DataAnnotations;

namespace ApiJwt.Models
{
    public class LoginRequest
    {
        [Required(ErrorMessage = "Usuário é obrigatório")]
        public string Usuario { get; set; }

        [Required(ErrorMessage = "Senha é obrigatória")]
        public string Senha { get; set; }
    }
}