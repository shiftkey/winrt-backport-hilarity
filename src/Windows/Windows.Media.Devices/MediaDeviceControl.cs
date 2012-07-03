using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.Media.Devices
{
	[MarshalingBehavior(MarshalingType.Standard), Threading(ThreadingModel.MTA), Version(100794368u)]
	public sealed class MediaDeviceControl : IMediaDeviceControl
	{
		public extern MediaDeviceControlCapabilities Capabilities
		{
			get;
		}
		public extern bool TryGetValue(out double value);
		public extern bool TrySetValue([In] double value);
		public extern bool TryGetAuto(out bool value);
		public extern bool TrySetAuto([In] bool value);
	}
}
