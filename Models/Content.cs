namespace optricon_home.Models;

using System.ComponentModel.DataAnnotations;

public class Content
{
	public List<MediaObjects> MediaObjectsList { get; set; }
	public List<SpecialOffers> SpecialOffersList { get; set; }
}