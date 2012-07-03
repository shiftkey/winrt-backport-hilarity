using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.Devices.Sms
{
	[Guid(3592196172u, 42133, 18559, 154, 111, 151, 21, 72, 197, 188, 159), Version(100794368u)]
	public interface ISmsTextMessage : ISmsMessage
	{
		string Body
		{
			get;
			set;
		}
		SmsEncoding Encoding
		{
			get;
			set;
		}
		string From
		{
			get;
			set;
		}
		uint PartCount
		{
			get;
		}
		uint PartNumber
		{
			get;
		}
		uint PartReferenceId
		{
			get;
		}
		DateTime Timestamp
		{
			get;
		}
		string To
		{
			get;
			set;
		}
		IVectorView<ISmsBinaryMessage> ToBinaryMessages([In] SmsDataFormat format);
	}
}
