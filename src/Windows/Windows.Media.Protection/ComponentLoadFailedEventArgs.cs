using System;
using Windows.Foundation.Metadata;
namespace Windows.Media.Protection
{
	[MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class ComponentLoadFailedEventArgs : IComponentLoadFailedEventArgs
	{
		public extern MediaProtectionServiceCompletion Completion
		{
			get;
		}
		public extern RevocationAndRenewalInformation Information
		{
			get;
		}
	}
}
