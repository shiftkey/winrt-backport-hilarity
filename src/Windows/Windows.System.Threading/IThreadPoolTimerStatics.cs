using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.System.Threading
{
	[ExclusiveTo(typeof(ThreadPoolTimer)), Guid(445291778u, 58498, 17947, 184, 199, 142, 250, 209, 204, 229, 144), Version(100794368u), WebHostHidden]
	internal interface IThreadPoolTimerStatics
	{
		[Overload("CreatePeriodicTimer")]
		ThreadPoolTimer CreatePeriodicTimer([In] TimerElapsedHandler handler, [In] TimeSpan period);
		[Overload("CreateTimer")]
		ThreadPoolTimer CreateTimer([In] TimerElapsedHandler handler, [In] TimeSpan delay);
		[Overload("CreatePeriodicTimerWithCompletion")]
		ThreadPoolTimer CreatePeriodicTimer([In] TimerElapsedHandler handler, [In] TimeSpan period, [In] TimerDestroyedHandler destroyed);
		[Overload("CreateTimerWithCompletion")]
		ThreadPoolTimer CreateTimer([In] TimerElapsedHandler handler, [In] TimeSpan delay, [In] TimerDestroyedHandler destroyed);
	}
}
