using System;
using Windows.Foundation.Metadata;
namespace Windows.Security.Cryptography.Certificates
{
	[DualApiPartition(version = 134217728u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(IKeyStorageProviderNamesStatics), 134217728u), Threading(ThreadingModel.Both), Version(134217728u)]
	public static class KeyStorageProviderNames
	{
		public static extern string PlatformKeyStorageProvider
		{
			get;
		}
		public static extern string SmartcardKeyStorageProvider
		{
			get;
		}
		public static extern string SoftwareKeyStorageProvider
		{
			get;
		}
	}
}
