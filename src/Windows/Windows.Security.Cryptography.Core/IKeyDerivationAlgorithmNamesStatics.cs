using System;
using Windows.Foundation.Metadata;
namespace Windows.Security.Cryptography.Core
{
	[ExclusiveTo(typeof(KeyDerivationAlgorithmNames)), Guid(2070820414u, 38098, 18233, 165, 123, 2, 46, 12, 58, 64, 42), Version(100794368u)]
	internal interface IKeyDerivationAlgorithmNamesStatics
	{
		string Pbkdf2Md5
		{
			get;
		}
		string Pbkdf2Sha1
		{
			get;
		}
		string Pbkdf2Sha256
		{
			get;
		}
		string Pbkdf2Sha384
		{
			get;
		}
		string Pbkdf2Sha512
		{
			get;
		}
		string Sp800108CtrHmacMd5
		{
			get;
		}
		string Sp800108CtrHmacSha1
		{
			get;
		}
		string Sp800108CtrHmacSha256
		{
			get;
		}
		string Sp800108CtrHmacSha384
		{
			get;
		}
		string Sp800108CtrHmacSha512
		{
			get;
		}
		string Sp80056aConcatMd5
		{
			get;
		}
		string Sp80056aConcatSha1
		{
			get;
		}
		string Sp80056aConcatSha256
		{
			get;
		}
		string Sp80056aConcatSha384
		{
			get;
		}
		string Sp80056aConcatSha512
		{
			get;
		}
	}
}
