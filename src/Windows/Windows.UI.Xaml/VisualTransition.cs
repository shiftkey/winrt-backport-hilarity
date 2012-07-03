using System;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Markup;
using Windows.UI.Xaml.Media.Animation;
namespace Windows.UI.Xaml
{
	[Composable(typeof(IVisualTransitionFactory), CompositionType.Public, 100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden, ContentProperty(Name = "Storyboard")]
	public class VisualTransition : DependencyObject, IVisualTransition
	{
		public extern string From
		{
			get;
			set;
		}
		public extern Duration GeneratedDuration
		{
			get;
			set;
		}
		public extern EasingFunctionBase GeneratedEasingFunction
		{
			get;
			set;
		}
		public extern Storyboard Storyboard
		{
			get;
			set;
		}
		public extern string To
		{
			get;
			set;
		}
		public extern VisualTransition();
	}
}
