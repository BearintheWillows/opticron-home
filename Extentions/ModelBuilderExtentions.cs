namespace optricon_home.Extentions;

using Microsoft.EntityFrameworkCore;
using Models;

public static class ModelBuilderExtentions
{
	public static void Seed(this ModelBuilder modelBuilder)
	{
		modelBuilder.Entity<Content>()
		            .HasData( new { Id = "1", Text = "Heading 1", SectionName = "section1-headings", } );
	}
}