using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Media.Protection
{
	[Static(typeof(IComponentRenewalStatics), 100794368u), Version(100794368u)]
	public static class ComponentRenewal
	{
		public static extern IAsyncOperationWithProgress<RenewalStatus, uint> RenewSystemComponentsAsync([In] RevocationAndRenewalInformation information);
	}
}
