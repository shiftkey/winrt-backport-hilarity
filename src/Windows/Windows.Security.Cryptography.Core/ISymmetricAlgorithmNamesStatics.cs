using System;
using Windows.Foundation.Metadata;
namespace Windows.Security.Cryptography.Core
{
	[ExclusiveTo(typeof(SymmetricAlgorithmNames)), Guid(1752199803u, 51606, 20142, 132, 215, 121, 178, 174, 183, 59, 156), Version(100794368u)]
	internal interface ISymmetricAlgorithmNamesStatics
	{
		string AesCbc
		{
			get;
		}
		string AesCbcPkcs7
		{
			get;
		}
		string AesCcm
		{
			get;
		}
		string AesEcb
		{
			get;
		}
		string AesEcbPkcs7
		{
			get;
		}
		string AesGcm
		{
			get;
		}
		string DesCbc
		{
			get;
		}
		string DesCbcPkcs7
		{
			get;
		}
		string DesEcb
		{
			get;
		}
		string DesEcbPkcs7
		{
			get;
		}
		string Rc2Cbc
		{
			get;
		}
		string Rc2CbcPkcs7
		{
			get;
		}
		string Rc2Ecb
		{
			get;
		}
		string Rc2EcbPkcs7
		{
			get;
		}
		string Rc4
		{
			get;
		}
		string TripleDesCbc
		{
			get;
		}
		string TripleDesCbcPkcs7
		{
			get;
		}
		string TripleDesEcb
		{
			get;
		}
		string TripleDesEcbPkcs7
		{
			get;
		}
	}
}
