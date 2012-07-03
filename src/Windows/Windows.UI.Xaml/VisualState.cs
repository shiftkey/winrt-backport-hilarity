using System;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Markup;
using Windows.UI.Xaml.Media.Animation;
namespace Windows.UI.Xaml
{
	[Activatable(100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden, ContentProperty(Name = "Storyboard")]
	public sealed class VisualState : DependencyObject, IVisualState
	{
		public extern string Name
		{
			get;
		}
		public extern Storyboard Storyboard
		{
			get;
			set;
		}
		public extern VisualState();
	}
}
