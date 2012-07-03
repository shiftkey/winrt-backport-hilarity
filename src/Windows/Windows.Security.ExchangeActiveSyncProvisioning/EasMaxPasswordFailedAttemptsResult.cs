using System;
using Windows.Foundation.Metadata;
namespace Windows.Security.ExchangeActiveSyncProvisioning
{
	[Version(100794368u)]
	public enum EasMaxPasswordFailedAttemptsResult
	{
		NotEvaluated,
		Compliant,
		CanBeCompliant,
		RequestedPolicyIsStricter,
		InvalidParameter
	}
}
