﻿using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFrameWork
{
    //Context : Db tabloları ile proje classlarını bağlamak ...
    public class NortwindContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Northwind;Trusted_Connection=true");
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Personel> Personels { get; set; }
        public DbSet<Order> Orders { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //fluent mapping....
            //modelBuilder.HasDefaultSchema("admin");
            modelBuilder.Entity<Personel>().ToTable("Employees");
            modelBuilder
                .Entity<Personel>().Property(p => p.Id)
                .HasColumnName("EmployeeId");
            modelBuilder
                .Entity<Personel>().Property(p => p.Name)
                .HasColumnName("FirstName");
            modelBuilder
                .Entity<Personel>().Property(p => p.Surname)
                .HasColumnName("LastName");

        }

    }
}
