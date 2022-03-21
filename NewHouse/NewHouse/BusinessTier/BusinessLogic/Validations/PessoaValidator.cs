using FluentValidation;
using NewHouse.Models;

namespace NewHouse.BusinessTier.BusinessLogic.Validations
{
    public class PessoaValidator : AbstractValidator<Pessoa>
    {
        public PessoaValidator()
        {
            RuleFor(p => p.Nome)
                .NotNull().WithMessage("O preenchimento do campo nome é obrigatório.")
                .Length(10, 100).WithMessage("O campo nome deve ter entre {MinLength} e {MaxLength} caracteres.");

            RuleFor(p => p.CPF)
                .NotNull().WithMessage("O CPF é obrigatório.")
                .Must(p => p != null ? true : false).WithMessage("CPF inválido.");
        }
    }
}