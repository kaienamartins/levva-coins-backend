using LevvaCoins.Logic.Dtos.TransactionDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LevvaCoins.Logic.Interfaces
{
    public interface ITransactionService
    {
        TransactionDto Create(int userId,CreateTransactionDto transacao);
        TransactionDto Get(int Id);
        List<TransactionDto> GetAll();
        void Update(int id, UpdateTransactionDto transacao);
        void Delete(int Id);
        List<TransactionDto> SearchByDescription(string search);
    }
}
