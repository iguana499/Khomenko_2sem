using Microsoft.EntityFrameworkCore;
using AirPlaneFactoryDatabaseImplement.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AirPlaneFactoryDatabaseImplement
{
    public class AirPlaneFactoryDatabase : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured == false)
            {
                optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-IGUANA\SQLEXPRESS;Initial Catalog=AirPlaneFactoryDatabase;Integrated Security=True;MultipleActiveResultSets=True;");
            }
            base.OnConfiguring(optionsBuilder);
        }
        public virtual DbSet<Component> Components { set; get; }
        public virtual DbSet<Product> Products { set; get; }
        public virtual DbSet<ProductComponent> ProductComponents { set; get; }
        public virtual DbSet<Order> Orders { set; get; }
    }
}