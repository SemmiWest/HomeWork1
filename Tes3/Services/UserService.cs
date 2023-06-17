using Tes3.Services.Dtos;
using Tes3.Tes3.Infrastructure;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using Tes3.Entites;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace Tes3.Services
{

    public interface IUserService
    {
        Task<List<UserDto>> GetAll();
        Task<long> Create(UserCreateDto userDto);
        Task<int> Delete(int id);


    }
    public class UserService : IUserService
    {
        private readonly ApplicationContext _dbContext;
        private readonly IMapper _mapper;

        public UserService(ApplicationContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public Task<List<UserDto>> GetAll()
        {
            return _dbContext.Users.ProjectTo<UserDto>(_mapper.ConfigurationProvider).ToListAsync();
        }
        public async Task<long> Create(UserCreateDto dto)
        {
            var entity = _mapper.Map<User>(dto);
            _dbContext.Users.Add(entity);
            await _dbContext.SaveChangesAsync();
            return entity.Id;
        }
        public async Task<int> Delete(int id)
        {
            var userItem = await _dbContext.Users.FindAsync(id);
            if (userItem != null) {
                _dbContext.Users.Remove(userItem);
                await _dbContext.SaveChangesAsync();
                return userItem.Id;
            }
            return 404;
        }


    }
}
