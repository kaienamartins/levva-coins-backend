using AutoMapper;
using LevvaCoins.Domain.Interfaces;
using LevvaCoins.Domain.Models;
using LevvaCoins.Logic.Dtos.TransactionDtos;
using LevvaCoins.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LevvaCoins.Logic.Services
{
    public class TransactionService : ITransactionService
    {
        private readonly ITransactionRepository _transactionRepository;
        private readonly IMapper _mapper;



        public TransactionService(ITransactionRepository transactionRepository, IMapper mapper)
        {
            _transactionRepository = transactionRepository;
            _mapper = mapper;
        }



        public TransactionDto Create(int userId, CreateTransactionDto transacao)
        {
            var transaction = _mapper.Map<Transaction>(transacao);
            transaction.UserId = userId;

            var transactionCreated = _transactionRepository.Create(transaction);



            return _mapper.Map<TransactionDto>(transactionCreated);
        }



        public void Delete(int Id)
        {
            _transactionRepository.Delete(Id);
        }



        public TransactionDto Get(int Id)
        {
            var transaction = _transactionRepository.Get(Id);
            return _mapper.Map<TransactionDto>(transaction);
        }



        public List<TransactionDto> GetAll()
        {
            var transactions = _transactionRepository.GetAll();
            return _mapper.Map<List<TransactionDto>>(transactions);
        }



        public List<TransactionDto> SearchByDescription(string search)
        {
            var transactions = _transactionRepository.SearchByDescription(search);



            return _mapper.Map<List<TransactionDto>>(transactions);
        }



        public void Update(int id, UpdateTransactionDto categoria)
        {
            throw new NotImplementedException();
        }
    }
}
