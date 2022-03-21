using FluentValidation;
using NewHouse.Models;

namespace NewHouse.BusinessTier.BusinessLogic.Validations
{
    public class FamiliaValidator : AbstractValidator<Familia>
    {
        public FamiliaValidator()
        {
            RuleFor(v => v.Dependentes)
                .NotNull().WithMessage("Lista de dependentes não pode estar vazia.")
                .Must(i => i != null ? i.Count > 0 : false).WithMessage("Lista de dependentes deve possuir pelo menos 1 item.");

            //RuleForEach(e => e.NaoDependentes).SetValidator(new NãoDependenteValidator());
        }
    }
}