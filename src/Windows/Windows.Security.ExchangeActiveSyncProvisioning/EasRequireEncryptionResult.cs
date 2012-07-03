using System;
using Windows.Foundation.Metadata;
namespace Windows.Security.ExchangeActiveSyncProvisioning
{
	[Version(100794368u)]
	public enum EasRequireEncryptionResult
	{
		NotEvaluated,
		Compliant,
		CanBeCompliant,
		NotProvisionedOnAllVolumes,
		DeFixedDataNotSupported,
		DeHardwareNotCompliant,
		DeWinReNotConfigured,
		DeProtectionSuspended,
		DeOsVolumeNotProtected,
		DeProtectionNotYetEnabled,
		NoFeatureLicense,
		OsNotProtected
	}
}
