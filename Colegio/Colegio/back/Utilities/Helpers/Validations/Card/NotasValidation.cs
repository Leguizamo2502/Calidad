using Entity.Dtos.Card;
using Entity.Dtos.Colegio;
using FluentValidation;

namespace Utilities.Helpers.Validations.Card
{
    public class NotasValidation : AbstractValidator<NotasDto>
    {
        public NotasValidation()
        {
            RuleFor(x => x.MatriculaId)
           .NotEmpty().WithMessage("El id de matricula es obligatorio");

        }
    }
}
