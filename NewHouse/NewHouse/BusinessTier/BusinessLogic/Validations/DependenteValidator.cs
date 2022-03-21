using FluentValidation;
using NewHouse.Models;

namespace NewHouse.BusinessTier.BusinessLogic.Validations
{
    public class DependenteValidator : AbstractValidator<Dependente>
    {
        public DependenteValidator()
        {
            RuleFor(d => d.Debilitado)
                .NotNull().WithMessage("Debilitado obrigatório.");
        }
    }
}