using System;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Markup;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;
namespace Windows.UI.Xaml.Controls
{
	[Activatable(100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(IBorderStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden, ContentProperty(Name = "Child")]
	public sealed class Border : FrameworkElement, IBorder
	{
		public extern Brush Background
		{
			get;
			set;
		}
		public extern Brush BorderBrush
		{
			get;
			set;
		}
		public extern Thickness BorderThickness
		{
			get;
			set;
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
		public extern CornerRadius CornerRadius
		{
			get;
			set;
		}
		public extern Thickness Padding
		{
			get;
			set;
		}
		public static extern DependencyProperty BackgroundProperty
		{
			get;
		}
		public static extern DependencyProperty BorderBrushProperty
		{
			get;
		}
		public static extern DependencyProperty BorderThicknessProperty
		{
			get;
		}
		public static extern DependencyProperty ChildTransitionsProperty
		{
			get;
		}
		public static extern DependencyProperty CornerRadiusProperty
		{
			get;
		}
		public static extern DependencyProperty PaddingProperty
		{
			get;
		}
		public extern Border();
	}
}
