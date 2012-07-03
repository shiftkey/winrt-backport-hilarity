using System;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;
namespace Windows.Security.Cryptography.Core
{
	[ExclusiveTo(typeof(KeyDerivationParameters)), Guid(2079349095u, 1147, 19084, 150, 74, 70, 159, 253, 85, 34, 226), Version(100794368u)]
	internal interface IKeyDerivationParameters
	{
		uint IterationCount
		{
			get;
		}
		IBuffer KdfGenericBinary
		{
			get;
			set;
		}
	}
}
