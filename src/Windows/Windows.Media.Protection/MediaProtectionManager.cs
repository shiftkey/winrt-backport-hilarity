using System;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.Media.Protection
{
	[Activatable(100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.MTA), Version(100794368u)]
	public sealed class MediaProtectionManager : IMediaProtectionManager
	{
		public extern event ComponentLoadFailedEventHandler ComponentLoadFailed
		{
			add;
			remove;
		}
		public extern event RebootNeededEventHandler RebootNeeded
		{
			add;
			remove;
		}
		public extern event ServiceRequestedEventHandler ServiceRequested
		{
			add;
			remove;
		}
		public extern IPropertySet Properties
		{
			get;
		}
		public extern MediaProtectionManager();
	}
}
