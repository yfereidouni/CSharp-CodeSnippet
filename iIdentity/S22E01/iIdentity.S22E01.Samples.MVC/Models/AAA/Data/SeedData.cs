using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace iIdentity.S22E01.Samples.MVC.Models.AAA.Data;

public class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new AAADbContext(serviceProvider
            .GetRequiredService<DbContextOptions<AAADbContext>>()))
        {
            if (context.BadPasswords.Any())
            {
                return;
            }
            context.BadPasswords.AddRange(
                new BadPassword { BadPasswordText = "123" },
                new BadPassword { BadPasswordText = "321" },
                new BadPassword { BadPasswordText = "abc" },
                new BadPassword { BadPasswordText = "cba" },
                new BadPassword { BadPasswordText = "AAA" },
                new BadPassword { BadPasswordText = "aaa" },
                new BadPassword { BadPasswordText = "bbb" },
                new BadPassword { BadPasswordText = "ccc" },
                new BadPassword { BadPasswordText = "1234abcd" },
                new BadPassword { BadPasswordText = "abcd1234" }
            );
            context.SaveChanges();
        }
    }
}