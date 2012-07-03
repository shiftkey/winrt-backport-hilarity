using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Security.ExchangeActiveSyncProvisioning
{
	[Activatable(100794368u), Threading(ThreadingModel.Both), Version(100794368u)]
	public sealed class EasClientSecurityPolicy : IEasClientSecurityPolicy
	{
		public extern bool DisallowConvenienceLogon
		{
			get;
			set;
		}
		public extern TimeSpan MaxInactivityTimeLock
		{
			get;
			set;
		}
		public extern byte MaxPasswordFailedAttempts
		{
			get;
			set;
		}
		public extern byte MinPasswordComplexCharacters
		{
			get;
			set;
		}
		public extern byte MinPasswordLength
		{
			get;
			set;
		}
		public extern TimeSpan PasswordExpiration
		{
			get;
			set;
		}
		public extern uint PasswordHistory
		{
			get;
			set;
		}
		public extern bool RequireEncryption
		{
			get;
			set;
		}
		public extern EasClientSecurityPolicy();
		public extern EasComplianceResults CheckCompliance();
		public extern IAsyncOperation<EasComplianceResults> ApplyAsync();
	}
}
