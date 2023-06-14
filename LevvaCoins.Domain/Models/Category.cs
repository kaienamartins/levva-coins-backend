using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LevvaCoins.Domain.Models
{
    public class Category
    {
        public int Id
        {
            get; set;
        }
        public string? Description
        {
            get; set;
        }
        public virtual List<Transaction>? Transaction
        {
            get; set;
        }
    }
}
