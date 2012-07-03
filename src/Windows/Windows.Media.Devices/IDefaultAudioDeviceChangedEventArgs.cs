using System;
using Windows.Foundation.Metadata;
namespace Windows.Media.Devices
{
	[Guid(286230575u, 7173, 18007, 161, 142, 71, 201, 182, 159, 7, 171), Version(100794368u)]
	public interface IDefaultAudioDeviceChangedEventArgs
	{
		string Id
		{
			get;
		}
		AudioDeviceRole Role
		{
			get;
		}
	}
}
