using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Menu> Menus { get; set; }
    public DbSet<Dish> Dishes { get; set; }
}

public class Menu
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
}

public class Dish
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
}
