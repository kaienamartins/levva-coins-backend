using LevvaCoins.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LevvaCoins.Logic.Dtos.TransactionDtos
{
    public class CreateTransactionDto
    {
        public string Description
        {
            get; set;
        }
        public decimal Amount
        {
            get; set;
        }
        public TypeTransactionEnum Type
        {
            get; set;
        }
        public int CategoryId
        {
            get; set;
        }
        public int UserId
        {
            get; set;
        }
    }
}
