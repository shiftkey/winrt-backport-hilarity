using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.Devices.Enumeration
{
	[ExclusiveTo(typeof(DeviceInformation)), Guid(2879454101u, 17304, 18589, 142, 68, 230, 19, 9, 39, 1, 31), Version(100794368u)]
	internal interface IDeviceInformation
	{
		EnclosureLocation EnclosureLocation
		{
			get;
		}
		string Id
		{
			get;
		}
		bool IsDefault
		{
			get;
		}
		bool IsEnabled
		{
			get;
		}
		string Name
		{
			get;
		}
		IMapView<string, object> Properties
		{
			[return: HasVariant]
			get;
		}
		void Update([In] DeviceInformationUpdate updateInfo);
		IAsyncOperation<DeviceThumbnail> GetThumbnailAsync();
		IAsyncOperation<DeviceThumbnail> GetGlyphThumbnailAsync();
	}
}
