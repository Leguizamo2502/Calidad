using Entity.Dtos.Card;
using Entity.Dtos.Colegio;
using FluentValidation;

namespace Utilities.Helpers.Validations.Card
{
    public class PeriodosValidation : AbstractValidator<PeriodosDto>
    {
        public PeriodosValidation()
        {
            RuleFor(x => x.ColegioId)
           .NotEmpty().WithMessage("El colegio id obligatorio");

        }
    }
}
