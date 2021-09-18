using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using Rubic_test.Models;
using System.Threading.Tasks;

namespace Rubic_test.Controllers
{
    public class BudgetContext : DbContext
    {
        public BudgetContext(DbContextOptions<BudgetContext> options)
            : base(options)
        { 
            
        }

        public DbSet<Budget> Budgets { get; set; }
    }
}
