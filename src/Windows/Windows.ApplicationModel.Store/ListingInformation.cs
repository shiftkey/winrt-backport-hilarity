using System;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.Store
{
	[MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u)]
	public sealed class ListingInformation : IListingInformation
	{
		public extern uint AgeRating
		{
			get;
		}
		public extern string CurrentMarket
		{
			get;
		}
		public extern string Description
		{
			get;
		}
		public extern string FormattedPrice
		{
			get;
		}
		public extern string Name
		{
			get;
		}
		public extern IMapView<string, ProductListing> ProductListings
		{
			get;
		}
	}
}
