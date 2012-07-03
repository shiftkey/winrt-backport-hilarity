using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Devices.Sms
{
	[Version(100794368u)]
	public sealed class GetSmsDeviceOperation : IAsyncOperation<SmsDevice>, IAsyncInfo
	{
		public extern AsyncOperationCompletedHandler<SmsDevice> Completed
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
		public extern SmsDevice GetResults();
		public extern void Cancel();
		public extern void Close();
	}
}
