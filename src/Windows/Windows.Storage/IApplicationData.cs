using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Storage
{
	[ExclusiveTo(typeof(ApplicationData)), Guid(3285872567u, 46916, 19269, 176, 184, 34, 58, 9, 56, 208, 220), Version(100794368u)]
	internal interface IApplicationData
	{
		event TypedEventHandler<ApplicationData, object> DataChanged;
		StorageFolder LocalFolder
		{
			get;
		}
		ApplicationDataContainer LocalSettings
		{
			get;
		}
		StorageFolder RoamingFolder
		{
			get;
		}
		ApplicationDataContainer RoamingSettings
		{
			get;
		}
		ulong RoamingStorageQuota
		{
			get;
		}
		StorageFolder TemporaryFolder
		{
			get;
		}
		uint Version
		{
			get;
		}
		IAsyncAction SetVersionAsync([In] uint desiredVersion, [In] ApplicationDataSetVersionHandler handler);
		[Overload("ClearAllAsync")]
		IAsyncAction ClearAsync();
		[Overload("ClearAsync")]
		IAsyncAction ClearAsync([In] ApplicationDataLocality locality);
		void SignalDataChanged();
	}
}
