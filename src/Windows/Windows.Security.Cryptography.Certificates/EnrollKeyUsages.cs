using System;
using Windows.Foundation.Metadata;
namespace Windows.Security.Cryptography.Certificates
{
	[Flags, Version(134217728u)]
	public enum EnrollKeyUsages : uint
	{
		None = 0u,
		Decryption = 1u,
		Signing = 2u,
		KeyAgreement = 4u,
		All = 16777215u
	}
}
