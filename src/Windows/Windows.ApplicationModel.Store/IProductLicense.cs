using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.Store
{
	[ExclusiveTo(typeof(ProductLicense)), Guid(909314247u, 11215, 19470, 143, 47, 232, 8, 170, 168, 249, 157), Version(100794368u)]
	internal interface IProductLicense
	{
		DateTime ExpirationDate
		{
			get;
		}
		bool IsActive
		{
			get;
		}
		string ProductId
		{
			get;
		}
	}
}
