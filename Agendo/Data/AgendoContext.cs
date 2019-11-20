using Agendo.Models;
using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Agendo.Data
{
    public class AgendoContext : DbContext
    {
        public AgendoContext(DbContextOptions<AgendoContext> options) 
            : base(options)
        {

        }
        public DbSet<UserAccount> Users  { get; set; }
        public DbSet<Events> Events { get; set; }
    }
}
