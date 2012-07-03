using System;
using Windows.Foundation.Metadata;
namespace Windows.Media.Devices
{
	[ExclusiveTo(typeof(MediaDeviceControlCapabilities)), Guid(587225110u, 60293, 17378, 185, 43, 130, 64, 213, 238, 112, 236), Version(100794368u)]
	internal interface IMediaDeviceControlCapabilities
	{
		bool AutoModeSupported
		{
			get;
		}
		double Default
		{
			get;
		}
		double Max
		{
			get;
		}
		double Min
		{
			get;
		}
		double Step
		{
			get;
		}
		bool Supported
		{
			get;
		}
	}
}
