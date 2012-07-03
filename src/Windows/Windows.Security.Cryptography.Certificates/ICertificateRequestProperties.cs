using System;
using Windows.Foundation.Metadata;
namespace Windows.Security.Cryptography.Certificates
{
	[ExclusiveTo(typeof(CertificateRequestProperties)), Guid(1216251126u, 38114, 19918, 136, 51, 26, 112, 10, 55, 162, 154), Version(134217728u)]
	internal interface ICertificateRequestProperties
	{
		ExportOption Exportable
		{
			get;
			set;
		}
		string FriendlyName
		{
			get;
			set;
		}
		string HashAlgorithmName
		{
			get;
			set;
		}
		string KeyAlgorithmName
		{
			get;
			set;
		}
		KeyProtectionLevel KeyProtectionLevel
		{
			get;
			set;
		}
		uint KeySize
		{
			get;
			set;
		}
		string KeyStorageProviderName
		{
			get;
			set;
		}
		EnrollKeyUsages KeyUsages
		{
			get;
			set;
		}
		string Subject
		{
			get;
			set;
		}
	}
}
