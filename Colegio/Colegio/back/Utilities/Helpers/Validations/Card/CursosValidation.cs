using Entity.Dtos.Card;
using Entity.Dtos.Colegio;
using FluentValidation;

namespace Utilities.Helpers.Validations.Card
{
    public class CursosValidation : AbstractValidator<CursosDto>
    {
        public CursosValidation()
        {
            RuleFor(x => x.Name)
           .NotEmpty().WithMessage("El nombre es obligarorio");

          
     
        }
    }
}
