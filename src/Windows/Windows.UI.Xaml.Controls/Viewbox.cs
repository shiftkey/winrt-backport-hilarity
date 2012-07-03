using System;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Markup;
using Windows.UI.Xaml.Media;
namespace Windows.UI.Xaml.Controls
{
	[Activatable(100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(IViewboxStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden, ContentProperty(Name = "Child")]
	public sealed class Viewbox : FrameworkElement, IViewbox
	{
		public extern UIElement Child
		{
			get;
			set;
		}
		public extern Stretch Stretch
		{
			get;
			set;
		}
		public extern StretchDirection StretchDirection
		{
			get;
			set;
		}
		public static extern DependencyProperty StretchDirectionProperty
		{
			get;
		}
		public static extern DependencyProperty StretchProperty
		{
			get;
		}
		public extern Viewbox();
	}
}
