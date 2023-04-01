namespace optricon_home.Controllers;

using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Models;
using Models.DTOs;
using Services;

[ApiController]
[Route("api/[controller]")]
public class HomeContentController : Controller
{
	private readonly IContentService _contentService;
	
	public HomeContentController(IContentService contentService)
	{
		_contentService = contentService;
	}
	
	[HttpPut( "mediaObjects/{id}" )]
	public async Task<IActionResult> PutMediaObject([FromBody] MediaObjectsDTO content)
	{
		var mediaObject = new MediaObjects()
			{
				Id = content.Id ?? 0, Title = content.Title, Text = content.Text, ButtonText = content.ButtonText
			};

		if ( await _contentService.UpdateMediaObjectsAsync( mediaObject ) )
		{
			return Ok();
		}
			else
		{
			return BadRequest();
		} 
	}
	
	[HttpPut( "specialOffers/{id}" )]
	public async Task<IActionResult> PutSpecialOffers([FromBody] SpecialOffersDto content)
	{
		Console.WriteLine(content.ItemText);
		Console.WriteLine(content.ItemTitle);
		var specialOffer = new SpecialOffers()
			{
				Id = content.Id ?? 0, ItemTitle = content.ItemTitle, ItemText = content.ItemText
			};
		if ( await _contentService.UpdateSpecialOffersAsync(specialOffer) )
		{
			return Ok();
		}
		else
		{
			return BadRequest();
		} 
	}
	
	[HttpPut( "productCategories/{id}" )]
	public async Task<IActionResult> PutProductCategories([FromBody] ProductCategoriesDTO content)
	{
		var productCategories = new ProductCategories()
			{
			Id = content.Id ?? 0, CategoryTitle = content.CategoryTitle
			};
		if ( await _contentService.UpdateProductCategoriesAsync(productCategories) )
		{
			return Ok();
		}
		else
		{
			return BadRequest();
		} 
	}
}