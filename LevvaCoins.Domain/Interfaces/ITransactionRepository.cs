using LevvaCoins.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LevvaCoins.Domain.Interfaces
{
    public interface ITransactionRepository

    {
        Transaction Create(Transaction transacao);
        Transaction? Get(int id);
        List<Transaction> GetAll();
        void Update(Transaction transacao);
        void Delete(int id);
        List<Transaction> SearchByDescription(string search);
    }
}
