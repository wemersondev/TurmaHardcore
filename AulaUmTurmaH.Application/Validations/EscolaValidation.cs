using AulaUmTurmaH.Application.DTOs;
using FluentValidation;

namespace AulaUmTurmaH.Application.Validations
{
    public class EscolaValidation : AbstractValidator<EscolaDTO>
    {
        public EscolaValidation()
        {
            RuleFor(x => x.Nome)
                .MaximumLength(3)
                .WithMessage("O campo nome precisa estar ter no mínimo 3 caracteres");

            RuleFor(x => x.Nome)
                .MaximumLength(30)
                .WithMessage("O campo nome precisa ter no máximo 30 caracteres");

            RuleFor(x => x.CNPJ)
                .NotEmpty()
                .NotNull()
                .WithMessage("O campo CNPJ é obrigatório");

            RuleFor(x => x.Email)
                .EmailAddress()
                .WithMessage("Digite um e-mail válido");
        }
    }
}
