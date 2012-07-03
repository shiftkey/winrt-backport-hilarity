using System;
using Windows.Foundation.Metadata;
namespace Windows.Security.ExchangeActiveSyncProvisioning
{
	[ExclusiveTo(typeof(EasComplianceResults)), Guid(1178347932u, 32537, 19558, 180, 3, 203, 69, 221, 87, 162, 179), Version(100794368u)]
	internal interface IEasComplianceResults
	{
		bool Compliant
		{
			get;
		}
		EasDisallowConvenienceLogonResult DisallowConvenienceLogonResult
		{
			get;
		}
		EasMaxInactivityTimeLockResult MaxInactivityTimeLockResult
		{
			get;
		}
		EasMaxPasswordFailedAttemptsResult MaxPasswordFailedAttemptsResult
		{
			get;
		}
		EasMinPasswordComplexCharactersResult MinPasswordComplexCharactersResult
		{
			get;
		}
		EasMinPasswordLengthResult MinPasswordLengthResult
		{
			get;
		}
		EasPasswordExpirationResult PasswordExpirationResult
		{
			get;
		}
		EasPasswordHistoryResult PasswordHistoryResult
		{
			get;
		}
		EasRequireEncryptionResult RequireEncryptionResult
		{
			get;
		}
	}
}
