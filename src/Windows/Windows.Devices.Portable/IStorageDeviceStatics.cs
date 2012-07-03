using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.Storage;
namespace Windows.Devices.Portable
{
	[ExclusiveTo(typeof(StorageDevice)), Guid(1590576366u, 6947, 19922, 134, 82, 188, 22, 79, 0, 49, 40), Version(100794368u)]
	internal interface IStorageDeviceStatics
	{
		StorageFolder FromId([In] string interfaceId);
		string GetDeviceSelector();
	}
}
