using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Storage
{
	[DualApiPartition(version = 100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(IApplicationDataStatics), 100794368u), Threading(ThreadingModel.MTA), Version(100794368u)]
	public sealed class ApplicationData : IApplicationData
	{
	    public event TypedEventHandler<ApplicationData, object> DataChanged;
		public extern StorageFolder LocalFolder
		{
			get;
		}
		public extern ApplicationDataContainer LocalSettings
		{
			get;
		}
		public extern StorageFolder RoamingFolder
		{
			get;
		}
		public extern ApplicationDataContainer RoamingSettings
		{
			get;
		}
		public extern ulong RoamingStorageQuota
		{
			get;
		}
		public extern StorageFolder TemporaryFolder
		{
			get;
		}
		public extern uint Version
		{
			get;
		}
		public static extern ApplicationData Current
		{
			get;
		}
		public extern IAsyncAction SetVersionAsync([In] uint desiredVersion, [In] ApplicationDataSetVersionHandler handler);
		[Overload("ClearAllAsync")]
		public extern IAsyncAction ClearAsync();
		[Overload("ClearAsync")]
		public extern IAsyncAction ClearAsync([In] ApplicationDataLocality locality);
		public extern void SignalDataChanged();
	}
}
