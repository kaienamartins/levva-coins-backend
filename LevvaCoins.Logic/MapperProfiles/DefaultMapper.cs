using AutoMapper;
using LevvaCoins.Domain.Models;
using LevvaCoins.Logic.Dtos.CategoryDtos;
using LevvaCoins.Logic.Dtos.TransactionDtos;
using LevvaCoins.Logic.Dtos.UserDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LevvaCoins.Logic.MapperProfiles
{
    public class DefaultMapper : Profile
    {
        public DefaultMapper()
        {
            CreateMap<UserDto, User>().ReverseMap();
            CreateMap<CreateUserDto, User>().ReverseMap();



            CreateMap<TransactionDto, Transaction>().ReverseMap();
            CreateMap<CreateTransactionDto, Transaction>().ReverseMap();



            CreateMap<CategoryDto, Category>().ReverseMap();
            CreateMap<CreateCategoryDto, Category>().ReverseMap();
        }
    }
}
