using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;
namespace Windows.Networking.Proximity
{
	[ExclusiveTo(typeof(ProximityDevice)), Guid(4020806994u, 63201, 17193, 160, 252, 171, 107, 15, 210, 130, 98), Version(100794368u)]
	internal interface IProximityDevice
	{
		event DeviceArrivedEventHandler DeviceArrived;
		event DeviceDepartedEventHandler DeviceDeparted;
		ulong BitsPerSecond
		{
			get;
		}
		string DeviceId
		{
			get;
		}
		uint MaxMessageBytes
		{
			get;
		}
		long SubscribeForMessage([In] string messageType, [In] MessageReceivedHandler messageReceivedHandler);
		[DefaultOverload, Overload("PublishMessage")]
		long PublishMessage([In] string messageType, [In] string message);
		[DefaultOverload, Overload("PublishMessageWithCallback")]
		long PublishMessage([In] string messageType, [In] string message, [In] MessageTransmittedHandler messageTransmittedHandler);
		[DefaultOverload, Overload("PublishBinaryMessage")]
		long PublishBinaryMessage([In] string messageType, [In] IBuffer message);
		[DefaultOverload, Overload("PublishBinaryMessageWithCallback")]
		long PublishBinaryMessage([In] string messageType, [In] IBuffer message, [In] MessageTransmittedHandler messageTransmittedHandler);
		[DefaultOverload, Overload("PublishUriMessage")]
		long PublishUriMessage([In] Uri message);
		[DefaultOverload, Overload("PublishUriMessageWithCallback")]
		long PublishUriMessage([In] Uri message, [In] MessageTransmittedHandler messageTransmittedHandler);
		void StopSubscribingForMessage([In] long subscriptionId);
		void StopPublishingMessage([In] long messageId);
	}
}
