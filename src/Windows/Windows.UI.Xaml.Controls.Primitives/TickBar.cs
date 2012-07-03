using System;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media;
namespace Windows.UI.Xaml.Controls.Primitives
{
	[Activatable(100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(ITickBarStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class TickBar : FrameworkElement, ITickBar
	{
		public extern Brush Fill
		{
			get;
			set;
		}
		public static extern DependencyProperty FillProperty
		{
			get;
		}
		public extern TickBar();
	}
}
