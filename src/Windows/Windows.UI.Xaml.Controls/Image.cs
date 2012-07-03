using System;
using Windows.Foundation.Metadata;
using Windows.Media.PlayTo;
using Windows.UI.Xaml.Media;
namespace Windows.UI.Xaml.Controls
{
	[Activatable(100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(IImageStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class Image : FrameworkElement, IImage
	{
		public extern event ExceptionRoutedEventHandler ImageFailed
		{
			add;
			remove;
		}
		public extern event RoutedEventHandler ImageOpened
		{
			add;
			remove;
		}
		public extern Thickness NineGrid
		{
			get;
			set;
		}
		public extern PlayToSource PlayToSource
		{
			get;
		}
		public extern ImageSource Source
		{
			get;
			set;
		}
		public extern Stretch Stretch
		{
			get;
			set;
		}
		public static extern DependencyProperty NineGridProperty
		{
			get;
		}
		public static extern DependencyProperty PlayToSourceProperty
		{
			get;
		}
		public static extern DependencyProperty SourceProperty
		{
			get;
		}
		public static extern DependencyProperty StretchProperty
		{
			get;
		}
		public extern Image();
	}
}
