using System;
using Windows.Foundation.Metadata;
namespace Windows.Security.Cryptography.Certificates
{
	[Activatable(134217728u), DualApiPartition(version = 134217728u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(134217728u)]
	public sealed class CertificateRequestProperties : ICertificateRequestProperties
	{
		public extern ExportOption Exportable
		{
			get;
			set;
		}
		public extern string FriendlyName
		{
			get;
			set;
		}
		public extern string HashAlgorithmName
		{
			get;
			set;
		}
		public extern string KeyAlgorithmName
		{
			get;
			set;
		}
		public extern KeyProtectionLevel KeyProtectionLevel
		{
			get;
			set;
		}
		public extern uint KeySize
		{
			get;
			set;
		}
		public extern string KeyStorageProviderName
		{
			get;
			set;
		}
		public extern EnrollKeyUsages KeyUsages
		{
			get;
			set;
		}
		public extern string Subject
		{
			get;
			set;
		}
		public extern CertificateRequestProperties();
	}
}
