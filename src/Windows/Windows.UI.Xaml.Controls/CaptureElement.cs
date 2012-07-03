using System;
using Windows.Foundation.Metadata;
using Windows.Media.Capture;
using Windows.UI.Xaml.Media;
namespace Windows.UI.Xaml.Controls
{
	[Activatable(100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(ICaptureElementStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class CaptureElement : FrameworkElement, ICaptureElement
	{
		public extern MediaCapture Source
		{
			get;
			set;
		}
		public extern Stretch Stretch
		{
			get;
			set;
		}
		public static extern DependencyProperty SourceProperty
		{
			get;
		}
		public static extern DependencyProperty StretchProperty
		{
			get;
		}
		public extern CaptureElement();
	}
}
