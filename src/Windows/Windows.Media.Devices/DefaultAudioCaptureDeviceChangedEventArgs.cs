using System;
using Windows.Foundation.Metadata;
namespace Windows.Media.Devices
{
	[MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class DefaultAudioCaptureDeviceChangedEventArgs : IDefaultAudioDeviceChangedEventArgs
	{
		public extern string Id
		{
			get;
		}
		public extern AudioDeviceRole Role
		{
			get;
		}
	}
}
