namespace optricon_home.Data;

using Extentions;
using Microsoft.EntityFrameworkCore;
using Models;

public class AppDbContext : DbContext
{
	public AppDbContext( DbContextOptions<AppDbContext> options ) : base( options )
	{
	}

	public DbSet<MediaObjects> MediaObjects { get; set; }
	public DbSet<SpecialOffers> SpecialOffers { get; set; }
	
	public DbSet<ProductCategories> ProductCategories { get; set; }

	protected override void OnModelCreating( ModelBuilder modelBuilder )
	{
		modelBuilder.Seed();
	}
}
