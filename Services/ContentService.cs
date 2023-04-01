namespace optricon_home.Services;

using Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Models;

public interface IContentService
{
	Task<Content> GetContentAsync();
	Task<bool> UpdateMediaObjectsAsync(MediaObjects content);
	Task<bool> UpdateSpecialOffersAsync(SpecialOffers content);
	Task<bool> UpdateProductCategoriesAsync(ProductCategories content);
	
}

public class ContentService : IContentService
{
	private readonly AppDbContext _context;

	public ContentService(AppDbContext context)
	{
		_context = context;
	}
	
	public async Task<bool> UpdateMediaObjectsAsync(MediaObjects content)
	{
		MediaObjects storedContent = await _context.MediaObjects.FindAsync( content.Id );
		
		Console.WriteLine("ContentService: UpdateMediaObjectsAsync: " + content.Id + " " + content.Title + " " + content.Text + " " + content.ButtonText + "");
		if ( content.Title != null )
		{
			storedContent.Title = content.Title;
		}
		if ( content.Text != null )
		{
			storedContent.Text = content.Text;
		}
		if ( content.ButtonText != null )
		{
			storedContent.ButtonText = content.ButtonText;
		}
		
		_context.MediaObjects.Update(storedContent);
		await _context.SaveChangesAsync();
		
		return true;
	}
	
	public async Task<bool> UpdateSpecialOffersAsync(SpecialOffers content)
	{
		_context.SpecialOffers.Update(content);

		await _context.SaveChangesAsync();
		
		return true;
	}
	
	public async Task<bool> UpdateProductCategoriesAsync(ProductCategories content)
	{
		_context.ProductCategories.Update(content);

		await _context.SaveChangesAsync();
		
		return true;
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