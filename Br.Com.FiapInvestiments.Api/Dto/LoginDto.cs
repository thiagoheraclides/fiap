using System.ComponentModel.DataAnnotations;

namespace Br.Com.FiapInvestiments.Api.DTO
{
    public class LoginDTO
    {
        [Required(ErrorMessage = "The field {0} is required.")]
        public string Username { get; set; } = null!;

        [Required(ErrorMessage = "The field {0} is required.")]
        public string Password { get; set; } = null!;

    }
}
