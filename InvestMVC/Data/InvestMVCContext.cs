using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using InvestMVC.Models;

namespace InvestMVC.Data
{
    public class InvestMVCContext : DbContext
    {
        public InvestMVCContext (DbContextOptions<InvestMVCContext> options)
            : base(options)
        {
        }

        public DbSet<InvestMVC.Models.User> User { get; set; }

        public DbSet<InvestMVC.Models.Company> Company { get; set; }

        public DbSet<InvestMVC.Models.Trade> Trade { get; set; }
    }
}
