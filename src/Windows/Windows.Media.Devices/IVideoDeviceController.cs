using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.Media.Capture;
namespace Windows.Media.Devices
{
	[ExclusiveTo(typeof(VideoDeviceController)), Guid(2572506485u, 11822, 16568, 182, 199, 248, 45, 16, 1, 50, 16), Version(100794368u)]
	internal interface IVideoDeviceController : IMediaDeviceController
	{
		MediaDeviceControl BacklightCompensation
		{
			get;
		}
		MediaDeviceControl Brightness
		{
			get;
		}
		MediaDeviceControl Contrast
		{
			get;
		}
		MediaDeviceControl Exposure
		{
			get;
		}
		MediaDeviceControl Focus
		{
			get;
		}
		MediaDeviceControl Hue
		{
			get;
		}
		MediaDeviceControl Pan
		{
			get;
		}
		MediaDeviceControl Roll
		{
			get;
		}
		MediaDeviceControl Tilt
		{
			get;
		}
		MediaDeviceControl WhiteBalance
		{
			get;
		}
		MediaDeviceControl Zoom
		{
			get;
		}
		bool TrySetPowerlineFrequency([In] PowerlineFrequency value);
		bool TryGetPowerlineFrequency(out PowerlineFrequency value);
	}
}
