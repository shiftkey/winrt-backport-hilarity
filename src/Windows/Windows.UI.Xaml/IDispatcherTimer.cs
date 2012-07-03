using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml
{
	[ExclusiveTo(typeof(DispatcherTimer)), Guid(3512782406u, 52514, 20319, 140, 151, 64, 230, 29, 163, 226, 220), Version(100794368u), WebHostHidden]
	internal interface IDispatcherTimer
	{
		event EventHandler<object> Tick;
		TimeSpan Interval
		{
			get;
			set;
		}
		bool IsEnabled
		{
			get;
		}
		void Start();
		void Stop();
	}
}
