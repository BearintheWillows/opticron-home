namespace optricon_home.Data;

using Microsoft.EntityFrameworkCore;
using Models;

public class AppDbContext : DbContext
{
	public AppDbContext( DbContextOptions<AppDbContext> options ) : base( options )
	{
	}

	public DbSet<Content> Content { get; set; }
}
