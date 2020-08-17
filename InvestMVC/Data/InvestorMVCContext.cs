using InvestMVC.Models;
using Microsoft.EntityFrameworkCore;


namespace InvestMVC.Data
{
    public class InvestorMVCContext : DbContext
    {

        public InvestorMVCContext(DbContextOptions<InvestorMVCContext> options) : base(options)
        
        {
            
        }

        public DbSet<User> User { get; set; }

    }
}
