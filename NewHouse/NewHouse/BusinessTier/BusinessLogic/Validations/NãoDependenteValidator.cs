using FluentValidation;
using NewHouse.Models;

namespace NewHouse.BusinessTier.BusinessLogic.Validations
{
    public class NãoDependenteValidator : AbstractValidator<NaoDependente>
    {
        public NãoDependenteValidator()
        {
            RuleFor(n => n.Renda)
                .NotNull().WithMessage("A renda deve ser informada.")
                .GreaterThan(0).WithMessage("A renda deve ser maior que {ComparisonValue}.");
        }
    }
}