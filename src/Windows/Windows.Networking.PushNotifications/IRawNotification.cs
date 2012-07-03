using System;
using Windows.Foundation.Metadata;
namespace Windows.Networking.PushNotifications
{
	[ExclusiveTo(typeof(RawNotification)), Guid(438465153u, 15225, 17068, 153, 99, 34, 171, 0, 212, 240, 183), Version(100794368u)]
	internal interface IRawNotification
	{
		string Content
		{
			get;
		}
	}
}
