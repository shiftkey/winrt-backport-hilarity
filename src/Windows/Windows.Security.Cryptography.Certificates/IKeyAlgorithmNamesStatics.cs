using System;
using Windows.Foundation.Metadata;
namespace Windows.Security.Cryptography.Certificates
{
	[ExclusiveTo(typeof(KeyAlgorithmNames)), Guid(1200645591u, 31431, 17793, 140, 59, 208, 112, 39, 20, 4, 72), Version(134217728u)]
	internal interface IKeyAlgorithmNamesStatics
	{
		string Dsa
		{
			get;
		}
		string Ecdh256
		{
			get;
		}
		string Ecdh384
		{
			get;
		}
		string Ecdh521
		{
			get;
		}
		string Ecdsa256
		{
			get;
		}
		string Ecdsa384
		{
			get;
		}
		string Ecdsa521
		{
			get;
		}
		string Rsa
		{
			get;
		}
	}
}
