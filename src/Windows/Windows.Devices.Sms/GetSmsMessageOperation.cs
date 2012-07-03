using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Devices.Sms
{
	[Version(100794368u)]
	public sealed class GetSmsMessageOperation : IAsyncOperation<ISmsMessage>, IAsyncInfo
	{
		public extern AsyncOperationCompletedHandler<ISmsMessage> Completed
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
		public extern ISmsMessage GetResults();
		public extern void Cancel();
		public extern void Close();
	}
}
