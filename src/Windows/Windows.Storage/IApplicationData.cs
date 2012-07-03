using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Storage
{
	[ExclusiveTo(typeof(ApplicationData))]
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
