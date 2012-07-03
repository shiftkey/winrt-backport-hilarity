using System;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Markup;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;
namespace Windows.UI.Xaml.Controls
{
	[Composable(typeof(IPanelFactory), CompositionType.Protected, 100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(IPanelStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden, ContentProperty(Name = "Children")]
	public class Panel : FrameworkElement, IPanel
	{
		public extern Brush Background
		{
			get;
			set;
		}
		public extern UIElementCollection Children
		{
			get;
		}
		public extern TransitionCollection ChildrenTransitions
		{
			get;
			set;
		}
		public extern bool IsItemsHost
		{
			get;
		}
		public static extern DependencyProperty BackgroundProperty
		{
			get;
		}
		public static extern DependencyProperty ChildrenTransitionsProperty
		{
			get;
		}
		public static extern DependencyProperty IsItemsHostProperty
		{
			get;
		}
		protected extern Panel();
	}
}
