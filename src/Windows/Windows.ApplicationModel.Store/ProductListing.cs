using System;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.Store
{
	[MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u)]
	public sealed class ProductListing : IProductListing
	{
		public extern string FormattedPrice
		{
			get;
		}
		public extern string Name
		{
			get;
		}
		public extern string ProductId
		{
			get;
		}
	}
}
