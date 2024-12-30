using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using EFApp.Models;
using Microsoft.EntityFrameworkCore;

namespace EFApp.Data
{ 
    public class ProductDBContext : DbContext
    {
        public ProductDBContext(DbContextOptions<ProductDBContext> options):base(options)
        {
        }
        public DbSet<Product1> Product1s{set;get;}
        public DbSet<EmpValidations1> EmpValidations1s{set;get;}

        protected override void OnModelCreating(ModelBuilder modelBuilder){
            modelBuilder.Entity<Product1>().Property(x=>x.Id).ValueGeneratedNever();
            modelBuilder.Entity<EmpValidations1>().Property(x=>x.Empno).ValueGeneratedNever();

        }
    }
}