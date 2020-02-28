using System.Threading.Tasks;
using Api.Domain.Dtos;
using Api.Domain.Entities;
using Api.Domain.Interfaces.Services.Users;
using Api.Domain.Repository;

namespace Api.Service.Services
{
    public class LoginService : ILoginService
    {
        private IUserRepository _repository;

        public LoginService(IUserRepository repository)
        {
            _repository = repository;
        }
        public async Task<object> FindByLogin(LoginDto user)
        {
            //Validação se o email do usuário é nulo ou em branco
            var baseUser = new UserEntity();
            if (user != null && !string.IsNullOrWhiteSpace(user.Email))
            {
                baseUser = await _repository.FindByLogin(user.Email);
                if (baseUser == null)
                {
                    return null;
                }
                else
                {
                    return baseUser;
                }
            }
            else
            {
                return null;
            }
        }
    }
}
