using System;
using Windows.Foundation.Metadata;
namespace Windows.Security.ExchangeActiveSyncProvisioning
{
	[Version(100794368u)]
	public enum EasPasswordExpirationResult
	{
		NotEvaluated,
		Compliant,
		CanBeCompliant,
		RequestedPolicyIsStricter,
		RequestedExpirationIncompatible,
		InvalidParameter,
		UserCannotChangePassword,
		AdminsCannotChangePassword,
		LocalControlledUsersCannotChangePassword
	}
}
