using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml
{
	[Composable(typeof(IDispatcherTimerFactory), CompositionType.Public, 100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public class DispatcherTimer : IDispatcherTimer
	{
		public extern event EventHandler<object> Tick
		{
			add;
			remove;
		}
		public extern TimeSpan Interval
		{
			get;
			set;
		}
		public extern bool IsEnabled
		{
			get;
		}
		public extern DispatcherTimer();
		public extern void Start();
		public extern void Stop();
	}
}
