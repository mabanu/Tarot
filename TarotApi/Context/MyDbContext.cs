using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using TarotApi.Models;

namespace TarotApi.Context
{
    public class MyDbContext : DbContext
    {
        public DbSet<Card> Cards { get; set; }
        public DbSet<TarotPrediction> History { get; set; }
        
        public MyDbContext()
        {
        }

        public MyDbContext(DbContextOptions<MyDbContext> options)
            : base(options)
        {
        }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=localhost,1433;Database=TarotDB;User Id=sa;Password=Password_2_Change_4_Real_Cases_&;Integrated Security=false;TrustServerCertificate=true");
        }
    }
}
