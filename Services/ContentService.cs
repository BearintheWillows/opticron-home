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
		var specialOffer = await _context.SpecialOffers.FindAsync( content.Id );

		if ( content.ItemText != null )
		{
			specialOffer.ItemText = content.ItemText;
		}
		if ( content.ItemTitle != null )
		{
			specialOffer.ItemTitle = content.ItemTitle;
		}

		try
		{
			_context.SpecialOffers.Update(specialOffer);
            		await _context.SaveChangesAsync();
                    
		}
		catch ( Exception e )
		{
			Console.WriteLine( e );
			throw;
		}
		
		
		return true;
	}
	
	public async Task<bool> UpdateProductCategoriesAsync(ProductCategories content)
	{
		var productCategories = await _context.ProductCategories.FindAsync( content.Id );
		if ( content.CategoryTitle != null )
		{
			productCategories.CategoryTitle = content.CategoryTitle;
		}
		_context.ProductCategories.Update(productCategories);
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