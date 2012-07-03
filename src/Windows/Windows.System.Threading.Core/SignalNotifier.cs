using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.System.Threading.Core
{
	[MarshalingBehavior(MarshalingType.Agile), Static(typeof(ISignalNotifierStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class SignalNotifier : ISignalNotifier
	{
		public extern void Enable();
		public extern void Terminate();
		[Overload("AttachToEvent")]
		public static extern SignalNotifier AttachToEvent([In] string name, [In] SignalHandler handler);
		[Overload("AttachToEventWithTimeout")]
		public static extern SignalNotifier AttachToEvent([In] string name, [In] SignalHandler handler, [In] TimeSpan timeout);
		[Overload("AttachToSemaphore")]
		public static extern SignalNotifier AttachToSemaphore([In] string name, [In] SignalHandler handler);
		[Overload("AttachToSemaphoreWithTimeout")]
		public static extern SignalNotifier AttachToSemaphore([In] string name, [In] SignalHandler handler, [In] TimeSpan timeout);
	}
}
