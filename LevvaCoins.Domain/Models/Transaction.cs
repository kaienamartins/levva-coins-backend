using LevvaCoins.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LevvaCoins.Domain.Models
{
    public class Transaction
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
        public int CetegoryId
        {
            get; set;
        }
        public virtual Category Category
        {
            get; set;
        }
        public int UserId
        {
            get; set;
        }
        public virtual User User
        {
            get; set;
        }
    }
}
