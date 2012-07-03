using System;
using Windows.Foundation.Metadata;
namespace Windows.Devices.Input
{
	[ExclusiveTo(typeof(TouchCapabilities)), Guid(551376377u, 5105, 18120, 146, 133, 44, 5, 250, 62, 218, 111), Version(100794368u)]
	internal interface ITouchCapabilities
	{
		uint Contacts
		{
			get;
		}
		int TouchPresent
		{
			get;
		}
	}
}
