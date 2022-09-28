using Energify.Data.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Energify.Data
{
    public class EnergifyDbContext: DbContext
    {
        public EnergifyDbContext(DbContextOptions<EnergifyDbContext> options) : base(options)
        {
            this.Database.EnsureCreated();

        }
        public DbSet<UserEntity> UsersList { get; set; }
        public DbSet<ProductEntity> ProductsList { get; set; }
        public DbSet<TicketEntity> TicketList { get; set; }


    }
}
