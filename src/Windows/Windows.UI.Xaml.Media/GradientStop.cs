using System;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Markup;
namespace Windows.UI.Xaml.Media
{
	[Activatable(100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(IGradientStopStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden, ContentProperty(Name = "Color")]
	public sealed class GradientStop : DependencyObject, IGradientStop
	{
		public extern Color Color
		{
			get;
			set;
		}
		public extern double Offset
		{
			get;
			set;
		}
		public static extern DependencyProperty ColorProperty
		{
			get;
		}
		public static extern DependencyProperty OffsetProperty
		{
			get;
		}
		public extern GradientStop();
	}
}
