namespace Plataforma.Web.Data
{
    using Microsoft.EntityFrameworkCore;
    using Plataforma.Web.Data.Entities;
    using System;

 
    public class DataContext : DbContext
    {

        public DbSet<Product> Products { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
              
        }
    }
}
