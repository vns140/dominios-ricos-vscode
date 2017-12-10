using FluentValidation;
using FluentValidation.Results;

namespace estudo.domain.ValueObjects.Validations
{
    public class EmailValidator : AbstractValidator<Email>
    {
       public EmailValidator()
       {
           RuleFor(email => email.Address).NotEmpty().WithMessage("O email é obrigatório");
           RuleFor(email => email.Address).EmailAddress().WithMessage("O email é inválido");
       }
    }
}