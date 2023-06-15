using LevvaCoins.Domain.Enums;
using LevvaCoins.Logic.Dtos.CategoryDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LevvaCoins.Logic.Dtos.TransactionDtos
{
    public class TransactionDto
    {
        public int Id
        {
            get; set;
        }
        public string Description
        {
            get; set;
        }
        public decimal Amount
        {
            get; set;
        }
        public DateTime CreatedAt
        {
            get; set;
        }
        public TypeTransactionEnum Type
        {
            get; set;
        }
        public CategoryDto Category
        {
            get; set;
        }
    }
}
