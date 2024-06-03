using EFCore.BulkExtensions;
using PSEITechnicalExam.Context;
using PSEITechnicalExam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PSEITechnicalExam.Service
{
    public class TransactionService : ITransactionService
    {
        DatabaseContext _dbContext = null;

        public TransactionService(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }
        public List<TransactionModel> GetTransactions()
        {
            return _dbContext.Transactions.ToList();
        }

        public List<TransactionModel> SaveTransactions(List<TransactionModel> transactions)
        {
            _dbContext.BulkInsert(transactions);
            return transactions;
        }
    }
}
