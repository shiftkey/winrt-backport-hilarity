using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Media.Protection
{
	[ExclusiveTo(typeof(ComponentRenewal)), Guid(1878773095u, 46997, 18629, 139, 123, 167, 196, 239, 226, 2, 227), Version(100794368u)]
	internal interface IComponentRenewalStatics
	{
		IAsyncOperationWithProgress<RenewalStatus, uint> RenewSystemComponentsAsync([In] RevocationAndRenewalInformation information);
	}
}
