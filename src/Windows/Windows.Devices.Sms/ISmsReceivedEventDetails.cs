using System;
using Windows.Foundation.Metadata;
namespace Windows.Devices.Sms
{
	[ExclusiveTo(typeof(SmsReceivedEventDetails)), Guid(1538592533u, 58477, 19586, 132, 125, 90, 3, 4, 193, 213, 61), Version(100794368u)]
	internal interface ISmsReceivedEventDetails
	{
		string DeviceId
		{
			get;
		}
		uint MessageIndex
		{
			get;
		}
	}
}
