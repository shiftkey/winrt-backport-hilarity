using System;
using Windows.Foundation.Metadata;
namespace Windows.Media.Devices
{
	[ExclusiveTo(typeof(AudioDeviceController)), Guid(3990135688u, 31175, 20348, 144, 232, 239, 147, 75, 33, 88, 10), Version(100794368u)]
	internal interface IAudioDeviceController : IMediaDeviceController
	{
		bool Muted
		{
			get;
			set;
		}
		float VolumePercent
		{
			get;
			set;
		}
	}
}
