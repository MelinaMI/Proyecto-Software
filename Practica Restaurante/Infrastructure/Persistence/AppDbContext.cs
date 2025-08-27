using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        //Declaro las entidades
        public DbSet<Category> Categories { get; set; }
        public DbSet<DeliveryType> DeliveryTypes { get; set; }
        public DbSet<Dish>Dishes { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Status> Statuses { get; set; }


        //modelo las relaciones
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Relacion 1:1 
            modelBuilder.Entity<Category>(entity =>
            {
               // entity.ToTable("Category"); //nombre de la tabla
                entity.HasKey(c => c.Id); //PK
            });
        }

    }
}
