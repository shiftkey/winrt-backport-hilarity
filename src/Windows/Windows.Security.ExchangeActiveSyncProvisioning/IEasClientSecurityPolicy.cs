using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Security.ExchangeActiveSyncProvisioning
{
	[ExclusiveTo(typeof(EasClientSecurityPolicy)), Guid(1169630050u, 57274, 19099, 172, 237, 111, 226, 173, 203, 100, 32), Version(100794368u)]
	internal interface IEasClientSecurityPolicy
	{
		bool DisallowConvenienceLogon
		{
			get;
			set;
		}
		TimeSpan MaxInactivityTimeLock
		{
			get;
			set;
		}
		byte MaxPasswordFailedAttempts
		{
			get;
			set;
		}
		byte MinPasswordComplexCharacters
		{
			get;
			set;
		}
		byte MinPasswordLength
		{
			get;
			set;
		}
		TimeSpan PasswordExpiration
		{
			get;
			set;
		}
		uint PasswordHistory
		{
			get;
			set;
		}
		bool RequireEncryption
		{
			get;
			set;
		}
		EasComplianceResults CheckCompliance();
		IAsyncOperation<EasComplianceResults> ApplyAsync();
	}
}
