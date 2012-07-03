using System;
using Windows.Foundation.Metadata;
namespace Windows.Security.Cryptography.Core
{
	[ExclusiveTo(typeof(HashAlgorithmNames)), Guid(1801323798u, 56982, 20234, 141, 87, 220, 201, 218, 227, 108, 118), Version(100794368u)]
	internal interface IHashAlgorithmNamesStatics
	{
		string Md5
		{
			get;
		}
		string Sha1
		{
			get;
		}
		string Sha256
		{
			get;
		}
		string Sha384
		{
			get;
		}
		string Sha512
		{
			get;
		}
	}
}
