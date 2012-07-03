using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Markup;
using Windows.UI.Xaml.Media.Animation;
namespace Windows.UI.Xaml.Media
{
	[Activatable(typeof(ISolidColorBrushFactory), 100794368u), Activatable(100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(ISolidColorBrushStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden, ContentProperty(Name = "Color")]
	public sealed class SolidColorBrush : Brush, ISolidColorBrush
	{
		public extern Color Color
		{
			get;
			set;
		}
		public static extern DependencyProperty ColorProperty
		{
			[IndependentlyAnimatable]
			get;
		}
		public extern SolidColorBrush();
		public extern SolidColorBrush([In] Color color);
	}
}
