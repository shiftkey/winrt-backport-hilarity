using System;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.Activation
{
	[Guid(3444619689u, 52752, 17618, 130, 52, 195, 85, 160, 115, 239, 51), Version(100794368u)]
	public interface IDeviceActivatedEventArgs : IActivatedEventArgs
	{
		string DeviceInformationId
		{
			get;
		}
		string Verb
		{
			get;
		}
	}
}
