using FluentValidation;
using LearnNet6.Models;

namespace LearnNet6.Validator
{
    public class RegisterModelValidator : AbstractValidator<RegisterModel>
    {
        public RegisterModelValidator()
        {
            RuleFor(x => x.ConfirmPassword).Equal(x => x.Password);
            RuleFor(x => x.Email).EmailAddress().WithMessage("Đcm nhập email vào hộ");
            RuleFor(x => x.Password).MaximumLength(10);
        }
    }
}
