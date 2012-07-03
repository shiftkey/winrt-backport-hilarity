using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;
namespace Windows.Security.Cryptography.DataProtection
{
	[Activatable(typeof(IDataProtectionProviderFactory), 100794368u), Activatable(100794368u), DualApiPartition(version = 100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u)]
	public sealed class DataProtectionProvider : IDataProtectionProvider
	{
		public extern DataProtectionProvider([In] string protectionDescriptor);
		public extern DataProtectionProvider();
		public extern IAsyncOperation<IBuffer> ProtectAsync([In] IBuffer data);
		public extern IAsyncOperation<IBuffer> UnprotectAsync([In] IBuffer data);
		public extern IAsyncAction ProtectStreamAsync([In] IInputStream src, [In] IOutputStream dest);
		public extern IAsyncAction UnprotectStreamAsync([In] IInputStream src, [In] IOutputStream dest);
	}
}
