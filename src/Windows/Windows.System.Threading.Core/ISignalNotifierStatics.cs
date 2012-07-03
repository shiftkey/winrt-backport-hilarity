using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.System.Threading.Core
{
	[ExclusiveTo(typeof(SignalNotifier)), Guid(474891622u, 33792, 18131, 161, 21, 125, 12, 13, 252, 159, 98), Version(100794368u), WebHostHidden]
	internal interface ISignalNotifierStatics
	{
		[Overload("AttachToEvent")]
		SignalNotifier AttachToEvent([In] string name, [In] SignalHandler handler);
		[Overload("AttachToEventWithTimeout")]
		SignalNotifier AttachToEvent([In] string name, [In] SignalHandler handler, [In] TimeSpan timeout);
		[Overload("AttachToSemaphore")]
		SignalNotifier AttachToSemaphore([In] string name, [In] SignalHandler handler);
		[Overload("AttachToSemaphoreWithTimeout")]
		SignalNotifier AttachToSemaphore([In] string name, [In] SignalHandler handler, [In] TimeSpan timeout);
	}
}
