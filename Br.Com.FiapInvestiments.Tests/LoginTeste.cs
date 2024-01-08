using Br.Com.FiapInvestiments.Api.DTO;
using System.ComponentModel.DataAnnotations;

namespace Br.Com.FiapInvestiments.Tests
{
    public class LoginTeste
    {
        [Fact]
        public void LoginEhRequerido()
        {
            var loginDTO = new LoginDTO
            {
                Password = "123456"
            };

            Assert.Contains(ValidateModel(loginDTO), v => v.MemberNames.Contains("Username") &&
                v.ErrorMessage.Contains("required"));
        }

        private IList<ValidationResult> ValidateModel(object model)
        {
            var validationResults = new List<ValidationResult>();
            var ctx = new ValidationContext(model, null, null);
            Validator.TryValidateObject(model, ctx, validationResults, true);
            return validationResults;
        }
    }
}
