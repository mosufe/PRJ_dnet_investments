using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using InvestMVC.Data;
using System;
using System.Linq;

namespace InvestMVC.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new InvestorMVCContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<InvestorMVCContext>>()))
            {
                // Look for any movies.
                if (context.User.Any())
                {
                    return;   // DB has been seeded
                }

                context.User.AddRange(
                    new User
                    {
                        name = "Guilherme",
                        surname = "Jácome de Paula",
                        email = "guilhermejp4@gmail.com",
                        phone = 1774548355
                    },
                    new User
                    {
                        name = "Laura",
                        surname = "Cunha Barbosa",
                        email = "lauradrcb@yahoo.com.br",
                        phone = 1020304050
                    },
                    new User
                    {
                        name = "Ana Cristina",
                        surname = "Pereira Jácome de Paula",
                        email = "anajacome@gmail.com",
                        phone = 171936254
                    },
                    new User
                    {
                        name = "Roberto",
                        surname = "de Paula Santos",
                        email = "robertorobpaul@gmail.com",
                        phone = 46813543
                    }
                );
                context.SaveChanges();
            }
        }
    }
}