using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Security.Authentication.OnlineId
{
	[MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class SignOutUserOperation : IAsyncAction, IAsyncInfo
	{
		public extern AsyncActionCompletedHandler Completed
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
		public extern void GetResults();
		public extern void Cancel();
		public extern void Close();
	}
}
