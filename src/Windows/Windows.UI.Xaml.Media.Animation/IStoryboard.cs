using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media.Animation
{
	[ExclusiveTo(typeof(Storyboard)), Guid(3562806894u, 13716, 17934, 152, 26, 50, 39, 27, 211, 170, 6), Version(100794368u), WebHostHidden]
	internal interface IStoryboard
	{
		TimelineCollection Children
		{
			get;
		}
		void Seek([In] TimeSpan offset);
		void Stop();
		void Begin();
		void Pause();
		void Resume();
		ClockState GetCurrentState();
		TimeSpan GetCurrentTime();
		void SeekAlignedToLastTick([In] TimeSpan offset);
		void SkipToFill();
	}
}
