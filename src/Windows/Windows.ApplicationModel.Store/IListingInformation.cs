using System;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.Store
{
	[ExclusiveTo(typeof(ListingInformation)), Guid(1485523647u, 48244, 17283, 183, 140, 153, 96, 99, 35, 222, 206), Version(100794368u)]
	internal interface IListingInformation
	{
		uint AgeRating
		{
			get;
		}
		string CurrentMarket
		{
			get;
		}
		string Description
		{
			get;
		}
		string FormattedPrice
		{
			get;
		}
		string Name
		{
			get;
		}
		IMapView<string, ProductListing> ProductListings
		{
			get;
		}
	}
}
