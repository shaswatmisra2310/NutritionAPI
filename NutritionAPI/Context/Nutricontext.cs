using Microsoft.EntityFrameworkCore;
using NutritionAPI.Models;

namespace NutritionAPI.Context
{
    public class Nutricontext: DbContext
    {
        public DbSet<Brand> brandstable { get; set; }

        public DbSet<Product> productstable { get; set; }

        public DbSet<Nutritional_Info> Nutritiontable { get; set; }

        public DbSet<size_options> sizeoptionsstable { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer(@"Data Source=LAPTOP-7LJ7HTPU\SQLEXPRESS;Initial Catalog=NutritionTrackerAPIDb;Integrated Security=True");
        }
    }
}
