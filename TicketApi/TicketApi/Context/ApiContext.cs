using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketApi.Models;

namespace TicketApi.Context
{
    public class ApiContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Data Source=LAPTOP-6U2NJESB\sqlexpress;Initial Catalog=TicketDB;Integrated Security=True");
        }
        public DbSet<CustomerModel> Customers { get; set; }
        public DbSet<EventModel> Events { get; set; }
        public DbSet<TicketModel> Tickets { get; set; }
    }
}
