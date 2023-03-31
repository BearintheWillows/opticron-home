namespace optricon_home.Services;

using Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Models;

public interface IContentService
{
	Task<Content> GetContentAsync();
}

public class ContentService : IContentService
{
	private readonly AppDbContext _context;

	public ContentService(AppDbContext context)
	{
		_context = context;
	}

	public async Task<Content> GetContentAsync()
	{
		List<MediaObjects> mediaObjects = await _context.MediaObjects.ToListAsync();
		List<SpecialOffers> specialOffers = await _context.SpecialOffers.ToListAsync();
		List<ProductCategories> productCategories = await _context.ProductCategories.ToListAsync();

		var content = new Content() { MediaObjectsList = mediaObjects, SpecialOffersList = specialOffers, ProductCategoriesList = productCategories};
		
		return content;
	}
}