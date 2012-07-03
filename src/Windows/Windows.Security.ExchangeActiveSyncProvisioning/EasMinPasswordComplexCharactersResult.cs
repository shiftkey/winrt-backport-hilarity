using System;
using Windows.Foundation.Metadata;
namespace Windows.Security.ExchangeActiveSyncProvisioning
{
	[Version(100794368u)]
	public enum EasMinPasswordComplexCharactersResult
	{
		NotEvaluated,
		Compliant,
		CanBeCompliant,
		RequestedPolicyIsStricter,
		RequestedPolicyNotEnforceable,
		InvalidParameter,
		CurrentUserHasBlankPassword,
		AdminsHaveBlankPassword,
		UserCannotChangePassword,
		AdminsCannotChangePassword,
		LocalControlledUsersCannotChangePassword,
		ConnectedAdminsProviderPolicyIsWeak,
		ConnectedUserProviderPolicyIsWeak,
		ChangeConnectedAdminsPassword,
		ChangeConnectedUserPassword
	}
}
