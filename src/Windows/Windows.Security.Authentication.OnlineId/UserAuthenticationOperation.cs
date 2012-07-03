using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Security.Authentication.OnlineId
{
	[MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class UserAuthenticationOperation : IAsyncOperation<UserIdentity>, IAsyncInfo
	{
		public extern AsyncOperationCompletedHandler<UserIdentity> Completed
		{
			get;
			set;
		}
		public extern HResult ErrorCode
		{
			get;
		}
		public extern uint Id
		{
			get;
		}
		public extern AsyncStatus Status
		{
			get;
		}
		public extern UserIdentity GetResults();
		public extern void Cancel();
		public extern void Close();
	}
}
