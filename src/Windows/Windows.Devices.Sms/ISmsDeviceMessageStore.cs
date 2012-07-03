using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.Devices.Sms
{
	[ExclusiveTo(typeof(SmsDeviceMessageStore)), Guid(2559177299u, 61832, 17447, 141, 84, 206, 12, 36, 35, 197, 193), Version(100794368u)]
	internal interface ISmsDeviceMessageStore
	{
		uint MaxMessages
		{
			get;
		}
		IAsyncAction DeleteMessageAsync([In] uint messageId);
		IAsyncAction DeleteMessagesAsync([In] SmsMessageFilter messageFilter);
		IAsyncOperation<ISmsMessage> GetMessageAsync([In] uint messageId);
		IAsyncOperationWithProgress<IVectorView<ISmsMessage>, int> GetMessagesAsync([In] SmsMessageFilter messageFilter);
	}
}
