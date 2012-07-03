using System;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;
namespace Windows.Security.Cryptography.Core
{
	[ExclusiveTo(typeof(EncryptedAndAuthenticatedData)), Guid(1873031143u, 7883, 19200, 190, 165, 96, 184, 63, 134, 47, 23), Version(100794368u)]
	internal interface IEncryptedAndAuthenticatedData
	{
		IBuffer AuthenticationTag
		{
			get;
		}
		IBuffer EncryptedData
		{
			get;
		}
	}
}
