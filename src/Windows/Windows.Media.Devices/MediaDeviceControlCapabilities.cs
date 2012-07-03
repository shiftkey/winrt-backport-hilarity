using System;
using Windows.Foundation.Metadata;
namespace Windows.Media.Devices
{
	[MarshalingBehavior(MarshalingType.Standard), Threading(ThreadingModel.MTA), Version(100794368u)]
	public sealed class MediaDeviceControlCapabilities : IMediaDeviceControlCapabilities
	{
		public extern bool AutoModeSupported
		{
			get;
		}
		public extern double Default
		{
			get;
		}
		public extern double Max
		{
			get;
		}
		public extern double Min
		{
			get;
		}
		public extern double Step
		{
			get;
		}
		public extern bool Supported
		{
			get;
		}
	}
}
