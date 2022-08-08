using System.Data.Entity;

namespace RecapProject1.Entities
{
    public class CategoryBase
    {
        public DbSet<Category> Categories { get; set; }
    }
}