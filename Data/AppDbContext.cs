namespace optricon_home.Data;

using Extentions;
using Microsoft.EntityFrameworkCore;
using Models;

public class AppDbContext : DbContext
{
	public AppDbContext( DbContextOptions<AppDbContext> options ) : base( options )
	{
	}

	public DbSet<Content> Content { get; set; }
	
	protected override void OnModelCreating( ModelBuilder modelBuilder )
	{
		modelBuilder.Seed();
	}
}
