using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.System.Threading
{
	[ExclusiveTo(typeof(ThreadPoolTimer)), Guid(1498332792u, 21994, 19080, 165, 13, 52, 2, 174, 31, 156, 242), Version(100794368u), WebHostHidden]
	internal interface IThreadPoolTimer
	{
		TimeSpan Delay
		{
			get;
		}
		TimeSpan Period
		{
			get;
		}
		void Cancel();
	}
}
