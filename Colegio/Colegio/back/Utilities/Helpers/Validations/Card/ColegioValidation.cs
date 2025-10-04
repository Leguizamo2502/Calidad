using Entity.Dtos.Card;
using Entity.Dtos.Colegio;
using FluentValidation;

namespace Utilities.Helpers.Validations.Card
{
    public class ColegioValidation : AbstractValidator<ColegioDto>
    {
        public ColegioValidation()
        {
            RuleFor(x => x.Name)
           .NotEmpty().WithMessage("El nombre es oblgatorio");

     
        }
    }
}
