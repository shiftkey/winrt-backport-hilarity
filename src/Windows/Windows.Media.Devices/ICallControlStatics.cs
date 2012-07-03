using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.Media.Devices
{
	[ExclusiveTo(typeof(CallControl)), Guid(60054229u, 34219, 16609, 175, 25, 86, 201, 67, 3, 176, 25), Version(100794368u)]
	internal interface ICallControlStatics
	{
		CallControl GetDefault();
		CallControl FromId([In] string deviceInterfaceId);
	}
}
