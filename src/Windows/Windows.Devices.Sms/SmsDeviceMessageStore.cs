using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.Devices.Sms
{
	[DualApiPartition(version = 100794368u), Version(100794368u)]
	public sealed class SmsDeviceMessageStore : ISmsDeviceMessageStore
	{
		public extern uint MaxMessages
		{
			get;
		}
		public extern IAsyncAction DeleteMessageAsync([In] uint messageId);
		public extern IAsyncAction DeleteMessagesAsync([In] SmsMessageFilter messageFilter);
		public extern IAsyncOperation<ISmsMessage> GetMessageAsync([In] uint messageId);
		public extern IAsyncOperationWithProgress<IVectorView<ISmsMessage>, int> GetMessagesAsync([In] SmsMessageFilter messageFilter);
	}
}
