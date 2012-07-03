using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.System.Threading
{
	[MarshalingBehavior(MarshalingType.Agile), Static(typeof(IThreadPoolTimerStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class ThreadPoolTimer : IThreadPoolTimer
	{
		public extern TimeSpan Delay
		{
			get;
		}
		public extern TimeSpan Period
		{
			get;
		}
		public extern void Cancel();
		[Overload("CreatePeriodicTimer")]
		public static extern ThreadPoolTimer CreatePeriodicTimer([In] TimerElapsedHandler handler, [In] TimeSpan period);
		[Overload("CreateTimer")]
		public static extern ThreadPoolTimer CreateTimer([In] TimerElapsedHandler handler, [In] TimeSpan delay);
		[Overload("CreatePeriodicTimerWithCompletion")]
		public static extern ThreadPoolTimer CreatePeriodicTimer([In] TimerElapsedHandler handler, [In] TimeSpan period, [In] TimerDestroyedHandler destroyed);
		[Overload("CreateTimerWithCompletion")]
		public static extern ThreadPoolTimer CreateTimer([In] TimerElapsedHandler handler, [In] TimeSpan delay, [In] TimerDestroyedHandler destroyed);
	}
}
