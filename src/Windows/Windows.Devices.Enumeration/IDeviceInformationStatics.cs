using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.Devices.Enumeration
{
	[ExclusiveTo(typeof(DeviceInformation)), Guid(3246329870u, 14918, 19064, 128, 19, 118, 157, 201, 185, 115, 144), Version(100794368u)]
	internal interface IDeviceInformationStatics
	{
		[DefaultOverload, Overload("CreateFromIdAsync")]
		IAsyncOperation<DeviceInformation> CreateFromIdAsync([In] string id);
		[DefaultOverload, Overload("CreateFromIdAsyncAdditionalProperties")]
		IAsyncOperation<DeviceInformation> CreateFromIdAsync([In] string id, [In] IIterable<string> additionalProperties);
		[DefaultOverload, Overload("FindAllAsync")]
		IAsyncOperation<DeviceInformationCollection> FindAllAsync();
		[DefaultOverload, Overload("FindAllAsyncDeviceClass")]
		IAsyncOperation<DeviceInformationCollection> FindAllAsync([In] DeviceClass deviceClass);
		[Overload("FindAllAsyncAqsFilter")]
		IAsyncOperation<DeviceInformationCollection> FindAllAsync([In] string aqsFilter);
		[DefaultOverload, Overload("FindAllAsyncAqsFilterAndAdditionalProperties")]
		IAsyncOperation<DeviceInformationCollection> FindAllAsync([In] string aqsFilter, [In] IIterable<string> additionalProperties);
		[DefaultOverload, Overload("CreateWatcher")]
		DeviceWatcher CreateWatcher();
		[DefaultOverload, Overload("CreateWatcherDeviceClass")]
		DeviceWatcher CreateWatcher([In] DeviceClass deviceClass);
		[Overload("CreateWatcherAqsFilter")]
		DeviceWatcher CreateWatcher([In] string aqsFilter);
		[DefaultOverload, Overload("CreateWatcherAqsFilterAndAdditionalProperties")]
		DeviceWatcher CreateWatcher([In] string aqsFilter, [In] IIterable<string> additionalProperties);
	}
}
