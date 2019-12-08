using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheKidPage.Models;
using Microsoft.EntityFrameworkCore;


namespace TheKidPage.Repositories
{
    public class ApplicaitonDbContext : DbContext
    { 
            public ApplicaitonDbContext(
               DbContextOptions<ApplicaitonDbContext> options) : base(options) { }

            public DbSet<Jokes> Jokes { get; set; }
            public DbSet<User> Users { get; set; }
           
           
        
    }
}
