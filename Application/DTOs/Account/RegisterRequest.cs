using FluentValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Account
{
    public class RegisterRequest
    {       
        public string FirstName { get; set; }        
        public string LastName { get; set; }
        public string Email { get; set; }       
        public string UserName { get; set; }       
        public string Password { get; set; }

        [Required]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
    }

    public class RegisterRequestValidator : AbstractValidator<RegisterRequest>
    {
        public RegisterRequestValidator()
        {
            RuleFor(x => x.FirstName).NotNull();
            RuleFor(x => x.LastName).NotNull();
            RuleFor(x => x.Email).NotNull().EmailAddress();
            RuleFor(x => x.UserName).NotNull().MinimumLength(6);
            RuleFor(x => x.Password).NotNull().MinimumLength(6);
            RuleFor(x => x.ConfirmPasswordConfig).NotNull().Custom(x=>x.ConfirmPasswordConfig==x.Password);
        }
    }
}
