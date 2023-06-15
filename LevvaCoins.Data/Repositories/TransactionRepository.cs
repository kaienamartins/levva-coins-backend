using LevvaCoins.Domain.Interfaces;
using LevvaCoins.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LevvaCoins.Data.Repositories
{
    public class TransactionRepository : ITransactionRepository
    {
        private readonly Context _context;



        public TransactionRepository(Context context)
        {
            _context = context;
        }



        public Transaction Create(Transaction transacao)
        {
            transacao.CreatedAt = DateTime.Now;
            _context.Transacao.Add(transacao);
            _context.SaveChanges();
            return transacao;
        }



        public void Delete(int id)
        {
            var transaction = _context.Transacao.Find(id);
            _context.Transacao.Remove(transaction);
            _context.SaveChanges();
        }



        public Transaction? Get(int id)
        {
            return _context.Transacao.Find(id);
        }



        public List<Transaction> GetAll()
        {
            return _context.Transacao.Include(x => x.Category).AsNoTracking()
                                        .OrderByDescending(x => x.CreatedAt)
                                        .ToList();
        }



        public List<Transaction> SearchByDescription(string search)
        {
            return _context.Transacao.Include(x => x.Category)
                .Where(x =>
                        EF.Functions.Like(x.Description, $"%{search}%") ||
                        EF.Functions.Like(x.Category.Description, $"%{search}%"))
                .OrderByDescending(x => x.CreatedAt)
                .ToList();
        }



        public void Update(Transaction transacao)
        {
            _context.Transacao.Update(transacao);
            _context.SaveChanges();
        }
    }
}
