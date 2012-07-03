using System;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.Store
{
	[ExclusiveTo(typeof(ProductListing)), Guid(1168627373u, 51024, 19868, 148, 124, 176, 13, 203, 249, 233, 194), Version(100794368u)]
	internal interface IProductListing
	{
		string FormattedPrice
		{
			get;
		}
		string Name
		{
			get;
		}
		string ProductId
		{
			get;
		}
	}
}
