using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Markup;
using Windows.UI.Xaml.Media.Animation;
namespace Windows.UI.Xaml.Controls.Primitives
{
	[Activatable(100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(IPopupStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden, ContentProperty(Name = "Child")]
	public sealed class Popup : FrameworkElement, IPopup
	{
		public extern event EventHandler<object> Closed
		{
			add;
			remove;
		}
		public extern event EventHandler<object> Opened
		{
			add;
			remove;
		}
		public extern UIElement Child
		{
			get;
			set;
		}
		public extern TransitionCollection ChildTransitions
		{
			get;
			set;
		}
		public extern double HorizontalOffset
		{
			get;
			set;
		}
		public extern bool IsLightDismissEnabled
		{
			get;
			set;
		}
		public extern bool IsOpen
		{
			get;
			set;
		}
		public extern double VerticalOffset
		{
			get;
			set;
		}
		public static extern DependencyProperty ChildProperty
		{
			get;
		}
		public static extern DependencyProperty ChildTransitionsProperty
		{
			get;
		}
		public static extern DependencyProperty HorizontalOffsetProperty
		{
			get;
		}
		public static extern DependencyProperty IsLightDismissEnabledProperty
		{
			get;
		}
		public static extern DependencyProperty IsOpenProperty
		{
			get;
		}
		public static extern DependencyProperty VerticalOffsetProperty
		{
			get;
		}
		public extern Popup();
	}
}
