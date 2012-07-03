using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.Media.Devices
{
	[ExclusiveTo(typeof(MediaDeviceControl)), Guid(4020821929u, 28533, 18531, 186, 11, 88, 63, 48, 54, 180, 222), Version(100794368u)]
	internal interface IMediaDeviceControl
	{
		MediaDeviceControlCapabilities Capabilities
		{
			get;
		}
		bool TryGetValue(out double value);
		bool TrySetValue([In] double value);
		bool TryGetAuto(out bool value);
		bool TrySetAuto([In] bool value);
	}
}
