using FluentValidation;
using FluentValidation.Models;
using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FluentValidationUI.Validations
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(u => u.FirstName).NotEmpty().WithMessage("Name is required.")
                .MaximumLength(20).WithMessage("max leng");
            RuleFor(u => u.LastName).NotEmpty().WithMessage("LastName is required.")
                .MaximumLength(20).WithMessage("max length is 20");
            RuleFor(u => u.Email)
                .NotEmpty()
                .WithMessage("Email is required.")
               .EmailAddress()
              .WithMessage("Invalid email format.");

            RuleFor(u => u.Address).NotEmpty().Length(10, 150).WithMessage("Maximum Address Length should between 10 and 150 character");
            RuleFor(u => u.Password).Password();


            RuleFor(u => u.ConfirmPassword).Equal(u => u.Password).WithMessage("Passwords do not matc");
            RuleFor(u => u.StudentNumber).NotEmpty().WithMessage("StudentNumber is required.")
                .Length(6, 8).WithMessage("StudentNumber between 6,8");
              
        }


    }
    public static class RuleBuilderExtensions
    {
        public static IRuleBuilder<T, string> Password<T>(this IRuleBuilder<T, string> ruleBuilder, int minimumLength = 5)
        {
            var options = ruleBuilder
                .NotEmpty().WithMessage("ErrorMessages.PasswordEmpty")
                .MinimumLength(minimumLength).WithMessage("ErrorMessages.PasswordLength")
                .Matches("[A-Z]").WithMessage("ErrorMessages.PasswordUppercaseLetter")
                .Matches("[a-z]").WithMessage("ErrorMessages.PasswordLowercaseLetter")
                .Matches("[0-9]").WithMessage("ErrorMessages.PasswordDigit")
                .Matches("[^a-zA-Z0-9]").WithMessage("ErrorMessages.PasswordSpecialCharacter");
            return options;
        }
    }
    //-----------------
    
}
