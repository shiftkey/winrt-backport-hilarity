using System;
using Windows.Foundation.Metadata;
namespace Windows.Media.Protection
{
	[Flags, Version(100794368u)]
	public enum RevocationAndRenewalReasons : uint
	{
		UserModeComponentLoad = 1u,
		KernelModeComponentLoad = 2u,
		AppComponent = 4u,
		GlobalRevocationListLoadFailed = 16u,
		InvalidGlobalRevocationListSignature = 32u,
		GlobalRevocationListAbsent = 4096u,
		ComponentRevoked = 8192u,
		InvalidComponentCertificateExtendedKeyUse = 16384u,
		ComponentCertificateRevoked = 32768u,
		InvalidComponentCertificateRoot = 65536u,
		ComponentHighSecurityCertificateRevoked = 131072u,
		ComponentLowSecurityCertificateRevoked = 262144u,
		BootDriverVerificationFailed = 1048576u,
		ComponentSignedWithTestCertificate = 16777216u,
		EncryptionFailure = 268435456u
	}
}
