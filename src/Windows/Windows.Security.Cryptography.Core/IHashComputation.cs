using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;
namespace Windows.Security.Cryptography.Core
{
	[ExclusiveTo(typeof(CryptographicHash)), Guid(1493488054u, 44337, 17923, 163, 164, 177, 189, 169, 142, 37, 98), Version(100794368u)]
	internal interface IHashComputation
	{
		void Append([In] IBuffer data);
		IBuffer GetValueAndReset();
	}
}
