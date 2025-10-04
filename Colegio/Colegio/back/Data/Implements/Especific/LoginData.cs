using Entity.Context.Main;
using Entity.Dtos;
using Microsoft.EntityFrameworkCore;

namespace Data.Implements.Pizza
{
    public class LoginData
    {
        private readonly AplicationDbContext _context;

        public LoginData(AplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Object> ValidarUsuario(LoginDto login)
        {
            var userId = await _context.Colegios
             .Where(u => u.Name == login.Name && u.Password == login.Password)
             .Select(u => (int?)u.Id) // nullable para diferenciar si no existe
             .FirstOrDefaultAsync();

            bool existe = userId.HasValue;

            return new
            {
                id = userId ?? 0,
                Status = existe
            };
        }

    }
}