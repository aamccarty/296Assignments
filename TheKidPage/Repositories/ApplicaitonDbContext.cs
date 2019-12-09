using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheKidPage.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.SqlServer;


namespace TheKidPage.Repositories
{
    public class ApplicaitonDbContext : DbContext
    { 
            public ApplicaitonDbContext(
               DbContextOptions<ApplicaitonDbContext> options) : base(options) { }

            public DbSet<Joke> Jokes { get; set; }
            public DbSet<User> Users { get; set; }
           
           
        
    }
}
