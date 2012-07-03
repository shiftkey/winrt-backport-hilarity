using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.Devices.Sms
{
	[Guid(1542776851u, 15187, 19566, 182, 26, 216, 106, 99, 117, 86, 80), Version(100794368u)]
	public interface ISmsBinaryMessage : ISmsMessage
	{
		SmsDataFormat Format
		{
			get;
			set;
		}
		byte[] GetData();
		void SetData([In] byte[] value);
	}
}
