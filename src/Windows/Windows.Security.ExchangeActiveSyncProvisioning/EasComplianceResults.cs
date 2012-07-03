using System;
using Windows.Foundation.Metadata;
namespace Windows.Security.ExchangeActiveSyncProvisioning
{
	[Version(100794368u)]
	public sealed class EasComplianceResults : IEasComplianceResults
	{
		public extern bool Compliant
		{
			get;
		}
		public extern EasDisallowConvenienceLogonResult DisallowConvenienceLogonResult
		{
			get;
		}
		public extern EasMaxInactivityTimeLockResult MaxInactivityTimeLockResult
		{
			get;
		}
		public extern EasMaxPasswordFailedAttemptsResult MaxPasswordFailedAttemptsResult
		{
			get;
		}
		public extern EasMinPasswordComplexCharactersResult MinPasswordComplexCharactersResult
		{
			get;
		}
		public extern EasMinPasswordLengthResult MinPasswordLengthResult
		{
			get;
		}
		public extern EasPasswordExpirationResult PasswordExpirationResult
		{
			get;
		}
		public extern EasPasswordHistoryResult PasswordHistoryResult
		{
			get;
		}
		public extern EasRequireEncryptionResult RequireEncryptionResult
		{
			get;
		}
	}
}
