using System;
using Windows.Foundation.Metadata;
namespace Windows.Security.ExchangeActiveSyncProvisioning
{
	[Version(100794368u)]
	public enum EasDisallowConvenienceLogonResult
	{
		NotEvaluated,
		Compliant,
		CanBeCompliant,
		RequestedPolicyIsStricter
	}
}
