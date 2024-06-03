using PSEITechnicalExam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PSEITechnicalExam.Service
{
    public interface ITransactionService
    {
        List<TransactionModel> GetTransactions();
        List<TransactionModel> SaveTransactions(List<TransactionModel> transactions);
    }
}
