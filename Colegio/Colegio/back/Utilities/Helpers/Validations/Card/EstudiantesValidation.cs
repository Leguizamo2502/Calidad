using Entity.Dtos.Card;
using Entity.Dtos.Colegio;
using FluentValidation;

namespace Utilities.Helpers.Validations.Card
{
    public class EstudiantesValidation : AbstractValidator<EstudiantesDto>
    {
        public EstudiantesValidation()
        {
            RuleFor(x => x.Name)
           .NotEmpty().WithMessage("El nombre es obligatorio");

        }
    }
}
