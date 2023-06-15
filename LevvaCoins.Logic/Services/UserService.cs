using AutoMapper;
using LevvaCoins.Domain.Interfaces;
using LevvaCoins.Domain.Models;
using LevvaCoins.Logic.Dtos.UserDtos;
using LevvaCoins.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LevvaCoins.Logic.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }



        public UserDto Create(CreateUserDto usuario)
        {
            var user = _mapper.Map<User>(usuario);
            var userCreated = _userRepository.Create(user);



            return _mapper.Map<UserDto>(userCreated);
        }



        public void Delete(int Id)
        {
            _userRepository.Delete(Id);
        }



        public UserDto Get(int Id)
        {
            var user = _userRepository.Get(Id);



            return _mapper.Map<UserDto>(user);
        }



        public List<UserDto> GetAll()
        {
            var users = _userRepository.GetAll();



            return _mapper.Map<List<UserDto>>(users);
        }



        public void Update(int id, UpdateUserDto categoria)
        {
            throw new NotImplementedException();
        }
    }
}
