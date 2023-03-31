namespace optricon_home.Extentions;

using Microsoft.EntityFrameworkCore;
using Models;

public static class ModelBuilderExtentions
{
	public static void Seed(this ModelBuilder modelBuilder)
	{
		modelBuilder.Entity<MediaObjects>()
		            .HasData( new
			                      {
			                      Id = 1,
			                      Title = "New Products",
			                      ImagePath = "/images/Bird.png",
			                      ImageAlt = "Bird catching fish from River",
			                      Text =
				                      "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed euismod, nunc ut aliquam aliquam, nunc nisl aliquet nisl, eget aliquam nisl nisl sit amet lorem.",
			                      ButtonText = "New Products"
			                      },
		                      new
			                      {
			                      Id = 2,
			                      Title = "Field Events",
			                      ImagePath = "/images/Photographers.png",
			                      ImageAlt = "Group of Photographers with Long-lens",
			                      Text =
				                      "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed euismod, nunc ut aliquam aliquam, nunc nisl aliquet nisl, eget aliquam nisl nisl sit amet lorem.",
			                      ButtonText = "View Events"
			                      },
		                      new
			                      {
			                      Id = 3,
			                      Title = "Latest News",
			                      ImagePath = "/images/Landscape.png",
			                      ImageAlt = "Landscape with Mountains",
			                      Text =
				                      "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed euismod, nunc ut aliquam aliquam, nunc nisl aliquet nisl, eget aliquam nisl nisl sit amet lorem.",
			                      ButtonText = "Read Article"
			                      },
		                      new
			                      {
			                      Id = 4,
			                      Title = "Gallery",
			                      ImagePath = "/images/Bird.png",
			                      ImageAlt = "Bird in tree",
			                      Text =
				                      "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed euismod, nunc ut aliquam aliquam, nunc nisl aliquet nisl, eget aliquam nisl nisl sit amet lorem.",
			                      ButtonText = "View Gallery"
			                      }
		             );
		modelBuilder.Entity<SpecialOffers>()
		            .HasData( new
			                      {
			                      Id = 1,
			                      ImagePath = "/images/Money.png",
			                      ImageAlt = "Money",
			                      ItemTitle = "Discovery WP PC",
			                      Text = "£20 Cashback"
			                      },
		                      new
			                      {
			                      Id = 2,
			                      ImagePath = "/images/Olympus.png",
			                      ImageAlt = "Olympus Camera",
			                      ItemTitle = "HR ED Fieldscopes",
			                      Text = "Free Digiscoping Kit",
			                      },
		                      new
			                      {
			                      Id = 3,
			                      ImagePath = "/images/Otricon_Cam.png",
			                      ImageAlt = "Otricon Camera",
			                      ItemTitle = "IS 60 WP FieldScope Kits",
			                      Text = "Save 25%"
			                      }
		             );
		modelBuilder.Entity<ProductCategories>()
		            .HasData( new
			                      {
			                      Id = 1,
			                      ImagePath = "/images/Binocula_1.png",
			                      ImageAlt = "Binocula 1",
			                      CategoryTitle = "Binoculars",
			                      },
		                      new
			                      {
			                      Id = 2,
			                      ImagePath = "/images/Binocula_2.png",
			                      ImageAlt = "Binocula 2",
			                      CategoryTitle = "Compact Binoculars",
			                      },
		                      new
			                      {
			                      Id = 3,
			                      ImagePath = "/images/Binocula_3.png",
			                      ImageAlt = "Binocula 3",
			                      CategoryTitle = "Telescopes & Eyepieces",
			                      },
		                      new
			                      {
			                      Id = 4,
			                      ImagePath = "/images/Binocula_4.png",
			                      ImageAlt = "Binocula 4",
			                      CategoryTitle = "Observation & Marine",
			                      }
		             );
	}

	}
