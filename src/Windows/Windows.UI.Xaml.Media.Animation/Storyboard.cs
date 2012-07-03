using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Markup;
namespace Windows.UI.Xaml.Media.Animation
{
	[Activatable(100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(IStoryboardStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden, ContentProperty(Name = "Children")]
	public sealed class Storyboard : Timeline, IStoryboard
	{
		public extern TimelineCollection Children
		{
			get;
		}
		public static extern DependencyProperty TargetNameProperty
		{
			get;
		}
		public static extern DependencyProperty TargetPropertyProperty
		{
			get;
		}
		public extern Storyboard();
		public extern void Seek([In] TimeSpan offset);
		public extern void Stop();
		public extern void Begin();
		public extern void Pause();
		public extern void Resume();
		public extern ClockState GetCurrentState();
		public extern TimeSpan GetCurrentTime();
		public extern void SeekAlignedToLastTick([In] TimeSpan offset);
		public extern void SkipToFill();
		public static extern string GetTargetProperty([In] Timeline element);
		public static extern void SetTargetProperty([In] Timeline element, [In] string path);
		public static extern string GetTargetName([In] Timeline element);
		public static extern void SetTargetName([In] Timeline element, [In] string name);
		public static extern void SetTarget([In] Timeline timeline, [In] DependencyObject target);
	}
}
