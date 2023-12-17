using Br.Com.FiapInvestiments.Domain.Enums;

namespace Br.Com.FiapInvestiments.Domain.Entities
{
    public class User
    {
        public Guid Id { get; set; }

        public string Name { get; set; } = null!;

        public string Email { get; set; } = null!;

        public string Username { get; set; } = null!;

        public string Password { get; set; } = null!;

        public Role Role { get; set; }
        
    }
}
