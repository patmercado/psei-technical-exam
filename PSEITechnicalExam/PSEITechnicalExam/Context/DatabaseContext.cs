using Microsoft.EntityFrameworkCore;
using PSEITechnicalExam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PSEITechnicalExam.Context
{
    public class DatabaseContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            var connectionString = string.Format(@"Data Source=(LocalDb)\MSSQLLocalDB;Initial Catalog=dbTransactions;Integrated Security=True");
            options.UseSqlServer(connectionString);
        }

        public DbSet<TransactionModel> Transactions {get; set; }
    }
}
