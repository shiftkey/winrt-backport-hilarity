using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.Store
{
	[MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u)]
	public sealed class ProductLicense : IProductLicense
	{
		public extern DateTime ExpirationDate
		{
			get;
		}
		public extern bool IsActive
		{
			get;
		}
		public extern string ProductId
		{
			get;
		}
	}
}
