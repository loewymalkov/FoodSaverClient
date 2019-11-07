using Microsoft.EntityFrameworkCore;

namespace FoodSaverClient.Models
{
  public class FoodSaverClientContext : DbContext
  {
    public virtual DbSet<User> Users { get; set; }
    public FoodSaverClientContext(DbContextOptions options) : base(options) { }
  }
}