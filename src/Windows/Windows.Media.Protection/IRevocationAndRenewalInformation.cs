using System;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.Media.Protection
{
	[ExclusiveTo(typeof(RevocationAndRenewalInformation)), Guid(4087452539u, 9473, 17310, 166, 231, 111, 201, 94, 23, 95, 207), Version(100794368u)]
	internal interface IRevocationAndRenewalInformation
	{
		IVector<RevocationAndRenewalItem> Items
		{
			get;
		}
	}
}
