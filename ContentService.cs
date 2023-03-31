namespace optricon_home;

using Data;
using Models;

public interface IContentService
{
	Task AddAsync(Content content);
	Task UpdateAsync(Content content);
}

public class ContentService : IContentService
{
	private readonly AppDbContext _context;

	public ContentService(AppDbContext context)
	{
		_context = context;
	}

	public async Task AddAsync(Content content)
	{
		await _context.Content.AddAsync(content);
		await _context.SaveChangesAsync();
	}

	public async Task UpdateAsync(Content content)
	{
		_context.Content.Update(content);
		await _context.SaveChangesAsync();
	}
}