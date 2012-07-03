using System;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.Activation
{
	[Guid(4217873672u, 11693, 18698, 145, 112, 220, 160, 54, 235, 17, 75), Version(100794368u)]
	public interface ICameraSettingsActivatedEventArgs : IActivatedEventArgs
	{
		object VideoDeviceController
		{
			get;
		}
		object VideoDeviceExtension
		{
			get;
		}
	}
}
