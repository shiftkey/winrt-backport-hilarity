using System;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.Media.Protection
{
	[ExclusiveTo(typeof(MediaProtectionManager)), Guid(1164527943u, 51009, 17227, 167, 158, 71, 76, 18, 217, 61, 47), Version(100794368u)]
	internal interface IMediaProtectionManager
	{
		event ComponentLoadFailedEventHandler ComponentLoadFailed;
		event RebootNeededEventHandler RebootNeeded;
		event ServiceRequestedEventHandler ServiceRequested;
		IPropertySet Properties
		{
			get;
		}
	}
}
