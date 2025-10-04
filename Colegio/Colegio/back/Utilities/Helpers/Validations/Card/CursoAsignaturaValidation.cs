using Entity.Dtos.Card;
using Entity.Dtos.Colegio;
using FluentValidation;

namespace Utilities.Helpers.Validations.Card
{
    public class CursoAsignaturaValidation : AbstractValidator<CursoAsignaturaDto>
    {
        public CursoAsignaturaValidation()
        {
            RuleFor(x => x.CursoId)
           .NotEmpty().WithMessage("La carta es obligatoria");

          
     
        }
    }
}
