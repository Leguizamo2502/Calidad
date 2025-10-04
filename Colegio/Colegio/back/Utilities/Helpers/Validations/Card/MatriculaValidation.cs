using Entity.Dtos.Card;
using Entity.Dtos.Colegio;
using FluentValidation;

namespace Utilities.Helpers.Validations.Card
{
    public class MatriculaValidation : AbstractValidator<MatriculaDto>
    {
        public MatriculaValidation()
        {
            RuleFor(x => x.ColegioId)
           .NotEmpty().WithMessage("El id de la carta es obligatoria");

        }
    }
}
