using System;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.Devices.Sms
{
	[Version(100794368u)]
	public sealed class GetSmsMessagesOperation : IAsyncOperationWithProgress<IVectorView<ISmsMessage>, int>, IAsyncInfo
	{
		public extern AsyncOperationWithProgressCompletedHandler<IVectorView<ISmsMessage>, int> Completed
		{
			get;
			set;
		}
		public extern AsyncOperationProgressHandler<IVectorView<ISmsMessage>, int> Progress
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
		public extern IVectorView<ISmsMessage> GetResults();
		public extern void Cancel();
		public extern void Close();
	}
}
