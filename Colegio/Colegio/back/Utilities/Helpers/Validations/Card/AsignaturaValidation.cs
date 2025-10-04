using Entity.Dtos.Card;
using Entity.Dtos.Colegio;
using FluentValidation;

namespace Utilities.Helpers.Validations.Card
{
    public class AsignaturaValidation : AbstractValidator<AsignaturasDto>
    {
        public AsignaturaValidation()
        {
            RuleFor(x => x.Name)
           .NotEmpty().WithMessage("El nombre del jugador es obligatorio");

          
     
        }
    }
}
