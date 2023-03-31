namespace optricon_home.Models;

using System.ComponentModel.DataAnnotations;

public class Content
{
	[Key]
	[Required]
	public string Id { get; set; }
	[Required]
	[MaxLength( 200 )]
	public string Text { get; set; }
	[Required]
	public string SectionName { get; set; }
}