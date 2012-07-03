using System;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;
namespace Windows.Security.Cryptography.Core
{
	[DualApiPartition(version = 100794368u), MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class EncryptedAndAuthenticatedData : IEncryptedAndAuthenticatedData
	{
		public extern IBuffer AuthenticationTag
		{
			get;
		}
		public extern IBuffer EncryptedData
		{
			get;
		}
	}
}
