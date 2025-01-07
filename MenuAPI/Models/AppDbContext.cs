using MenuBackend.Models;
using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public DbSet<User> Users { get; set; } = null!;
    public DbSet<Company> Companies { get; set; } = null!;
    public DbSet<Menu> Menus { get; set; } = null!;
    public DbSet<Dish> Dishes { get; set; } = null!;
    public DbSet<UserCompany> UserCompanies { get; set; } = null!;
    public DbSet<MenuDish> MenuDishes { get; set; } = null!;

    public AppDbContext(DbContextOptions<AppDbContext> options)
    :base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<UserCompany>()
            .HasKey(uc => new { uc.UserId, uc.CompanyId });

        modelBuilder.Entity<MenuDish>()
            .HasKey(md => new { md.MenuId, md.DishId });

        base.OnModelCreating(modelBuilder);
    }
}