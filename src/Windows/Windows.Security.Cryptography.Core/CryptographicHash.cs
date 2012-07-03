using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;
namespace Windows.Security.Cryptography.Core
{
	[DualApiPartition(version = 100794368u), MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class CryptographicHash : IHashComputation
	{
		public extern void Append([In] IBuffer data);
		public extern IBuffer GetValueAndReset();
	}
}
