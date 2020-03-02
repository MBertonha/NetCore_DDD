using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Dtos.User;
using Api.Domain.Entities;

namespace Api.Domain.Interfaces.Services.Users
{
    public interface IUserService
    {
        Task<UserDto> Get(Guid id);
        Task<IEnumerable<UserDto>> GetAll(); //Pega todos os usuários e retorna uma lista
        Task<UserDtoCreateResult> Post(UserDto user);
        Task<UserDtoUpdateResult> Put(UserDto user);
        Task<bool> Delete(Guid id);
    }
}
